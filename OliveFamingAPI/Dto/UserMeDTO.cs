namespace OliveFarmingAPI.DTOs;

// Fíjate que solo pedimos lo estrictamente necesario para crear una temporada
public class UserMeDTO
{
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public required string Email { get; set; }
}