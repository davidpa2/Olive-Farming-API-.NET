namespace OliveFarmingAPI.DTOs;

// Fíjate que solo pedimos lo estrictamente necesario para crear una temporada
public class LoginDTO
{
    public required string Jwt { get; set; }
}