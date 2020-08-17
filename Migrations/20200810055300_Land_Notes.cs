using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class Land_Notes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "LandDetails",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 21, DateTimeKind.Utc).AddTicks(5526), new DateTime(2020, 8, 10, 5, 53, 0, 21, DateTimeKind.Utc).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 21, DateTimeKind.Utc).AddTicks(7864), new DateTime(2020, 8, 10, 5, 53, 0, 21, DateTimeKind.Utc).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 21, DateTimeKind.Utc).AddTicks(8595), new DateTime(2020, 8, 10, 5, 53, 0, 21, DateTimeKind.Utc).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 21, DateTimeKind.Utc).AddTicks(9207), new DateTime(2020, 8, 10, 5, 53, 0, 21, DateTimeKind.Utc).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7027), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7762), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7769), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7770), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7771), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7772), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7773), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7774), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7774), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7775), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7776), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7777), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7778), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7778), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7779), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7780), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7781), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7781), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7782), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7783), new DateTime(2020, 8, 10, 5, 53, 0, 22, DateTimeKind.Utc).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 20, DateTimeKind.Utc).AddTicks(8890), new DateTime(2020, 8, 10, 5, 53, 0, 20, DateTimeKind.Utc).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 21, DateTimeKind.Utc).AddTicks(329), new DateTime(2020, 8, 10, 5, 53, 0, 21, DateTimeKind.Utc).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 21, DateTimeKind.Utc).AddTicks(1598), new DateTime(2020, 8, 10, 5, 53, 0, 21, DateTimeKind.Utc).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 21, DateTimeKind.Utc).AddTicks(2233), new DateTime(2020, 8, 10, 5, 53, 0, 21, DateTimeKind.Utc).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 5, 53, 0, 21, DateTimeKind.Utc).AddTicks(2833), new DateTime(2020, 8, 10, 5, 53, 0, 21, DateTimeKind.Utc).AddTicks(2833) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "LandDetails");

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
    }
}
