using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OliveFarmingAPI.Data;

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
}