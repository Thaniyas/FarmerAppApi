﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThaniyasFarmerAppAPI.Repository;

namespace ThaniyasFarmerAppAPI.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    partial class BaseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.Configuration", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded");

                    b.Property<DateTime>("DateModified");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Name");

                    b.Property<int?>("ParentID");

                    b.Property<string>("Text");

                    b.Property<string>("Type");

                    b.Property<string>("Value");

                    b.HasKey("ID");

                    b.ToTable("Configurations");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 349, DateTimeKind.Utc).AddTicks(8360),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 349, DateTimeKind.Utc).AddTicks(8361),
                            Deleted = false,
                            Name = "UserID",
                            Type = "SystemEmailSettings",
                            Value = "vNp/Rg/59Wq/aUZBS0+1LDWmAArWOdzzJByWFcSqj9c="
                        },
                        new
                        {
                            ID = 2,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 350, DateTimeKind.Utc).AddTicks(2155),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 350, DateTimeKind.Utc).AddTicks(2156),
                            Deleted = false,
                            Name = "Password",
                            Type = "SystemEmailSettings",
                            Value = "DR7VkCQllyJBLRHqnhoFLg=="
                        },
                        new
                        {
                            ID = 3,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 350, DateTimeKind.Utc).AddTicks(2918),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 350, DateTimeKind.Utc).AddTicks(2918),
                            Deleted = false,
                            Name = "SMTPPort",
                            Type = "SystemEmailSettings",
                            Value = "KfPgC+VOAFLCwNmgAKPmfQ=="
                        },
                        new
                        {
                            ID = 4,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 350, DateTimeKind.Utc).AddTicks(3521),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 350, DateTimeKind.Utc).AddTicks(3521),
                            Deleted = false,
                            Name = "Host",
                            Type = "SystemEmailSettings",
                            Value = "+fNJD/SKxu6Pyz64X9mIMQ=="
                        });
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.Harvestings", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cost")
                        .HasMaxLength(50);

                    b.Property<string>("Date");

                    b.Property<DateTime>("DateAdded");

                    b.Property<DateTime>("DateModified");

                    b.Property<bool>("Deleted");

                    b.Property<int>("LabourCost");

                    b.Property<int?>("LandDetailIDFK");

                    b.Property<string>("NOofLabours")
                        .HasMaxLength(50);

                    b.Property<int?>("PartitionLandDetailIDFK");

                    b.HasKey("ID");

                    b.HasIndex("LandDetailIDFK");

                    b.HasIndex("PartitionLandDetailIDFK");

                    b.ToTable("Harvestings");
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.LandDetails", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AreaSize");

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<DateTime>("DateAdded");

                    b.Property<DateTime>("DateModified");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("PattaNumber")
                        .HasMaxLength(50);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("Village")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("LandDetails");
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.PartitionLandDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AreaSize")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<DateTime>("DateAdded");

                    b.Property<DateTime>("DateModified");

                    b.Property<bool>("Deleted");

                    b.Property<int?>("LandDetailIDFK");

                    b.Property<string>("LandDirection")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.HasKey("ID");

                    b.HasIndex("LandDetailIDFK");

                    b.ToTable("PartitionLandDetails");
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.PestControl", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cost")
                        .HasMaxLength(50);

                    b.Property<string>("Date");

                    b.Property<DateTime>("DateAdded");

                    b.Property<DateTime>("DateModified");

                    b.Property<bool>("Deleted")
                        .HasMaxLength(50);

                    b.Property<string>("LabourCost")
                        .HasMaxLength(50);

                    b.Property<int?>("LandDetailIDFK");

                    b.Property<string>("NameofthePestSide")
                        .HasMaxLength(50);

                    b.Property<int?>("PartitionLandDetailIDFK");

                    b.Property<string>("Purpose")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.HasIndex("LandDetailIDFK");

                    b.HasIndex("PartitionLandDetailIDFK");

                    b.ToTable("PestControls");
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.Plowing", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date");

                    b.Property<DateTime>("DateAdded");

                    b.Property<DateTime>("DateModified");

                    b.Property<bool>("Deleted")
                        .HasMaxLength(50);

                    b.Property<int?>("LandDetailIDFK");

                    b.Property<int?>("PartitionLandDetailIDFK");

                    b.Property<string>("PlowingExp")
                        .HasMaxLength(50);

                    b.Property<string>("TypeofPlowing")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.HasIndex("LandDetailIDFK");

                    b.HasIndex("PartitionLandDetailIDFK");

                    b.ToTable("Plowings");
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.RolePageAccess", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded");

                    b.Property<DateTime>("DateModified");

                    b.Property<bool>("Deleted");

                    b.Property<int>("PagesID");

                    b.Property<int>("RolesID");

                    b.HasKey("ID");

                    b.HasIndex("PagesID");

                    b.HasIndex("RolesID");

                    b.ToTable("RolePageAccesses");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(45),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(45),
                            Deleted = false,
                            PagesID = 1,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 2,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(869),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(869),
                            Deleted = false,
                            PagesID = 2,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 3,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(875),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(875),
                            Deleted = false,
                            PagesID = 3,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 4,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(876),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(876),
                            Deleted = false,
                            PagesID = 4,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 5,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(877),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(877),
                            Deleted = false,
                            PagesID = 5,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 6,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(878),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(878),
                            Deleted = false,
                            PagesID = 6,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 7,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(878),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(879),
                            Deleted = false,
                            PagesID = 7,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 8,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(879),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(879),
                            Deleted = false,
                            PagesID = 8,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 9,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(880),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(880),
                            Deleted = false,
                            PagesID = 9,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 10,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(881),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(881),
                            Deleted = false,
                            PagesID = 10,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 11,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(882),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(882),
                            Deleted = false,
                            PagesID = 1,
                            RolesID = 2
                        },
                        new
                        {
                            ID = 12,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(882),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(883),
                            Deleted = false,
                            PagesID = 2,
                            RolesID = 2
                        },
                        new
                        {
                            ID = 13,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(883),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(883),
                            Deleted = false,
                            PagesID = 3,
                            RolesID = 2
                        },
                        new
                        {
                            ID = 14,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(884),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(884),
                            Deleted = false,
                            PagesID = 4,
                            RolesID = 2
                        },
                        new
                        {
                            ID = 15,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(885),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(885),
                            Deleted = false,
                            PagesID = 5,
                            RolesID = 2
                        },
                        new
                        {
                            ID = 16,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(885),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(886),
                            Deleted = false,
                            PagesID = 6,
                            RolesID = 2
                        },
                        new
                        {
                            ID = 17,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(886),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(887),
                            Deleted = false,
                            PagesID = 7,
                            RolesID = 2
                        },
                        new
                        {
                            ID = 18,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(887),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(887),
                            Deleted = false,
                            PagesID = 8,
                            RolesID = 2
                        },
                        new
                        {
                            ID = 19,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(888),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(888),
                            Deleted = false,
                            PagesID = 9,
                            RolesID = 2
                        },
                        new
                        {
                            ID = 20,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(889),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(889),
                            Deleted = false,
                            PagesID = 10,
                            RolesID = 2
                        });
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.Roles", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Deleted");

                    b.Property<string>("Name");

                    b.Property<string>("Text");

                    b.HasKey("ID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Deleted = false,
                            Name = "Admin",
                            Text = "Admin"
                        },
                        new
                        {
                            ID = 2,
                            Deleted = false,
                            Name = "User",
                            Text = "User"
                        },
                        new
                        {
                            ID = 3,
                            Deleted = false,
                            Name = "SiteAdmin",
                            Text = "Admin"
                        });
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.Sale", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BuyerMobileNumber")
                        .HasMaxLength(50);

                    b.Property<string>("BuyerName")
                        .HasMaxLength(50);

                    b.Property<string>("Date");

                    b.Property<DateTime>("DateAdded");

                    b.Property<DateTime>("DateModified");

                    b.Property<bool>("Deleted");

                    b.Property<int?>("LandDetailIDFK");

                    b.Property<int?>("PartitionLandDetailIDFK");

                    b.Property<string>("Price")
                        .HasMaxLength(50);

                    b.Property<string>("Quantity")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.HasIndex("LandDetailIDFK");

                    b.HasIndex("PartitionLandDetailIDFK");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.Seeding", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded");

                    b.Property<DateTime>("DateModified");

                    b.Property<bool>("Deleted");

                    b.Property<int>("LabourCost");

                    b.Property<int?>("LandDetailIDFK");

                    b.Property<string>("NOofLabours")
                        .HasMaxLength(50);

                    b.Property<int?>("PartitionLandDetailIDFK");

                    b.Property<string>("Quantity")
                        .HasMaxLength(50);

                    b.Property<string>("SeedCost")
                        .HasMaxLength(50);

                    b.Property<string>("SeedName")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.HasIndex("LandDetailIDFK");

                    b.HasIndex("PartitionLandDetailIDFK");

                    b.ToTable("Seedings");
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.StateList", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StateName");

                    b.HasKey("ID");

                    b.ToTable("StateLists");
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AcceptedTermsAndConditions");

                    b.Property<DateTime>("DateAdded");

                    b.Property<DateTime>("DateModified");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .HasMaxLength(30);

                    b.Property<bool>("IsFirstTimeLogin");

                    b.Property<string>("LastName")
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("ResetPasswordToken");

                    b.Property<int>("RoleID");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AcceptedTermsAndConditions = true,
                            DateAdded = new DateTime(2020, 2, 26, 4, 45, 20, 349, DateTimeKind.Utc).AddTicks(5165),
                            DateModified = new DateTime(2020, 2, 26, 4, 45, 20, 349, DateTimeKind.Utc).AddTicks(5176),
                            Deleted = false,
                            Email = "winedjos@gmail.com",
                            IsFirstTimeLogin = true,
                            Password = "llFg1YwNHgLVbQGDz1aaEQ==",
                            RoleID = 1,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.UserActivity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activity")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<DateTime>("TimeStamp");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("UserActivity");
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.WebPages", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Deleted");

                    b.Property<string>("Name");

                    b.Property<string>("Text");

                    b.Property<string>("Url");

                    b.HasKey("ID");

                    b.ToTable("WebPages");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Deleted = false,
                            Name = "ManageLand",
                            Text = "Land",
                            Url = "/manageland"
                        },
                        new
                        {
                            ID = 2,
                            Deleted = false,
                            Name = "ManagePartition",
                            Text = "Partition",
                            Url = "/managepartition"
                        },
                        new
                        {
                            ID = 3,
                            Deleted = false,
                            Name = "Plowing",
                            Text = "Plowing ",
                            Url = "/plowing "
                        },
                        new
                        {
                            ID = 4,
                            Deleted = false,
                            Name = "Seeding",
                            Text = "Seeding",
                            Url = "/seeding"
                        },
                        new
                        {
                            ID = 5,
                            Deleted = false,
                            Name = "PestControl",
                            Text = "Pest Control",
                            Url = "/pestcontrol"
                        },
                        new
                        {
                            ID = 6,
                            Deleted = false,
                            Name = "WeedRemove",
                            Text = "Weed Remove",
                            Url = "/weedremove"
                        },
                        new
                        {
                            ID = 7,
                            Deleted = false,
                            Name = "PostLogin",
                            Text = "Post Login",
                            Url = "/postlogin"
                        },
                        new
                        {
                            ID = 8,
                            Deleted = false,
                            Name = "Harvesting",
                            Text = "Harvesting",
                            Url = "/harvesting"
                        },
                        new
                        {
                            ID = 9,
                            Deleted = false,
                            Name = "Sale",
                            Text = "Sale",
                            Url = "/sale"
                        },
                        new
                        {
                            ID = 10,
                            Deleted = false,
                            Name = "Report",
                            Text = "Report",
                            Url = "/report"
                        });
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.WeedRemove", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cost")
                        .HasMaxLength(50);

                    b.Property<string>("Date");

                    b.Property<DateTime>("DateAdded");

                    b.Property<DateTime>("DateModified");

                    b.Property<bool>("Deleted");

                    b.Property<int>("LabourCost");

                    b.Property<int?>("LandDetailIDFK");

                    b.Property<string>("NOofLabours")
                        .HasMaxLength(50);

                    b.Property<int?>("PartitionLandDetailIDFK");

                    b.HasKey("ID");

                    b.HasIndex("LandDetailIDFK");

                    b.HasIndex("PartitionLandDetailIDFK");

                    b.ToTable("WeedRemove");
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.Harvestings", b =>
                {
                    b.HasOne("ThaniyasFarmerAppAPI.Models.LandDetails", "LandDetailsId")
                        .WithMany()
                        .HasForeignKey("LandDetailIDFK");

                    b.HasOne("ThaniyasFarmerAppAPI.Models.PartitionLandDetail", "PartitionLandDetailId")
                        .WithMany()
                        .HasForeignKey("PartitionLandDetailIDFK");
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.PartitionLandDetail", b =>
                {
                    b.HasOne("ThaniyasFarmerAppAPI.Models.LandDetails", "LandDetails")
                        .WithMany()
                        .HasForeignKey("LandDetailIDFK");
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.PestControl", b =>
                {
                    b.HasOne("ThaniyasFarmerAppAPI.Models.LandDetails", "LandDetailsId")
                        .WithMany()
                        .HasForeignKey("LandDetailIDFK");

                    b.HasOne("ThaniyasFarmerAppAPI.Models.PartitionLandDetail", "PartitionLandDetailId")
                        .WithMany()
                        .HasForeignKey("PartitionLandDetailIDFK");
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.Plowing", b =>
                {
                    b.HasOne("ThaniyasFarmerAppAPI.Models.LandDetails", "LandDetailsId")
                        .WithMany()
                        .HasForeignKey("LandDetailIDFK");

                    b.HasOne("ThaniyasFarmerAppAPI.Models.PartitionLandDetail", "PartitionLandDetailId")
                        .WithMany()
                        .HasForeignKey("PartitionLandDetailIDFK");
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.RolePageAccess", b =>
                {
                    b.HasOne("ThaniyasFarmerAppAPI.Models.WebPages", "Pages")
                        .WithMany()
                        .HasForeignKey("PagesID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ThaniyasFarmerAppAPI.Models.Roles", "Roles")
                        .WithMany()
                        .HasForeignKey("RolesID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.Sale", b =>
                {
                    b.HasOne("ThaniyasFarmerAppAPI.Models.LandDetails", "LandDetailsId")
                        .WithMany()
                        .HasForeignKey("LandDetailIDFK");

                    b.HasOne("ThaniyasFarmerAppAPI.Models.PartitionLandDetail", "PartitionLandDetailId")
                        .WithMany()
                        .HasForeignKey("PartitionLandDetailIDFK");
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.Seeding", b =>
                {
                    b.HasOne("ThaniyasFarmerAppAPI.Models.LandDetails", "LandDetailsId")
                        .WithMany()
                        .HasForeignKey("LandDetailIDFK");

                    b.HasOne("ThaniyasFarmerAppAPI.Models.PartitionLandDetail", "PartitionLandDetailId")
                        .WithMany()
                        .HasForeignKey("PartitionLandDetailIDFK");
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.UserActivity", b =>
                {
                    b.HasOne("ThaniyasFarmerAppAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.WeedRemove", b =>
                {
                    b.HasOne("ThaniyasFarmerAppAPI.Models.LandDetails", "LandDetailsId")
                        .WithMany()
                        .HasForeignKey("LandDetailIDFK");

                    b.HasOne("ThaniyasFarmerAppAPI.Models.PartitionLandDetail", "PartitionLandDetailId")
                        .WithMany()
                        .HasForeignKey("PartitionLandDetailIDFK");
                });
#pragma warning restore 612, 618
        }
    }
}
