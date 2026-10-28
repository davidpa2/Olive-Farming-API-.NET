using Microsoft.AspNetCore.Mvc;

namespace OliveFarmingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Base route /api/Ping
    public class PingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Ping()
        {
            return Ok(new { message = "OliveFarming ping received" });
        }
    }
}
