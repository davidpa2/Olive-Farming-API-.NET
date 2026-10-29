using Microsoft.AspNetCore.Mvc;
using OliveFarmingAPI.Data;

namespace OliveFarmingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Base route /api/Ping
    public class PingController : ControllerBase
    {
        private readonly FarmingDbContext _context;

        public PingController(FarmingDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Ping()
        {
            // Make a simple request to database
            bool isDbAwake = await _context.Database.CanConnectAsync();
            
            return Ok(new 
            { 
                message = "OliveFarming ping received",
                databaseAwake = isDbAwake
            });
        }
    }
}
