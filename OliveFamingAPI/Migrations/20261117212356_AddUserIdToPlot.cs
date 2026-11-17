using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OliveFamingAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdToPlot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Plots",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Plots_UserId",
                table: "Plots",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Plots_Users_UserId",
                table: "Plots",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plots_Users_UserId",
                table: "Plots");

            migrationBuilder.DropIndex(
                name: "IX_Plots_UserId",
                table: "Plots");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Plots");
        }
    }
}
