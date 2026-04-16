using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OliveFarmingAPI.Data;
using OliveFarmingAPI.Models;
using OliveFarmingAPI.DTOs;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace OliveFarmingAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly FarmingDbContext _context;
    private readonly IConfiguration _config;

    public UsersController(FarmingDbContext context, IConfiguration config)
    {
        _context = context;
        _config = config; // Inyect configuration to read appsettings.json
    }

    [HttpPost("register", Name = "Register")]
    public async Task<IActionResult> Register([FromBody] UserRegisterDTO userDto)
    {
        var userExists = await _context.Users.AnyAsync(u => u.Email == userDto.Email);
        if (userExists)
            return BadRequest(new { errors = new[] { "Ya existe un usuario con ese email registrado" } });

        // Hash password
        var passwordHash = BCrypt.Net.BCrypt.HashPassword(userDto.Password);

        var newUser = new User
        {
            Email = userDto.Email,
            Name = userDto.Name,
            Surname = userDto.Surname,
            PasswordHash = passwordHash
        };

        _context.Users.Add(newUser);
        await _context.SaveChangesAsync();

        return Ok("Se ha registrado el usuario");
    }

    [HttpPost("login", Name = "Login")]
    public async Task<IActionResult> Login([FromBody] UserLoginDTO loginDto)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == loginDto.Email);
        if (user == null)
            return Unauthorized(new { errors = new[] { "Credenciales incorrectas" } });

        // Verify password
        if (!BCrypt.Net.BCrypt.Verify(loginDto.Password, user.PasswordHash))
            return Unauthorized(new { errors = new[] { "Credenciales incorrectas" } });

        // Generate JWT
        var token = GenerateJwtToken(user);

        return Ok(new { jwt = token });
    }

    [HttpGet("me", Name = "Me")]
    [Authorize]
    public async Task<IActionResult> Me()
    {
        // Get JWT data
        var userIdString = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        
        if (string.IsNullOrEmpty(userIdString) || !int.TryParse(userIdString, out int userId))
            return Unauthorized();

        var user = await _context.Users.FindAsync(userId);
        if (user == null) return NotFound();

        return Ok(new 
        { 
            name = user.Name, 
            surname = user.Surname, 
            email = user.Email 
        });
    }

    private string GenerateJwtToken(User user)
    {
        var secretKey = _config.GetSection("JwtSettings:SecretKey").Value;
        var keyBytes = Encoding.UTF8.GetBytes(secretKey!);
        var tokenHandler = new JwtSecurityTokenHandler();

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[] //Add id and email claims
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email)
            }),
            Expires = DateTime.UtcNow.AddDays(7), // setExpirationTime('7d')
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keyBytes), SecurityAlgorithms.HmacSha256Signature)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}