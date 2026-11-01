using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OliveFamingAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedSeason2526 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "EndDate", "Name", "StartDate" },
                values: new object[] { 105, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "25/26", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "RainLogs",
                columns: new[] { "Id", "Date", "Liters", "SeasonId" },
                values: new object[,]
                {
                    { -6050, new DateTime(2026, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.0, 105 },
                    { -6049, new DateTime(2026, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.0, 105 },
                    { -6048, new DateTime(2026, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.0, 105 },
                    { -6047, new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, 105 },
                    { -6046, new DateTime(2026, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, 105 },
                    { -6045, new DateTime(2026, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 28.0, 105 },
                    { -6044, new DateTime(2026, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, 105 },
                    { -6043, new DateTime(2026, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.0, 105 },
                    { -6042, new DateTime(2026, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.0, 105 },
                    { -6041, new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.0, 105 },
                    { -6040, new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 105 },
                    { -6039, new DateTime(2026, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 105 },
                    { -6038, new DateTime(2026, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 105 },
                    { -6037, new DateTime(2026, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.0, 105 },
                    { -6036, new DateTime(2026, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 16.0, 105 },
                    { -6035, new DateTime(2026, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 105 },
                    { -6034, new DateTime(2026, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 105 },
                    { -6033, new DateTime(2026, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, 105 },
                    { -6032, new DateTime(2026, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.0, 105 },
                    { -6031, new DateTime(2026, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0, 105 },
                    { -6030, new DateTime(2026, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 26.0, 105 },
                    { -6029, new DateTime(2026, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.0, 105 },
                    { -6028, new DateTime(2026, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, 105 },
                    { -6027, new DateTime(2026, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.0, 105 },
                    { -6026, new DateTime(2026, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.0, 105 },
                    { -6025, new DateTime(2026, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.0, 105 },
                    { -6024, new DateTime(2026, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, 105 },
                    { -6023, new DateTime(2026, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0, 105 },
                    { -6022, new DateTime(2026, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.0, 105 },
                    { -6021, new DateTime(2026, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.0, 105 },
                    { -6020, new DateTime(2026, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.0, 105 },
                    { -6019, new DateTime(2025, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, 105 },
                    { -6018, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.0, 105 },
                    { -6017, new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.0, 105 },
                    { -6016, new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 21.0, 105 },
                    { -6015, new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.0, 105 },
                    { -6014, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 105 },
                    { -6013, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0, 105 },
                    { -6012, new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.0, 105 },
                    { -6011, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0, 105 },
                    { -6010, new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.0, 105 },
                    { -6009, new DateTime(2025, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.0, 105 },
                    { -6008, new DateTime(2025, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 21.0, 105 },
                    { -6007, new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.0, 105 },
                    { -6006, new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 105 },
                    { -6005, new DateTime(2025, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, 105 },
                    { -6004, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 105 },
                    { -6003, new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 105 },
                    { -6002, new DateTime(2025, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0, 105 },
                    { -6001, new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0, 105 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6050);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6049);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6048);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6047);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6046);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6045);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6044);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6043);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6042);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6041);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6040);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6039);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6038);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6037);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6036);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6035);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6034);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6033);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6032);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6031);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6030);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6029);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6028);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6027);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6026);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6025);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6024);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6023);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6022);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6021);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6020);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6019);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6018);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6017);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6016);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6015);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6014);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6013);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6012);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6011);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6010);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6009);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6008);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6007);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6006);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6005);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6004);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6003);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6002);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -6001);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 105);
        }
    }
}
