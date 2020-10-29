using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class changeintegertonumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NoOfLabours",
                table: "WeedRemove",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "LabourCost",
                table: "WeedRemove",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<float>(
                name: "Cost",
                table: "WeedRemove",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "SeedCost",
                table: "Seedings",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Seedings",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NoOfLabours",
                table: "Seedings",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "LabourCost",
                table: "Seedings",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Sales",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Sales",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "PlowingExp",
                table: "Plowings",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "LabourCost",
                table: "PestControls",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Cost",
                table: "PestControls",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "AreaSize",
                table: "PartitionLandDetails",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 75);

            migrationBuilder.AlterColumn<int>(
                name: "SurveyNumber",
                table: "LandDetails",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PattaNumber",
                table: "LandDetails",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "AreaSize",
                table: "LandDetails",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "NoOfLabours",
                table: "Harvestings",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "LabourCost",
                table: "Harvestings",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<float>(
                name: "Cost",
                table: "Harvestings",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 298, DateTimeKind.Utc).AddTicks(2123), new DateTime(2020, 10, 7, 5, 54, 25, 298, DateTimeKind.Utc).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 298, DateTimeKind.Utc).AddTicks(4172), new DateTime(2020, 10, 7, 5, 54, 25, 298, DateTimeKind.Utc).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 298, DateTimeKind.Utc).AddTicks(4865), new DateTime(2020, 10, 7, 5, 54, 25, 298, DateTimeKind.Utc).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 298, DateTimeKind.Utc).AddTicks(5469), new DateTime(2020, 10, 7, 5, 54, 25, 298, DateTimeKind.Utc).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(2724), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3396), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3403), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3403), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3405), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3406), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3406), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3408), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3409), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3409), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3410), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3411), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3412), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3414), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3414), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3415), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3416), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3417), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3417), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3418), new DateTime(2020, 10, 7, 5, 54, 25, 299, DateTimeKind.Utc).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 297, DateTimeKind.Utc).AddTicks(6198), new DateTime(2020, 10, 7, 5, 54, 25, 297, DateTimeKind.Utc).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 297, DateTimeKind.Utc).AddTicks(7492), new DateTime(2020, 10, 7, 5, 54, 25, 297, DateTimeKind.Utc).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 297, DateTimeKind.Utc).AddTicks(8708), new DateTime(2020, 10, 7, 5, 54, 25, 297, DateTimeKind.Utc).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 297, DateTimeKind.Utc).AddTicks(9387), new DateTime(2020, 10, 7, 5, 54, 25, 297, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 5, 54, 25, 298, DateTimeKind.Utc).AddTicks(4), new DateTime(2020, 10, 7, 5, 54, 25, 298, DateTimeKind.Utc).AddTicks(4) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NoOfLabours",
                table: "WeedRemove",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "LabourCost",
                table: "WeedRemove",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "Cost",
                table: "WeedRemove",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(float),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SeedCost",
                table: "Seedings",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "Quantity",
                table: "Seedings",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "NoOfLabours",
                table: "Seedings",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "LabourCost",
                table: "Seedings",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "Quantity",
                table: "Sales",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Sales",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(float),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PlowingExp",
                table: "Plowings",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(float),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LabourCost",
                table: "PestControls",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(float),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Cost",
                table: "PestControls",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(float),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "AreaSize",
                table: "PartitionLandDetails",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(float),
                oldMaxLength: 75);

            migrationBuilder.AlterColumn<string>(
                name: "SurveyNumber",
                table: "LandDetails",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PattaNumber",
                table: "LandDetails",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "AreaSize",
                table: "LandDetails",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "NoOfLabours",
                table: "Harvestings",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "LabourCost",
                table: "Harvestings",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "Cost",
                table: "Harvestings",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(float),
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 984, DateTimeKind.Utc).AddTicks(820), new DateTime(2020, 10, 7, 4, 54, 3, 984, DateTimeKind.Utc).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 984, DateTimeKind.Utc).AddTicks(2885), new DateTime(2020, 10, 7, 4, 54, 3, 984, DateTimeKind.Utc).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 984, DateTimeKind.Utc).AddTicks(3591), new DateTime(2020, 10, 7, 4, 54, 3, 984, DateTimeKind.Utc).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 984, DateTimeKind.Utc).AddTicks(4207), new DateTime(2020, 10, 7, 4, 54, 3, 984, DateTimeKind.Utc).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(4567), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5600), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5606), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5607), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5608), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5609), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5610), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5610), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5611), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5612), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5613), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5613), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5614), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5615), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5616), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5617), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5618), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5618), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5619), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5620), new DateTime(2020, 10, 7, 4, 54, 3, 985, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 983, DateTimeKind.Utc).AddTicks(4967), new DateTime(2020, 10, 7, 4, 54, 3, 983, DateTimeKind.Utc).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 983, DateTimeKind.Utc).AddTicks(6260), new DateTime(2020, 10, 7, 4, 54, 3, 983, DateTimeKind.Utc).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 983, DateTimeKind.Utc).AddTicks(7493), new DateTime(2020, 10, 7, 4, 54, 3, 983, DateTimeKind.Utc).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 983, DateTimeKind.Utc).AddTicks(8109), new DateTime(2020, 10, 7, 4, 54, 3, 983, DateTimeKind.Utc).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 7, 4, 54, 3, 983, DateTimeKind.Utc).AddTicks(8684), new DateTime(2020, 10, 7, 4, 54, 3, 983, DateTimeKind.Utc).AddTicks(8685) });
        }
    }
}
