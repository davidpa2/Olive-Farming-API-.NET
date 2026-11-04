using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OliveFarmingAPI.Data;
using OliveFarmingAPI.Models;
using OliveFarmingAPI.Dto;

namespace OliveFarmingAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CueController : ControllerBase
{
    private readonly FarmingDbContext _context;

    public CueController(FarmingDbContext context)
    {
        _context = context;
    }

    [HttpGet("plots", Name = "GetPlots")]
    public async Task<ActionResult<IEnumerable<PlotDto>>> GetPlots()
    {
        var plots = await _context.Plots
            .Select(p => new PlotDto
            {
                Id = p.Id,
                ProvinceCode = p.ProvinceCode,
                MunicipalityCode = p.MunicipalityCode,
                Polygon = p.Polygon,
                Parcel = p.Parcel,
                Enclosure = p.Enclosure,
                CultivatedAreaHa = p.CultivatedAreaHa,
                Species = p.Species
            }).ToListAsync();

        return Ok(plots);
    }

    [HttpGet("treatments", Name = "GetTreatments")]
    public async Task<ActionResult<IEnumerable<TreatmentDto>>> GetTreatments()
    {
        var treatments = await _context.PhytosanitaryTreatments
            .Select(t => new TreatmentDto
            {
                Id = t.Id,
                PlotId = t.PlotId,
                StartDate = t.StartDate,
                TreatedAreaHa = t.TreatedAreaHa,
                PhytosanitaryProblem = t.PhytosanitaryProblem,
                ProductName = t.ProductName,
                RegistrationNumber = t.RegistrationNumber,
                Dose = t.Dose,
                DoseUnit = t.DoseUnit,
                Efficacy = t.Efficacy
            })
            .ToListAsync();

        return Ok(treatments);
    }

    [HttpPost("treatments", Name = "CreateTreatment")]
    public async Task<ActionResult> CreateTreatment(TreatmentCreateDto dto)
    {
        if (dto.StartDate > DateTime.Now)
            return BadRequest("La fecha del tratamiento no puede ser futura.");

        if (string.IsNullOrWhiteSpace(dto.RegistrationNumber))
            return BadRequest("El número de registro del producto es obligatorio.");

        var plotExists = await _context.Plots.AnyAsync(p => p.Id == dto.PlotId);
        if (!plotExists)
            return NotFound("La parcela indicada no existe.");

        var treatment = new PhytosanitaryTreatment
        {
            PlotId = dto.PlotId,
            StartDate = dto.StartDate,
            TreatedAreaHa = dto.TreatedAreaHa,
            PhytosanitaryProblem = dto.PhytosanitaryProblem,
            ProductName = dto.ProductName,
            RegistrationNumber = dto.RegistrationNumber,
            Dose = dto.Dose,
            DoseUnit = dto.DoseUnit,
            Efficacy = dto.Efficacy
        };

        _context.PhytosanitaryTreatments.Add(treatment);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetPlots), new { id = treatment.Id }, treatment);
    }
}