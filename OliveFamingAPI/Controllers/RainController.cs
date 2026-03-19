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

    // Equivalente a importar la DB. .NET te inyecta la conexión automáticamente.
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

}