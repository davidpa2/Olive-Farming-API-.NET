using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OliveFarmingAPI.Data;

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
}