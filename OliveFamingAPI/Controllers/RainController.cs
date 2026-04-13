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

    // findBySeason -> GET: /api/Rain/season/{seasonName}
    [HttpGet("season/{seasonName}")]
    public async Task<ActionResult<List<RainLog>>> FindBySeason(string seasonName)
    {
        var season = await _context.Seasons.FirstOrDefaultAsync(s => s.Name == seasonName);
        if (season == null)
        {
            return NotFound(new { errors = new[] { "No se ha encontrado ninguna temporada con ese nombre" } });
        }

        // Get rainLogs by seasonId
        var rainLogs = await _context.RainLogs
            .Where(r => r.SeasonId == season.Id)
            .ToListAsync();

        if (!rainLogs.Any())
        {
            return NotFound(new { errors = new[] { "No se ha encontrado ningún registro de lluvias en la temporada " + seasonName } });
        }

        return Ok(rainLogs);
    }

    // newRainLog -> POST: /api/Rain
    [HttpPost]
    public async Task<ActionResult<string>> NewRainLog([FromBody] RainLogCreateDTO newLogDto)
    {
        // Check if season exists
        var season = await _context.Seasons.FirstOrDefaultAsync(s => s.Name == newLogDto.SeasonName);
        if (season == null)
        {
            return BadRequest(new { errors = new[] { "No existe una temporada agrícola con ese nombre" } });
        }

        // Mapping Season object
        var newLog = new RainLog
        {
            Date = newLogDto.Date,
            Liters = newLogDto.Liters,
            SeasonId = season.Id
        };

        // Save rain log
        _context.RainLogs.Add(newLog);
        await _context.SaveChangesAsync();

        return Ok("Se ha introducido un nuevo registro de lluvia");
    }

    // deleteRainLog -> DELETE: /api/Rain/{id}
    [HttpDelete("{id}")]
    public async Task<ActionResult<string>> DeleteRainLog(int id)
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

    // seasonLiters -> GET: /api/Rain/season/{seasonName}/liters
    [HttpGet("season/{seasonName}/liters")]
    public async Task<ActionResult<SeasonLitersDTO>> SeasonLiters(string seasonName)
    {
        var seasonExists = await _context.Seasons.FirstOrDefaultAsync(s => s.Name == seasonName);
        if (seasonExists == null)
        {
            return NotFound(new { errors = new[] { "No se ha encontrado ninguna temporada con ese nombre" } });
        }

        // Get the total liters for a specific season
        var totalLiters = await _context.RainLogs
            .Where(r => r.SeasonId == seasonExists.Id)
            .SumAsync(r => r.Liters);

        return Ok(new SeasonLitersDTO { Liters = totalLiters });
    }
}