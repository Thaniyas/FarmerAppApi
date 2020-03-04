﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThaniyasFarmerAppAPI.Repository;

namespace ThaniyasFarmerAppAPI.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    [Migration("20200215045751_removeingLandName")]
    partial class removeingLandName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 223, DateTimeKind.Utc).AddTicks(6789),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 223, DateTimeKind.Utc).AddTicks(6789),
                            Deleted = false,
                            Name = "UserID",
                            Type = "SystemEmailSettings",
                            Value = "vNp/Rg/59Wq/aUZBS0+1LDWmAArWOdzzJByWFcSqj9c="
                        },
                        new
                        {
                            ID = 2,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 223, DateTimeKind.Utc).AddTicks(9485),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 223, DateTimeKind.Utc).AddTicks(9485),
                            Deleted = false,
                            Name = "Password",
                            Type = "SystemEmailSettings",
                            Value = "DR7VkCQllyJBLRHqnhoFLg=="
                        },
                        new
                        {
                            ID = 3,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(249),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(250),
                            Deleted = false,
                            Name = "SMTPPort",
                            Type = "SystemEmailSettings",
                            Value = "KfPgC+VOAFLCwNmgAKPmfQ=="
                        },
                        new
                        {
                            ID = 4,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(855),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(855),
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

                    b.Property<string>("Land")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("NOofLabours")
                        .HasMaxLength(50);

                    b.Property<string>("PartitionLand")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.HasKey("ID");

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

                    b.Property<string>("Unit");

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

                    b.Property<int?>("LandDetailsID");

                    b.Property<string>("LandDirection")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.HasKey("ID");

                    b.HasIndex("LandDetailsID");

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

                    b.Property<string>("Land")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("NameofthePestSide")
                        .HasMaxLength(50);

                    b.Property<string>("PartitionLand")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("Purpose")
                        .HasMaxLength(50);

                    b.HasKey("ID");

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

                    b.Property<string>("Land")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("PartitionLand")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("PlowingExp")
                        .HasMaxLength(50);

                    b.Property<string>("TypeofPlowing")
                        .HasMaxLength(50);

                    b.HasKey("ID");

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
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7128),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7128),
                            Deleted = false,
                            PagesID = 1,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 2,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7846),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7846),
                            Deleted = false,
                            PagesID = 2,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 3,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7853),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7853),
                            Deleted = false,
                            PagesID = 3,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 4,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7854),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7854),
                            Deleted = false,
                            PagesID = 4,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 5,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7854),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7855),
                            Deleted = false,
                            PagesID = 5,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 6,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7855),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7855),
                            Deleted = false,
                            PagesID = 6,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 7,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7856),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7856),
                            Deleted = false,
                            PagesID = 7,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 8,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7857),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7857),
                            Deleted = false,
                            PagesID = 8,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 9,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7858),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7858),
                            Deleted = false,
                            PagesID = 9,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 10,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7858),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7859),
                            Deleted = false,
                            PagesID = 10,
                            RolesID = 1
                        },
                        new
                        {
                            ID = 11,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7859),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7859),
                            Deleted = false,
                            PagesID = 1,
                            RolesID = 2
                        },
                        new
                        {
                            ID = 12,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7860),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7860),
                            Deleted = false,
                            PagesID = 2,
                            RolesID = 2
                        },
                        new
                        {
                            ID = 13,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7861),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7861),
                            Deleted = false,
                            PagesID = 3,
                            RolesID = 2
                        },
                        new
                        {
                            ID = 14,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7862),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7862),
                            Deleted = false,
                            PagesID = 4,
                            RolesID = 2
                        },
                        new
                        {
                            ID = 15,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7862),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7863),
                            Deleted = false,
                            PagesID = 5,
                            RolesID = 2
                        },
                        new
                        {
                            ID = 16,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7863),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7863),
                            Deleted = false,
                            PagesID = 6,
                            RolesID = 2
                        },
                        new
                        {
                            ID = 17,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7903),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7903),
                            Deleted = false,
                            PagesID = 7,
                            RolesID = 2
                        },
                        new
                        {
                            ID = 18,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7904),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7904),
                            Deleted = false,
                            PagesID = 8,
                            RolesID = 2
                        },
                        new
                        {
                            ID = 19,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7905),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7905),
                            Deleted = false,
                            PagesID = 9,
                            RolesID = 2
                        },
                        new
                        {
                            ID = 20,
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7906),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7906),
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

                    b.Property<string>("Land")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("PartitionLand")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("Price")
                        .HasMaxLength(50);

                    b.Property<string>("Quantity")
                        .HasMaxLength(50);

                    b.HasKey("ID");

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

                    b.Property<string>("Land")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("NOofLabours")
                        .HasMaxLength(50);

                    b.Property<string>("PartitionLand")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("Quantity")
                        .HasMaxLength(50);

                    b.Property<string>("SeedCost")
                        .HasMaxLength(50);

                    b.Property<string>("SeedName")
                        .HasMaxLength(50);

                    b.HasKey("ID");

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
                            DateAdded = new DateTime(2020, 2, 15, 4, 57, 51, 223, DateTimeKind.Utc).AddTicks(3816),
                            DateModified = new DateTime(2020, 2, 15, 4, 57, 51, 223, DateTimeKind.Utc).AddTicks(3827),
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

                    b.Property<string>("Land")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("NOofLabours")
                        .HasMaxLength(50);

                    b.Property<string>("PartitionLand")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.HasKey("ID");

                    b.ToTable("WeedRemove");
                });

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.PartitionLandDetail", b =>
                {
                    b.HasOne("ThaniyasFarmerAppAPI.Models.LandDetails", "LandDetails")
                        .WithMany()
                        .HasForeignKey("LandDetailsID");
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

            modelBuilder.Entity("ThaniyasFarmerAppAPI.Models.UserActivity", b =>
                {
                    b.HasOne("ThaniyasFarmerAppAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
