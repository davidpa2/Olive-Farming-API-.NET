namespace OliveFarmingAPI.DTOs;

public class EditRainLogDTO
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public double Liters { get; set; }
    public required string SeasonName { get; set; }
}