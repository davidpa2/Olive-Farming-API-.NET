using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OliveFamingAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddHolderAndReafaToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HolderName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HolderNif",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReafaNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HolderName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HolderNif",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ReafaNumber",
                table: "Users");
        }
    }
}
