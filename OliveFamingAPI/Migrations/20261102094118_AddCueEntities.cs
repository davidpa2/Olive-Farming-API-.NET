using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OliveFamingAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCueEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceCode = table.Column<int>(type: "int", nullable: false),
                    MunicipalityCode = table.Column<int>(type: "int", nullable: false),
                    Polygon = table.Column<int>(type: "int", nullable: false),
                    Parcel = table.Column<int>(type: "int", nullable: false),
                    Enclosure = table.Column<int>(type: "int", nullable: false),
                    SigpacAreaHa = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    CultivatedAreaHa = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    SigpacUse = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Species = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Variety = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsIrrigated = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhytosanitaryTreatments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlotId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TreatedAreaHa = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    PhytosanitaryProblem = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Dose = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    DoseUnit = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Efficacy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Observations = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ApplicatorId = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhytosanitaryTreatments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhytosanitaryTreatments_Plots_PlotId",
                        column: x => x.PlotId,
                        principalTable: "Plots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhytosanitaryTreatments_PlotId",
                table: "PhytosanitaryTreatments",
                column: "PlotId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhytosanitaryTreatments");

            migrationBuilder.DropTable(
                name: "Plots");
        }
    }
}
