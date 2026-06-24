namespace OliveFarmingAPI.DTOs;

// Fíjate que solo pedimos lo estrictamente necesario para crear una temporada
public class EditRainLogDTO
{
    public DateTime Date { get; set; }
    public double Liters { get; set; }
    public required string SeasonName { get; set; }
}