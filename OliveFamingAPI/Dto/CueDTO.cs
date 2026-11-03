namespace OliveFarmingAPI.Dto;

public class PlotDto
{
    public int Id { get; set; }
    public int ProvinceCode { get; set; }
    public int MunicipalityCode { get; set; }
    public int Polygon { get; set; }
    public int Parcel { get; set; }
    public int Enclosure { get; set; }
    public decimal CultivatedAreaHa { get; set; }
    public string Species { get; set; } = string.Empty;
}

public class TreatmentCreateDto
{
    public int PlotId { get; set; }
    public DateTime StartDate { get; set; }
    public decimal TreatedAreaHa { get; set; }
    public string PhytosanitaryProblem { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public string RegistrationNumber { get; set; } = string.Empty;
    public decimal Dose { get; set; }
    public string DoseUnit { get; set; } = "l/ha";
    public string Efficacy { get; set; } = string.Empty;
}