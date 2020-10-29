using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class areasizechangetodecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "WeedRemove",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Seedings",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Sales",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AreaSize",
                table: "PartitionLandDetails",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 75);

            migrationBuilder.AlterColumn<decimal>(
                name: "AreaSize",
                table: "LandDetails",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Harvestings",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 879, DateTimeKind.Utc).AddTicks(7872), new DateTime(2020, 10, 7, 4, 39, 10, 879, DateTimeKind.Utc).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(66), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(794), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(1438), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(8728), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9426), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9432), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9433), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9434), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9434), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9435), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9436), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9437), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9438), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9438), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9439), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9440), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9441), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9441), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9442), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9443), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9444), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9444), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9445), new DateTime(2020, 10, 7, 4, 39, 10, 880, DateTimeKind.Utc).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 879, DateTimeKind.Utc).AddTicks(1738), new DateTime(2020, 10, 7, 4, 39, 10, 879, DateTimeKind.Utc).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 879, DateTimeKind.Utc).AddTicks(3089), new DateTime(2020, 10, 7, 4, 39, 10, 879, DateTimeKind.Utc).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 879, DateTimeKind.Utc).AddTicks(4358), new DateTime(2020, 10, 7, 4, 39, 10, 879, DateTimeKind.Utc).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 879, DateTimeKind.Utc).AddTicks(5015), new DateTime(2020, 10, 7, 4, 39, 10, 879, DateTimeKind.Utc).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 39, 10, 879, DateTimeKind.Utc).AddTicks(5640), new DateTime(2020, 10, 7, 4, 39, 10, 879, DateTimeKind.Utc).AddTicks(5641) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "WeedRemove",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Seedings",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Sales",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AreaSize",
                table: "PartitionLandDetails",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(decimal),
                oldMaxLength: 75);

            migrationBuilder.AlterColumn<int>(
                name: "AreaSize",
                table: "LandDetails",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Harvestings",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

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
    }
}
