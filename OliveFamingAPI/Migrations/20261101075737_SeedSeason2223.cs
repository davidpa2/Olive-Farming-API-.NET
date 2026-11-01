using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OliveFamingAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedSeason2223 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "EndDate", "Name", "StartDate" },
                values: new object[] { 102, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "22/23", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "RainLogs",
                columns: new[] { "Id", "Date", "Liters", "SeasonId" },
                values: new object[,]
                {
                    { -3025, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0, 102 },
                    { -3024, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, 102 },
                    { -3023, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 102 },
                    { -3022, new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, 102 },
                    { -3021, new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0, 102 },
                    { -3020, new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, 102 },
                    { -3019, new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.0, 102 },
                    { -3018, new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 102 },
                    { -3017, new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 102 },
                    { -3016, new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, 102 },
                    { -3015, new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0, 102 },
                    { -3014, new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 102 },
                    { -3013, new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.0, 102 },
                    { -3012, new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0, 102 },
                    { -3011, new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 23.0, 102 },
                    { -3010, new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, 102 },
                    { -3009, new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 27.0, 102 },
                    { -3008, new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.0, 102 },
                    { -3007, new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.0, 102 },
                    { -3006, new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0, 102 },
                    { -3005, new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.0, 102 },
                    { -3004, new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0, 102 },
                    { -3003, new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 102 },
                    { -3002, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0, 102 },
                    { -3001, new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 102 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3025);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3024);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3023);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3022);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3021);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3020);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3019);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3018);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3017);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3016);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3015);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3014);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3013);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3012);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3011);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3010);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3009);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3008);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3007);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3006);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3005);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3004);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3003);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3002);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -3001);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 102);
        }
    }
}
