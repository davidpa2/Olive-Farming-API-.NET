using Microsoft.EntityFrameworkCore;
using OliveFarmingAPI.Models;

namespace OliveFarmingAPI.Data;

public class FarmingDbContext: DbContext
{
    // Constructor
    public FarmingDbContext(DbContextOptions<FarmingDbContext> options) : base(options)
    {
    }

    // Tables at database
    public DbSet<Season> Seasons { get; set; }
    public DbSet<RainLog> RainLogs { get; set; }
    public DbSet<User> Users { get; set; }
}