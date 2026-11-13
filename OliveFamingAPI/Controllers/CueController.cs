using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OliveFarmingAPI.Data;
using OliveFarmingAPI.Models;
using OliveFarmingAPI.Dto;
using ClosedXML.Excel;
using System.IO;

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

    [HttpPost("plots", Name = "CreatePlot")]
    public async Task<ActionResult<PlotDto>> CreatePlot(PlotCreateDto dto)
    {
        var plot = new Plot
        {
            ProvinceCode = dto.ProvinceCode,
            MunicipalityCode = dto.MunicipalityCode,
            Polygon = dto.Polygon,
            Parcel = dto.Parcel,
            Enclosure = dto.Enclosure,
            SigpacAreaHa = dto.SigpacAreaHa,
            CultivatedAreaHa = dto.CultivatedAreaHa,
            SigpacUse = dto.SigpacUse,
            Species = dto.Species,
            Variety = dto.Variety,
            IsIrrigated = dto.IsIrrigated
        };

        _context.Plots.Add(plot);
        await _context.SaveChangesAsync();

        var plotDto = new PlotDto
        {
            Id = plot.Id,
            ProvinceCode = plot.ProvinceCode,
            MunicipalityCode = plot.MunicipalityCode,
            Polygon = plot.Polygon,
            Parcel = plot.Parcel,
            Enclosure = plot.Enclosure,
            CultivatedAreaHa = plot.CultivatedAreaHa,
            Species = plot.Species
        };

        return Ok(plotDto);
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
    public async Task<ActionResult<IEnumerable<TreatmentDto>>> CreateTreatment(TreatmentCreateDto dto)
    {
        if (dto.StartDate > DateTime.Now)
            return BadRequest("La fecha del tratamiento no puede ser futura.");

        if (!dto.PlotIds.Any())
            return BadRequest("Debes seleccionar al menos una parcela.");

        // Look for all the selected plots
        var plots = await _context.Plots
            .Where(p => dto.PlotIds.Contains(p.Id))
            .ToListAsync();

        if (plots.Count != dto.PlotIds.Count)
            return NotFound("Alguna de las parcelas indicadas no existe.");

        var entities = new List<PhytosanitaryTreatment>();

        foreach (var plot in plots)
        {
            entities.Add(new PhytosanitaryTreatment
            {
                PlotId = plot.Id,
                StartDate = dto.StartDate,
                // Using plot CultivatedAreaHa
                TreatedAreaHa = plot.CultivatedAreaHa,
                PhytosanitaryProblem = dto.PhytosanitaryProblem,
                ProductName = dto.ProductName,
                RegistrationNumber = dto.RegistrationNumber,
                Dose = dto.Dose,
                DoseUnit = dto.DoseUnit,
                Efficacy = dto.Efficacy
            });
        }

        _context.PhytosanitaryTreatments.AddRange(entities);
        await _context.SaveChangesAsync();

        // Map the saved entities to return them
        var createdDtos = entities.Select(e => new TreatmentDto
        {
            Id = e.Id,
            PlotId = e.PlotId,
            StartDate = e.StartDate,
            TreatedAreaHa = e.TreatedAreaHa,
            PhytosanitaryProblem = e.PhytosanitaryProblem,
            ProductName = e.ProductName,
            RegistrationNumber = e.RegistrationNumber,
            Dose = e.Dose,
            DoseUnit = e.DoseUnit,
            Efficacy = e.Efficacy
        }).ToList();

        return Ok(createdDtos);
    }

    [HttpPut("treatments/{id}", Name = "UpdateTreatment")]
    public async Task<ActionResult<TreatmentDto>> UpdateTreatment(int id, TreatmentUpdateDto dto)
    {
        var treatment = await _context.PhytosanitaryTreatments.FindAsync(id);
        if (treatment == null) return NotFound("El tratamiento no existe.");

        var plot = await _context.Plots.FindAsync(dto.PlotId);
        if (plot == null) return NotFound("La parcela indicada no existe.");

        treatment.PlotId = dto.PlotId;
        treatment.StartDate = dto.StartDate;
        treatment.TreatedAreaHa = plot.CultivatedAreaHa;
        treatment.PhytosanitaryProblem = dto.PhytosanitaryProblem;
        treatment.ProductName = dto.ProductName;
        treatment.RegistrationNumber = dto.RegistrationNumber;
        treatment.Dose = dto.Dose;
        treatment.DoseUnit = dto.DoseUnit;
        treatment.Efficacy = dto.Efficacy;

        await _context.SaveChangesAsync();

        var updatedDto = new TreatmentDto
        {
            Id = treatment.Id,
            PlotId = treatment.PlotId,
            StartDate = treatment.StartDate,
            TreatedAreaHa = treatment.TreatedAreaHa,
            PhytosanitaryProblem = treatment.PhytosanitaryProblem,
            ProductName = treatment.ProductName,
            RegistrationNumber = treatment.RegistrationNumber,
            Dose = treatment.Dose,
            DoseUnit = treatment.DoseUnit,
            Efficacy = treatment.Efficacy
        };

        return Ok(updatedDto);
    }

    [HttpDelete("treatments/{id}", Name = "DeleteTreatment")]
    public async Task<ActionResult> DeleteTreatment(int id)
    {
        var treatment = await _context.PhytosanitaryTreatments.FindAsync(id);
        if (treatment == null)
            return NotFound("El tratamiento indicado no existe.");

        _context.PhytosanitaryTreatments.Remove(treatment);
        await _context.SaveChangesAsync();

        return NoContent(); // Returna 204 no content
    }

    [HttpGet("export/{year}/{month}", Name = "ExportTreatments")]
    public async Task<IActionResult> ExportTreatments(int year, int month)
    {
        // Look for the treatments including plot data
        var treatments = await _context.PhytosanitaryTreatments
            .Include(t => t.Plot)
            .Where(t => t.StartDate.Year == year && t.StartDate.Month == month)
            .OrderBy(t => t.StartDate)
            .ToListAsync();

        if (!treatments.Any())
            return NotFound("No hay tratamientos registrados en este mes.");

        // Create Excel book
        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add($"CUE_{month:D2}_{year}");

        // Headers (based in SGA-CEX fields)
        var headers = new string[] {
            "Fecha de Aplicación", "Provincia", "Municipio", "Polígono",
            "Parcela", "Recinto", "Superficie Tratada (ha)", "Problema Fitosanitario",
            "Producto Comercial", "Nº Registro MITECO", "Dosis", "Unidad Dosis", "Eficacia"
        };

        for (int i = 0; i < headers.Length; i++)
        {
            var cell = worksheet.Cell(1, i + 1);
            cell.Value = headers[i];
            cell.Style.Font.Bold = true;
            cell.Style.Fill.BackgroundColor = XLColor.LightGreen;
            cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
        }

        // Fill rows with real data
        var row = 2;
        foreach (var t in treatments)
        {
            worksheet.Cell(row, 1).Value = t.StartDate.ToString("dd/MM/yyyy");

            if (t.Plot != null)
            {
                worksheet.Cell(row, 2).Value = t.Plot.ProvinceCode;
                worksheet.Cell(row, 3).Value = t.Plot.MunicipalityCode;
                worksheet.Cell(row, 4).Value = t.Plot.Polygon;
                worksheet.Cell(row, 5).Value = t.Plot.Parcel;
                worksheet.Cell(row, 6).Value = t.Plot.Enclosure;
            }
            worksheet.Cell(row, 7).Value = t.TreatedAreaHa;
            worksheet.Cell(row, 8).Value = t.PhytosanitaryProblem;
            worksheet.Cell(row, 9).Value = t.ProductName;
            worksheet.Cell(row, 10).Value = t.RegistrationNumber;
            worksheet.Cell(row, 11).Value = t.Dose;
            worksheet.Cell(row, 12).Value = t.DoseUnit;
            worksheet.Cell(row, 13).Value = t.Efficacy;
            row++;
        }

        // Adjust colum widths
        worksheet.Columns().AdjustToContents();

        // Return binary string
        using var stream = new MemoryStream();
        workbook.SaveAs(stream);
        var content = stream.ToArray();
        var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        var fileName = $"Cuaderno_Campo_{year}_{month:D2}.xlsx";

        return File(content, contentType, fileName);
    }
}