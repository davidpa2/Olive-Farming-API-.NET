using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OliveFarmingAPI.Data;
using OliveFarmingAPI.DTOs;
using OliveFarmingAPI.Models;

namespace OliveFarmingAPI.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")] // Base route /api/Rain
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
    public async Task<IActionResult> NewRainLog([FromBody] RainLogCreateDTO newLogDto)
    {
        // Check if season exists
        var seasonExists = await _context.Seasons.AnyAsync(s => s.Id == newLogDto.SeasonId);
        if (!seasonExists)
        {
            return BadRequest(new { errors = new[] { "No existe una temporada agrícola con ese ID" } });
        }

        // Mapping Season object
        var newLog = new RainLog
        {
            Date = newLogDto.Date,
            Liters = newLogDto.Liters,
            SeasonId = newLogDto.SeasonId
        };

        // Save rain log
        _context.RainLogs.Add(newLog);
        await _context.SaveChangesAsync();

        return Ok("Se ha introducido un nuevo registro de lluvia");
    }

    // deleteRainLog -> DELETE: /api/Rain/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRainLog(int id)
    {
        // Find rainLog by ID
        var rainLog = await _context.RainLogs.FindAsync(id);
        
        if (rainLog == null)
        {
            return NotFound(new { errors = new[] { "No se ha encontrado un registro de lluvia con ese ID" } });
        }

        // Remove rain log
        _context.RainLogs.Remove(rainLog);
        await _context.SaveChangesAsync();

        return Ok("Se ha eliminado el registro de lluvia");
    }

    // seasonLiters -> GET: /api/Rain/season/{seasonId}/liters
    [HttpGet("season/{seasonId}/liters")]
    public async Task<IActionResult> SeasonLiters(int seasonId)
    {
        var seasonExists = await _context.Seasons.AnyAsync(s => s.Id == seasonId);
        if (!seasonExists)
        {
            return NotFound(new { errors = new[] { "No se ha encontrado ninguna temporada con ese ID" } });
        }

        // Get the total liters for a specific season
        var totalLiters = await _context.RainLogs
            .Where(r => r.SeasonId == seasonId)
            .SumAsync(r => r.Liters);

        return Ok(new { liters = totalLiters });
    }
}