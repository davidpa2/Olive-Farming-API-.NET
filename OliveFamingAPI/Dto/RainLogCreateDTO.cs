namespace OliveFarmingAPI.DTOs;

// Fíjate que solo pedimos lo estrictamente necesario para crear una temporada
public class RainLogCreateDTO
{
    public DateTime Date { get; set; }
    public double Liters { get; set; }
    public int SeasonId { get; set; }
}