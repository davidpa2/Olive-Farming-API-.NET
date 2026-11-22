namespace OliveFarmingAPI.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty; // Hashed password

    public string? ApplicatorName { get; set; }
    public string? RopoNumber { get; set; }
    public string? ApplicatorNif { get; set; }
    public string? EquipmentRoma { get; set; }
    public DateTime? LastIteafDate { get; set; }

    public string? ReafaNumber { get; set; } // REAFA inscription number 
    public string? HolderName { get; set; }  // Name of the holding holder
    public string? HolderNif { get; set; }   // Holder NIF
}