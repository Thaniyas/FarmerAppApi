using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class areasizechangetoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "AreaSize",
                table: "PartitionLandDetails",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 75);

            migrationBuilder.AlterColumn<decimal>(
                name: "AreaSize",
                table: "LandDetails",
                nullable: false,
                oldClrType: typeof(int));

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
    }
}
