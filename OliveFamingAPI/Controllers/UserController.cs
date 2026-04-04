using Microsoft.AspNetCore.Mvc;
using OliveFarmingAPI.Data;

namespace OliveFarmingAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly FarmingDbContext _context;

    public UsersController(FarmingDbContext context)
    {
        _context = context;
    }
}