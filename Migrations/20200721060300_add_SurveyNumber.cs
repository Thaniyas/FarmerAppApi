using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class add_SurveyNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SurveyNumber",
                table: "LandDetails",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(4047), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(4877), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(5460), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(6014), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8353), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8361), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8362), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8362), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8363), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8363), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8364), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8364), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8365), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8365), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8366), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8366), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8367), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8367), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8368), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8368), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8369), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8369), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8370), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8370), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 206, DateTimeKind.Utc).AddTicks(7966), new DateTime(2020, 7, 21, 6, 3, 0, 206, DateTimeKind.Utc).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 206, DateTimeKind.Utc).AddTicks(9449), new DateTime(2020, 7, 21, 6, 3, 0, 206, DateTimeKind.Utc).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(86), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(660), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(1270), new DateTime(2020, 7, 21, 6, 3, 0, 207, DateTimeKind.Utc).AddTicks(1270) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurveyNumber",
                table: "LandDetails");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(4214), new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(6253), new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(6956), new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(7538), new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5151), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5848), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5854), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5855), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5856), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5857), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5857), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5858), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5859), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5860), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5860), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5861), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5862), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5863), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5863), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5864), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5865), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5866), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5866), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5867), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 28, DateTimeKind.Utc).AddTicks(8008), new DateTime(2020, 5, 28, 9, 40, 25, 28, DateTimeKind.Utc).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 28, DateTimeKind.Utc).AddTicks(9207), new DateTime(2020, 5, 28, 9, 40, 25, 28, DateTimeKind.Utc).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(818), new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(1439), new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(2023), new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(2024) });
        }
    }
}
