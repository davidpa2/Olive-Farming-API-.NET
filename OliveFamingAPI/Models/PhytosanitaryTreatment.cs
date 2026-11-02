using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OliveFarmingAPI.Models
{
    public class PhytosanitaryTreatment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Plot))]
        public int PlotId { get; set; }
        public Plot Plot { get; set; } = null!;

        // Application
        public DateTime StartDate { get; set; } 
        public DateTime? EndDate { get; set; } 
        
        [Column(TypeName = "decimal(10,4)")]
        public decimal TreatedAreaHa { get; set; } 
        
        [MaxLength(200)]
        public string PhytosanitaryProblem { get; set; } = string.Empty; 

        // Plant protection product
        [MaxLength(200)]
        public string ProductName { get; set; } = string.Empty; 
        [MaxLength(50)]
        public string RegistrationNumber { get; set; } = string.Empty; 
        
        [Column(TypeName = "decimal(10,4)")]
        public decimal Dose { get; set; } 
        [MaxLength(10)]
        public string DoseUnit { get; set; } = "l/ha"; // "kg/ha" o "l/ha"

        // Reluts and application
        [MaxLength(20)]
        public string Efficacy { get; set; } = string.Empty; // "Buena", "Regular", "Mala"
        [MaxLength(500)]
        public string? Observations { get; set; } 

        public int ApplicatorId { get; set; } 
        public int EquipmentId { get; set; } 
    }
}