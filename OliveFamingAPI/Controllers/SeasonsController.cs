using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OliveFarmingAPI.Data;
using OliveFarmingAPI.Models;

namespace OliveFarmingAPI.Controllers;

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
    [HttpGet]
    public async Task<IActionResult> GetAllSeasons()
    {
        var seasons = await _context.Seasons.Select(s => s.Name).ToListAsync();
        
        if (seasons == null)
        {
            return NotFound(new { errors = new[] { "No se han encontrado temporadas agrícolas" } });
        }

        return Ok(seasons);
    }

    // addSeason -> POST: /api/Seasons
    [HttpPost]
    public async Task<IActionResult> AddSeason([FromBody] Season newSeason)
    {
        // Check if season exists
        var seasonExists = await _context.Seasons.AnyAsync(s => s.Name == newSeason.Name);
        if (seasonExists)
        {
            return BadRequest(new { errors = new[] { "La temporada agrícola ya existe" } });
        }

        // Save season
        _context.Seasons.Add(newSeason);
        await _context.SaveChangesAsync();

        return Ok("Se ha introducido la nueva temporada agrícola");
    }
}