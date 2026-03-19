using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OliveFarmingAPI.Data;
using OliveFarmingAPI.Models;

namespace OliveFarmingAPI.Controllers;

[ApiController]
[Route("api/[controller]")] // Esto generará la ruta base: /api/Rain
public class RainController : ControllerBase
{
    private readonly FarmingDbContext _context;

    // Inject BD connection
    public RainController(FarmingDbContext context)
    {
        _context = context;
    }

    // findBySeason -> GET: /api/Rain/season/{seasonId}
    [HttpGet("season/{seasonId}")]
    public async Task<IActionResult> FindBySeason(int seasonId)
    {
        // Get rainLogs by seasonId
        var rainLogs = await _context.RainLogs
            .Where(r => r.SeasonId == seasonId)
            .ToListAsync();

        if (!rainLogs.Any())
        {
            return NotFound(new { errors = new[] { "No se ha encontrado ninguna temporada de lluvias con ese ID" } });
        }

        return Ok(rainLogs);
    }

    // newRainLog -> POST: /api/Rain
    [HttpPost]
    public async Task<IActionResult> NewRainLog([FromBody] RainLog newLog)
    {
        // Check if season exists
        var seasonExists = await _context.Seasons.AnyAsync(s => s.Id == newLog.SeasonId);
        if (!seasonExists)
        {
            return BadRequest(new { errors = new[] { "No existe una temporada agrícola con ese ID" } });
        }

        // Save rain log
        _context.RainLogs.Add(newLog);
        await _context.SaveChangesAsync();

        return Ok("Se ha introducido un nuevo registro de lluvia");
    }

}