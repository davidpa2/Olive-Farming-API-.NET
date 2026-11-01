using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OliveFamingAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedSeason2122 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "EndDate", "Name", "StartDate" },
                values: new object[] { 101, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "21/22", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "RainLogs",
                columns: new[] { "Id", "Date", "Liters", "SeasonId" },
                values: new object[,]
                {
                    { -2020, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.0, 101 },
                    { -2019, new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0, 101 },
                    { -2018, new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.0, 101 },
                    { -2017, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0, 101 },
                    { -2016, new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.0, 101 },
                    { -2015, new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0, 101 },
                    { -2014, new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 23.0, 101 },
                    { -2013, new DateTime(2022, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 101 },
                    { -2012, new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.0, 101 },
                    { -2011, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.0, 101 },
                    { -2010, new DateTime(2022, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.0, 101 },
                    { -2009, new DateTime(2022, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.0, 101 },
                    { -2008, new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.0, 101 },
                    { -2007, new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0, 101 },
                    { -2006, new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 48.0, 101 },
                    { -2005, new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 101 },
                    { -2004, new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0, 101 },
                    { -2003, new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 101 },
                    { -2002, new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 101 },
                    { -2001, new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0, 101 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2020);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2019);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2018);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2017);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2016);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2015);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2014);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2013);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2012);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2011);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2010);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2009);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2008);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2007);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2006);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2005);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2004);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2003);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2002);

            migrationBuilder.DeleteData(
                table: "RainLogs",
                keyColumn: "Id",
                keyValue: -2001);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 101);
        }
    }
}
