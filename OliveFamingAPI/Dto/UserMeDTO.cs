namespace OliveFarmingAPI.DTOs;

public class UserMeDTO
{
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public required string Email { get; set; }

    public string? ApplicatorName { get; set; }
    public string? ApplicatorNif { get; set; }
    public string? RopoNumber { get; set; }
    public string? EquipmentRoma { get; set; }
    public DateTime? LastIteafDate { get; set; }

    public string? ReafaNumber { get; set; } // REAFA inscription number 
    public string? HolderName { get; set; }  // Name of the holding holder
    public string? HolderNif { get; set; }   // Holder NIF
}

public class UserCueProfileUpdateDTO
{
    public string? ApplicatorName { get; set; }
    public string? ApplicatorNif { get; set; }
    public string? RopoNumber { get; set; }
    public string? EquipmentRoma { get; set; }
    public DateTime? LastIteafDate { get; set; }

    public string? ReafaNumber { get; set; } // REAFA inscription number 
    public string? HolderName { get; set; }  // Name of the holding holder
    public string? HolderNif { get; set; }   // Holder NIF
}