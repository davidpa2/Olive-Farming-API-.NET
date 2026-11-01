using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OliveFamingAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedSeason2021 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "EndDate", "Name", "StartDate" },
                values: new object[] { 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "20/21", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "RainLogs",
                columns: new[] { "Id", "Date", "Liters", "SeasonId" },
                values: new object[,]
                {
                    { -1026, new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 100 },
                    { -1025, new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.0, 100 },
                    { -1024, new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 30.0, 100 },
                    { -1023, new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.0, 100 },
                    { -1022, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.0, 100 },
                    { -1021, new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.0, 100 },
                    { -1020, new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0, 100 },
                    { -1019, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, 100 },
                    { -1018, new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 43.0, 100 },
                    { -1017, new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0, 100 },
                    { -1016, new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 100 },
                    { -1015, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0, 100 },
                    { -1014, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0, 100 },
                    { -1013, new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.0, 100 },
                    { -1012, new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0, 100 },
                    { -1011, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.5, 100 },
                    { -1010, new DateTime(2020, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.5, 100 },
                    { -1009, new DateTime(2020, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.0, 100 },
                    { -1008, new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.0, 100 },
                    { -1007, new DateTime(2020, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, 100 },
                    { -1006, new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.0, 100 },
                    { -1005, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.0, 100 },
                    { -1004, new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.0, 100 },
                    { -1003, new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5, 100 },
                    { -1002, new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.0, 100 },
                    { -1001, new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.0, 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1026);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1025);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1024);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1023);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1022);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1021);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1020);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1019);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1018);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1017);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1016);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1015);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1014);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1013);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1012);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1011);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1010);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1009);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1008);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1007);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1006);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1005);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1004);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1003);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1002);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -1001);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
