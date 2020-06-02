using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configurations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    ParentID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configurations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StateLists",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StateName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateLists", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 30, nullable: true),
                    LastName = table.Column<string>(maxLength: 30, nullable: true),
                    Password = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    RoleID = table.Column<int>(nullable: false),
                    IsFirstTimeLogin = table.Column<bool>(nullable: false),
                    Source = table.Column<string>(nullable: true),
                    AcceptedTermsAndConditions = table.Column<bool>(nullable: false),
                    ResetPasswordToken = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WebPages",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebPages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GoogleRegisters",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    familyName = table.Column<string>(nullable: true),
                    givenName = table.Column<string>(nullable: true),
                    googleid = table.Column<string>(nullable: true),
                    imageUrl = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    serverAuthCode = table.Column<string>(nullable: true),
                    accessToken = table.Column<string>(nullable: true),
                    idToken = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoogleRegisters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GoogleRegisters_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LandDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 75, nullable: false),
                    StateId = table.Column<int>(nullable: false),
                    Village = table.Column<string>(maxLength: 100, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    PattaNumber = table.Column<string>(maxLength: 50, nullable: true),
                    AreaSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LandDetails_StateLists_StateId",
                        column: x => x.StateId,
                        principalTable: "StateLists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LandDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserActivity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    Activity = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserActivity_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RolePageAccesses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    RolesID = table.Column<int>(nullable: false),
                    PagesID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePageAccesses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RolePageAccesses_WebPages_PagesID",
                        column: x => x.PagesID,
                        principalTable: "WebPages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolePageAccesses_Roles_RolesID",
                        column: x => x.RolesID,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartitionLandDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    LandDirection = table.Column<string>(maxLength: 75, nullable: false),
                    AreaSize = table.Column<string>(maxLength: 75, nullable: false),
                    LandDetailId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartitionLandDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PartitionLandDetails_LandDetails_LandDetailId",
                        column: x => x.LandDetailId,
                        principalTable: "LandDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PartitionLandDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Harvestings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    PartitionLandDetailId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Cost = table.Column<string>(maxLength: 50, nullable: true),
                    NoOfLabours = table.Column<string>(maxLength: 50, nullable: true),
                    LabourCost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harvestings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Harvestings_PartitionLandDetails_PartitionLandDetailId",
                        column: x => x.PartitionLandDetailId,
                        principalTable: "PartitionLandDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Harvestings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PestControls",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    PartitionLandDetailId = table.Column<int>(nullable: false),
                    PestControlDate = table.Column<DateTime>(nullable: false),
                    NameofthePestSide = table.Column<string>(maxLength: 50, nullable: true),
                    Cost = table.Column<string>(maxLength: 50, nullable: true),
                    Purpose = table.Column<string>(maxLength: 50, nullable: true),
                    LabourCost = table.Column<string>(maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PestControls", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PestControls_PartitionLandDetails_PartitionLandDetailId",
                        column: x => x.PartitionLandDetailId,
                        principalTable: "PartitionLandDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PestControls_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Plowings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    PartitionLandDetailId = table.Column<int>(nullable: false),
                    PlowingDate = table.Column<DateTime>(nullable: false),
                    TypeofPlowing = table.Column<string>(maxLength: 50, nullable: true),
                    PlowingExp = table.Column<string>(maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plowings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Plowings_PartitionLandDetails_PartitionLandDetailId",
                        column: x => x.PartitionLandDetailId,
                        principalTable: "PartitionLandDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Plowings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    PartitionLandDetailId = table.Column<int>(nullable: false),
                    SaleDate = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<string>(maxLength: 50, nullable: true),
                    Price = table.Column<string>(maxLength: 50, nullable: true),
                    BuyerName = table.Column<string>(maxLength: 50, nullable: true),
                    BuyerMobileNumber = table.Column<string>(maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sales_PartitionLandDetails_PartitionLandDetailId",
                        column: x => x.PartitionLandDetailId,
                        principalTable: "PartitionLandDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sales_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seedings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    PartitionLandDetailId = table.Column<int>(nullable: false),
                    Quantity = table.Column<string>(maxLength: 50, nullable: true),
                    SeedName = table.Column<string>(maxLength: 50, nullable: true),
                    Date = table.Column<DateTime>(maxLength: 50, nullable: false),
                    SeedCost = table.Column<string>(nullable: true),
                    NoOfLabours = table.Column<string>(maxLength: 50, nullable: true),
                    LabourCost = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seedings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Seedings_PartitionLandDetails_PartitionLandDetailId",
                        column: x => x.PartitionLandDetailId,
                        principalTable: "PartitionLandDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Seedings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WeedRemove",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    PartitionLandDetailId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Cost = table.Column<string>(maxLength: 50, nullable: true),
                    NoOfLabours = table.Column<string>(maxLength: 50, nullable: true),
                    LabourCost = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeedRemove", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WeedRemove_PartitionLandDetails_PartitionLandDetailId",
                        column: x => x.PartitionLandDetailId,
                        principalTable: "PartitionLandDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WeedRemove_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Configurations",
                columns: new[] { "ID", "DateAdded", "DateModified", "Deleted", "Name", "ParentID", "Text", "Type", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(4214), new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(4214), false, "UserID", null, null, "SystemEmailSettings", "vNp/Rg/59Wq/aUZBS0+1LDWmAArWOdzzJByWFcSqj9c=" },
                    { 2, new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(6253), new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(6253), false, "Password", null, null, "SystemEmailSettings", "DR7VkCQllyJBLRHqnhoFLg==" },
                    { 3, new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(6956), new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(6956), false, "SMTPPort", null, null, "SystemEmailSettings", "KfPgC+VOAFLCwNmgAKPmfQ==" },
                    { 4, new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(7538), new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(7538), false, "Host", null, null, "SystemEmailSettings", "+fNJD/SKxu6Pyz64X9mIMQ==" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "Deleted", "Name", "Text" },
                values: new object[,]
                {
                    { 1, false, "Admin", "Admin" },
                    { 2, false, "User", "User" },
                    { 3, false, "SiteAdmin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "StateLists",
                columns: new[] { "ID", "StateName" },
                values: new object[,]
                {
                    { 1, "Tamilnadu" },
                    { 2, "Kerala" },
                    { 3, "Karnataka" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "AcceptedTermsAndConditions", "DateAdded", "DateModified", "Deleted", "Email", "FirstName", "IsFirstTimeLogin", "LastName", "Password", "ResetPasswordToken", "RoleID", "Source", "UserName" },
                values: new object[,]
                {
                    { 5, true, new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(2023), new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(2024), false, "edwin@inisys.in", null, true, null, "llFg1YwNHgLVbQGDz1aaEQ==", null, 1, null, "edwin" },
                    { 4, true, new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(1439), new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(1439), false, "seetha@inisys.in", null, true, null, "llFg1YwNHgLVbQGDz1aaEQ==", null, 1, null, "seetha" },
                    { 3, true, new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(818), new DateTime(2020, 5, 28, 9, 40, 25, 29, DateTimeKind.Utc).AddTicks(818), false, "senthil@gmail.com", null, true, null, "llFg1YwNHgLVbQGDz1aaEQ==", null, 1, null, "senthil" },
                    { 2, true, new DateTime(2020, 5, 28, 9, 40, 25, 28, DateTimeKind.Utc).AddTicks(9207), new DateTime(2020, 5, 28, 9, 40, 25, 28, DateTimeKind.Utc).AddTicks(9207), false, "seenu@inisys.in", null, true, null, "llFg1YwNHgLVbQGDz1aaEQ==", null, 1, null, "seenu" },
                    { 1, false, new DateTime(2020, 5, 28, 9, 40, 25, 28, DateTimeKind.Utc).AddTicks(8008), new DateTime(2020, 5, 28, 9, 40, 25, 28, DateTimeKind.Utc).AddTicks(8019), false, "winedjos@gmail.com", null, true, null, "llFg1YwNHgLVbQGDz1aaEQ==", null, 0, null, "admin" }
                });

            migrationBuilder.InsertData(
                table: "WebPages",
                columns: new[] { "ID", "Deleted", "Name", "Text", "Url" },
                values: new object[,]
                {
                    { 1, false, "ManageLand", "Land", "/manageland" },
                    { 2, false, "ManagePartition", "Partition", "/managepartition" },
                    { 3, false, "Plowing", "Plowing ", "/plowing " },
                    { 4, false, "Seeding", "Seeding", "/seeding" },
                    { 5, false, "PestControl", "Pest Control", "/pestcontrol" },
                    { 6, false, "WeedRemove", "Weed Remove", "/weedremove" },
                    { 7, false, "PostLogin", "Post Login", "/postlogin" },
                    { 8, false, "Harvesting", "Harvesting", "/harvesting" },
                    { 9, false, "Sale", "Sale", "/sale" },
                    { 10, false, "Report", "Report", "/report" }
                });

            migrationBuilder.InsertData(
                table: "RolePageAccesses",
                columns: new[] { "ID", "DateAdded", "DateModified", "Deleted", "PagesID", "RolesID" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5151), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5151), false, 1, 1 },
                    { 19, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5866), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5867), false, 9, 2 },
                    { 9, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5859), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5859), false, 9, 1 },
                    { 18, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5866), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5866), false, 8, 2 },
                    { 8, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5858), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5858), false, 8, 1 },
                    { 17, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5865), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5865), false, 7, 2 },
                    { 7, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5857), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5858), false, 7, 1 },
                    { 16, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5864), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5864), false, 6, 2 },
                    { 6, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5857), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5857), false, 6, 1 },
                    { 15, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5863), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5864), false, 5, 2 },
                    { 5, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5856), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5856), false, 5, 1 },
                    { 14, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5863), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5863), false, 4, 2 },
                    { 4, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5855), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5855), false, 4, 1 },
                    { 13, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5862), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5862), false, 3, 2 },
                    { 3, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5854), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5854), false, 3, 1 },
                    { 12, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5861), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5861), false, 2, 2 },
                    { 2, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5848), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5849), false, 2, 1 },
                    { 11, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5860), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5861), false, 1, 2 },
                    { 10, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5860), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5860), false, 10, 1 },
                    { 20, new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5867), new DateTime(2020, 5, 28, 9, 40, 25, 30, DateTimeKind.Utc).AddTicks(5867), false, 10, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GoogleRegisters_UserId",
                table: "GoogleRegisters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Harvestings_PartitionLandDetailId",
                table: "Harvestings",
                column: "PartitionLandDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Harvestings_UserId",
                table: "Harvestings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LandDetails_StateId",
                table: "LandDetails",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_LandDetails_UserId",
                table: "LandDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PartitionLandDetails_LandDetailId",
                table: "PartitionLandDetails",
                column: "LandDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PartitionLandDetails_UserId",
                table: "PartitionLandDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PestControls_PartitionLandDetailId",
                table: "PestControls",
                column: "PartitionLandDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PestControls_UserId",
                table: "PestControls",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Plowings_PartitionLandDetailId",
                table: "Plowings",
                column: "PartitionLandDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Plowings_UserId",
                table: "Plowings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePageAccesses_PagesID",
                table: "RolePageAccesses",
                column: "PagesID");

            migrationBuilder.CreateIndex(
                name: "IX_RolePageAccesses_RolesID",
                table: "RolePageAccesses",
                column: "RolesID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_PartitionLandDetailId",
                table: "Sales",
                column: "PartitionLandDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_UserId",
                table: "Sales",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Seedings_PartitionLandDetailId",
                table: "Seedings",
                column: "PartitionLandDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Seedings_UserId",
                table: "Seedings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivity_UserID",
                table: "UserActivity",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_WeedRemove_PartitionLandDetailId",
                table: "WeedRemove",
                column: "PartitionLandDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_WeedRemove_UserId",
                table: "WeedRemove",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configurations");

            migrationBuilder.DropTable(
                name: "GoogleRegisters");

            migrationBuilder.DropTable(
                name: "Harvestings");

            migrationBuilder.DropTable(
                name: "PestControls");

            migrationBuilder.DropTable(
                name: "Plowings");

            migrationBuilder.DropTable(
                name: "RolePageAccesses");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Seedings");

            migrationBuilder.DropTable(
                name: "UserActivity");

            migrationBuilder.DropTable(
                name: "WeedRemove");

            migrationBuilder.DropTable(
                name: "WebPages");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "PartitionLandDetails");

            migrationBuilder.DropTable(
                name: "LandDetails");

            migrationBuilder.DropTable(
                name: "StateLists");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
