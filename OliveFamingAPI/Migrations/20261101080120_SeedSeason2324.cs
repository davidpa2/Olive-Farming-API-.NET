using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OliveFamingAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedSeason2324 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "EndDate", "Name", "StartDate" },
                values: new object[] { 103, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "23/24", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "RainLogs",
                columns: new[] { "Id", "Date", "Liters", "SeasonId" },
                values: new object[,]
                {
                    { -4044, new DateTime(2024, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.0, 103 },
                    { -4043, new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0, 103 },
                    { -4042, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.0, 103 },
                    { -4041, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 103 },
                    { -4040, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.0, 103 },
                    { -4039, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 103 },
                    { -4038, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.0, 103 },
                    { -4037, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 21.0, 103 },
                    { -4036, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.0, 103 },
                    { -4035, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 28.0, 103 },
                    { -4034, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, 103 },
                    { -4033, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0, 103 },
                    { -4032, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0, 103 },
                    { -4031, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0, 103 },
                    { -4030, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 24.0, 103 },
                    { -4029, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.0, 103 },
                    { -4028, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, 103 },
                    { -4027, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.0, 103 },
                    { -4026, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0, 103 },
                    { -4025, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.0, 103 },
                    { -4024, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0, 103 },
                    { -4023, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.0, 103 },
                    { -4022, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 103 },
                    { -4021, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.0, 103 },
                    { -4020, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0, 103 },
                    { -4019, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, 103 },
                    { -4018, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 103 },
                    { -4017, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 103 },
                    { -4016, new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 16.0, 103 },
                    { -4015, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.0, 103 },
                    { -4014, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.0, 103 },
                    { -4013, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0, 103 },
                    { -4012, new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0, 103 },
                    { -4011, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0, 103 },
                    { -4010, new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 103 },
                    { -4009, new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 103 },
                    { -4008, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, 103 },
                    { -4007, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, 103 },
                    { -4006, new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 103 },
                    { -4005, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 103 },
                    { -4004, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 103 },
                    { -4003, new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.0, 103 },
                    { -4002, new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 103 },
                    { -4001, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 30.0, 103 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4044);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4043);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4042);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4041);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4040);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4039);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4038);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4037);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4036);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4035);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4034);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4033);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4032);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4031);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4030);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4029);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4028);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4027);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4026);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4025);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4024);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4023);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4022);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4021);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4020);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4019);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4018);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4017);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4016);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4015);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4014);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4013);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4012);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4011);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4010);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4009);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4008);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4007);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4006);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4005);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4004);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4003);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4002);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -4001);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 103);
        }
    }
}
