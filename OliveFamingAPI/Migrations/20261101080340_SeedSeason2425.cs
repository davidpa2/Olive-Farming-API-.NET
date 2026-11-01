using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OliveFamingAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedSeason2425 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "EndDate", "Name", "StartDate" },
                values: new object[] { 104, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24/25", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "RainLogs",
                columns: new[] { "Id", "Date", "Liters", "SeasonId" },
                values: new object[,]
                {
                    { -5043, new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.0, 104 },
                    { -5042, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 104 },
                    { -5041, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.0, 104 },
                    { -5040, new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.0, 104 },
                    { -5039, new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0, 104 },
                    { -5038, new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, 104 },
                    { -5037, new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.0, 104 },
                    { -5036, new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0, 104 },
                    { -5035, new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, 104 },
                    { -5034, new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, 104 },
                    { -5033, new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 104 },
                    { -5032, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, 104 },
                    { -5031, new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 104 },
                    { -5030, new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.0, 104 },
                    { -5029, new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0, 104 },
                    { -5028, new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 21.0, 104 },
                    { -5027, new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 23.0, 104 },
                    { -5026, new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0, 104 },
                    { -5025, new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 27.0, 104 },
                    { -5024, new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0, 104 },
                    { -5023, new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, 104 },
                    { -5022, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.0, 104 },
                    { -5021, new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.0, 104 },
                    { -5020, new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0, 104 },
                    { -5019, new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0, 104 },
                    { -5018, new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, 104 },
                    { -5017, new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.0, 104 },
                    { -5016, new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 104 },
                    { -5015, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.0, 104 },
                    { -5014, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0, 104 },
                    { -5013, new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 104 },
                    { -5012, new DateTime(2024, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 48.0, 104 },
                    { -5011, new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 104 },
                    { -5010, new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 104 },
                    { -5009, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 23.0, 104 },
                    { -5008, new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, 104 },
                    { -5007, new DateTime(2024, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 104 },
                    { -5006, new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.0, 104 },
                    { -5005, new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 104 },
                    { -5004, new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0, 104 },
                    { -5003, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0, 104 },
                    { -5002, new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.0, 104 },
                    { -5001, new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.0, 104 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5043);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5042);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5041);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5040);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5039);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5038);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5037);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5036);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5035);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5034);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5033);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5032);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5031);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5030);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5029);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5028);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5027);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5026);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5025);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5024);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5023);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5022);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5021);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5020);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5019);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5018);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5017);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5016);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5015);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5014);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5013);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5012);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5011);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5010);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5009);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5008);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5007);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5006);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5005);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5004);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5003);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5002);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -5001);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 104);
        }
    }
}
