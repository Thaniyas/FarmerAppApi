using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class PartLand_notes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "PartitionLandDetails",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "LandDetails",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "PartitionLandDetails");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "LandDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

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
    }
}
