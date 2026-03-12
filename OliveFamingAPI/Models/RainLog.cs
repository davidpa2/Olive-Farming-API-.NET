namespace OliveFarmingAPI.Models;

public class RainLog
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public double Liters { get; set; }

    // Foreign key
    public int SeasonId { get; set; }
}