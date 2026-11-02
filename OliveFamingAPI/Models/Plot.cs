using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OliveFarmingAPI.Models
{
    public class Plot
    {
        [Key]
        public int Id { get; set; }

        // SIGPAC references
        public int ProvinceCode { get; set; } 
        public int MunicipalityCode { get; set; } 
        public int Polygon { get; set; } 
        public int Parcel { get; set; } 
        public int Enclosure { get; set; } 

        // Surfaces
        [Column(TypeName = "decimal(10,4)")]
        public decimal SigpacAreaHa { get; set; } 
        [Column(TypeName = "decimal(10,4)")]
        public decimal CultivatedAreaHa { get; set; } 

        // Agronomic data
        [MaxLength(10)]
        public string SigpacUse { get; set; } = string.Empty;
        [MaxLength(100)]
        public string Species { get; set; } = string.Empty; 
        [MaxLength(100)]
        public string Variety { get; set; } = string.Empty; 
        public bool IsIrrigated { get; set; } 

        // Relations
        public ICollection<PhytosanitaryTreatment> Treatments { get; set; } = new List<PhytosanitaryTreatment>();
    }
}