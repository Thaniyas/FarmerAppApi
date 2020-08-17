using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class notes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "WeedRemove",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Seedings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Sales",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Plowings",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "PestControls",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Harvestings",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 515, DateTimeKind.Utc).AddTicks(7400), new DateTime(2020, 8, 10, 6, 14, 22, 515, DateTimeKind.Utc).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 515, DateTimeKind.Utc).AddTicks(9433), new DateTime(2020, 8, 10, 6, 14, 22, 515, DateTimeKind.Utc).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(97), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(716), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8040), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8737), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8744), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8745), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8746), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8746), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8747), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8748), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8749), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8749), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8750), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8751), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8752), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8752), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8753), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8754), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8755), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8755), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8756), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8757), new DateTime(2020, 8, 10, 6, 14, 22, 516, DateTimeKind.Utc).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 515, DateTimeKind.Utc).AddTicks(1464), new DateTime(2020, 8, 10, 6, 14, 22, 515, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 515, DateTimeKind.Utc).AddTicks(2729), new DateTime(2020, 8, 10, 6, 14, 22, 515, DateTimeKind.Utc).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 515, DateTimeKind.Utc).AddTicks(3942), new DateTime(2020, 8, 10, 6, 14, 22, 515, DateTimeKind.Utc).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 515, DateTimeKind.Utc).AddTicks(4597), new DateTime(2020, 8, 10, 6, 14, 22, 515, DateTimeKind.Utc).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 14, 22, 515, DateTimeKind.Utc).AddTicks(5154), new DateTime(2020, 8, 10, 6, 14, 22, 515, DateTimeKind.Utc).AddTicks(5155) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "WeedRemove");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Seedings");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Plowings");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "PestControls");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Harvestings");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 872, DateTimeKind.Utc).AddTicks(6338), new DateTime(2020, 8, 10, 6, 11, 58, 872, DateTimeKind.Utc).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 872, DateTimeKind.Utc).AddTicks(8413), new DateTime(2020, 8, 10, 6, 11, 58, 872, DateTimeKind.Utc).AddTicks(8413) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 872, DateTimeKind.Utc).AddTicks(9084), new DateTime(2020, 8, 10, 6, 11, 58, 872, DateTimeKind.Utc).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 872, DateTimeKind.Utc).AddTicks(9664), new DateTime(2020, 8, 10, 6, 11, 58, 872, DateTimeKind.Utc).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(8346), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9173), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9180), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9181), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9181), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9182), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9183), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9184), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9184), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9185), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9186), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9187), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9187), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9188), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9190), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9190), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9191), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9192), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9193), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9193) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9193), new DateTime(2020, 8, 10, 6, 11, 58, 873, DateTimeKind.Utc).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 872, DateTimeKind.Utc).AddTicks(653), new DateTime(2020, 8, 10, 6, 11, 58, 872, DateTimeKind.Utc).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 872, DateTimeKind.Utc).AddTicks(1783), new DateTime(2020, 8, 10, 6, 11, 58, 872, DateTimeKind.Utc).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 872, DateTimeKind.Utc).AddTicks(2982), new DateTime(2020, 8, 10, 6, 11, 58, 872, DateTimeKind.Utc).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 872, DateTimeKind.Utc).AddTicks(3610), new DateTime(2020, 8, 10, 6, 11, 58, 872, DateTimeKind.Utc).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 8, 10, 6, 11, 58, 872, DateTimeKind.Utc).AddTicks(4174), new DateTime(2020, 8, 10, 6, 11, 58, 872, DateTimeKind.Utc).AddTicks(4174) });
        }
    }
}
