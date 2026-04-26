using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OliveFarmingAPI.Data;
using OliveFarmingAPI.DTOs;
using OliveFarmingAPI.Models;

namespace OliveFarmingAPI.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")] // Base route /api/Seasons
public class SeasonsController : ControllerBase
{

    private readonly FarmingDbContext _context;

    // Inject BD connection
    public SeasonsController(FarmingDbContext context)
    {
        _context = context;
    }

    // getAllSeasons -> GET: /api/Seasons
    [HttpGet(Name = "GetAllSeasons")]
    public async Task<ActionResult<List<string>>> GetAllSeasons()
    {
        var seasons = await _context.Seasons.Select(s => s.Name).ToListAsync();
        
        if (seasons == null)
        {
            return NotFound(new { errors = new[] { "No se han encontrado temporadas agrícolas" } });
        }

        return Ok(seasons);
    }

    // getSeasonsCount -> GET: /api/SeasonsCount
    [HttpGet("count", Name = "GetSeasonsCount")]
    public async Task<ActionResult<SeasonCountDTO>> GetSeasonsCount()
    {
        var count = await _context.Seasons.CountAsync();

        return Ok(new { seasonCount = count });
    }

    // addSeason -> POST: /api/Seasons
    [HttpPost(Name = "AddSeason")]
    public async Task<IActionResult> AddSeason([FromBody] SeasonsCreateDTO newSeasonDto)
    {
        // Check if season exists
        var seasonExists = await _context.Seasons.AnyAsync(s => s.Name == newSeasonDto.Name);
        if (seasonExists)
        {
            return BadRequest(new { errors = new[] { "La temporada agrícola ya existe" } });
        }

        Regex regex = new Regex("^[0-9]{2}/[0-9]{2}$");
        if (!regex.IsMatch(newSeasonDto.Name))
        {
            return BadRequest(new { errors = new[] { "El código de la temporada no tiene el formato correcto. Por favor, usa un formato como: 25/26" } });
        }

        // Mapping Season object
        var newSeason = new Season
        {
            Name = newSeasonDto.Name,
            StartDate = newSeasonDto.StartDate,
            EndDate = newSeasonDto.EndDate
        };

        // Save season
        _context.Seasons.Add(newSeason);
        await _context.SaveChangesAsync();

        return Ok("Se ha introducido la nueva temporada agrícola");
    }
}