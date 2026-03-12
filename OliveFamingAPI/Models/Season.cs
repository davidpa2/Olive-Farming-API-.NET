namespace OliveFarmingAPI.Models;

public class Season
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    // Propiedad de navegación
    public List<RainLog> RainLogs { get; set; } = new();
}