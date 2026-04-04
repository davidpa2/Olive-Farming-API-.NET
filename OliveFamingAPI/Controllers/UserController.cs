using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OliveFarmingAPI.Data;
using OliveFarmingAPI.Models;
using OliveFarmingAPI.DTOs;

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

    [HttpPost("register")]
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
}