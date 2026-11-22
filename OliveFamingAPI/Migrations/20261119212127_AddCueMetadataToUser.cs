using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OliveFamingAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCueMetadataToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicatorName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicatorNif",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquipmentRoma",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastIteafDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RopoNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicatorName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ApplicatorNif",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EquipmentRoma",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastIteafDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RopoNumber",
                table: "Users");
        }
    }
}
