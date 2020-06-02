using ThaniyasFarmerAppAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Repository
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
        {
        }

        //entities
        public DbSet<User> Users { get; set; }
        public DbSet<LandDetail> LandDetails { get; set; }
        public DbSet<PartitionLandDetail> PartitionLandDetails { get; set; }
        public DbSet<Harvestings> Harvestings { get; set; }
        public DbSet<PestControl> PestControls { get; set; }
        public DbSet<Plowing> Plowings { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Seeding> Seedings { get; set; }
        public DbSet<WeedRemove> WeedRemove { get; set; }
        public DbSet<UserActivity> UserActivity { get; set; }
        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<WebPages> WebPages { get; set; }
        public DbSet<RolePageAccess> RolePageAccesses { get; set; }
        public DbSet<StateList> StateLists { get; set; }        
        public DbSet<GoogleRegister> GoogleRegisters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<LandDetail>()
            //    .HasMany(e => e.PartitionLandDetails)
            //    .WithOne(c => c.LandDetail);

            //modelBuilder.Entity<PartitionLandDetail>()
            //    .HasOne(e => e.LandDetail)
            //    .WithMany(c => c.PartitionLandDetails);         

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    UserName = "admin",
                    Email = "winedjos@gmail.com",
                    Password = Helpers.StringCipher.Encrypt("Password*123"),
                    DateAdded = DateTime.UtcNow,
                    DateModified=DateTime.UtcNow,
                    //RoleID = 1,
                   // AcceptedTermsAndConditions = true,
                    IsFirstTimeLogin = true
                },
                new User
                {
                    ID = 2,
                    UserName = "seenu",
                    Email = "seenu@inisys.in",
                    Password = Helpers.StringCipher.Encrypt("Password*123"),
                    DateAdded = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,
                    RoleID = 1,
                    AcceptedTermsAndConditions = true,
                    IsFirstTimeLogin = true
                }
                , new User
                {
                    ID = 3,
                    UserName = "senthil",
                    Email = "senthil@gmail.com",
                    Password = Helpers.StringCipher.Encrypt("Password*123"),
                    DateAdded = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,
                    RoleID = 1,
                    AcceptedTermsAndConditions = true,
                    IsFirstTimeLogin = true
                }
                , new User
                {
                    ID = 4,
                    UserName = "seetha",
                    Email = "seetha@inisys.in",
                    Password = Helpers.StringCipher.Encrypt("Password*123"),
                    DateAdded = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,
                    RoleID = 1,
                    AcceptedTermsAndConditions = true,
                    IsFirstTimeLogin = true
                }
                , new User
                {
                    ID = 5,
                    UserName = "edwin",
                    Email = "edwin@inisys.in",
                    Password = Helpers.StringCipher.Encrypt("Password*123"),
                    DateAdded = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,
                    RoleID = 1,
                    AcceptedTermsAndConditions = true,
                    IsFirstTimeLogin = true
                });
            modelBuilder.Entity<Configuration>().HasData(
                new Configuration
                {
                    ID = 1, Type = "SystemEmailSettings", Name = "UserID", Value = Helpers.StringCipher.Encrypt("lpelliotthicks@gmail.com")                  
                },
                new Configuration
                {
                    ID = 2,
                    Type = "SystemEmailSettings",
                    Name = "Password",
                    Value = Helpers.StringCipher.Encrypt("Elliott123!1")
                },
                new Configuration
                {
                    ID = 3,
                    Type = "SystemEmailSettings",
                    Name = "SMTPPort",
                    Value = Helpers.StringCipher.Encrypt("587")
                },
                new Configuration
                {
                    ID = 4,
                    Type = "SystemEmailSettings",
                    Name = "Host",
                    Value = Helpers.StringCipher.Encrypt("smtp.gmail.com")
                });

            modelBuilder.Entity<Roles>().HasData(
                new Roles
                {
                    ID = 1,
                    Name = "Admin",
                    Text="Admin",
                    Deleted = false
                },
                new Roles
                {
                    ID = 2,
                    Name = "User",
                    Text = "User",
                    Deleted = false
                },
                new Roles
                {
                    ID = 3,
                    Name = "SiteAdmin",
                    Text = "Admin",
                    Deleted = false
                });

            modelBuilder.Entity<StateList>().HasData(
               new StateList
               {
                   ID = 1,
                   StateName = "Tamilnadu"
               },
               new StateList
               {
                   ID = 2,
                   StateName = "Kerala"
               },
               new StateList
               {
                   ID = 3,
                   StateName = "Karnataka"
               });

            modelBuilder.Entity<WebPages>().HasData(
               new WebPages
               {
                   ID = 1,
                   Name = "ManageLand",
                   Text = "Land",
                   Url= "/manageland",
                   Deleted = false
               },
               new WebPages
               {
                   ID = 2,
                   Name = "ManagePartition",
                   Text = "Partition",
                   Url = "/managepartition",
                   Deleted = false
               },
               new WebPages
               {
                   ID = 3,
                   Name = "Plowing",
                   Text = "Plowing ",
                   Url = "/plowing ",
                   Deleted = false
               },
               new WebPages
               {
                   ID = 4,
                   Name = "Seeding",
                   Text = "Seeding",
                   Url = "/seeding",
                   Deleted = false
               },
               new WebPages
               {
                   ID = 5,
                   Name = "PestControl",
                   Text = "Pest Control",
                   Url = "/pestcontrol",
                   Deleted = false
               },
               new WebPages
               {
                   ID = 6,
                   Name = "WeedRemove",
                   Text = "Weed Remove",
                   Url = "/weedremove",
                   Deleted = false
               },
               new WebPages
               {
                   ID = 7,
                   Name = "PostLogin",
                   Text = "Post Login",
                   Url = "/postlogin",
                   Deleted = false
               },
               new WebPages
               {
                   ID = 8,
                   Name = "Harvesting",
                   Text = "Harvesting",
                   Url = "/harvesting",
                   Deleted = false
               },
               new WebPages
               {
                   ID = 9,
                   Name = "Sale",
                   Text = "Sale",
                   Url = "/sale",
                   Deleted = false
               },
               new WebPages
               {
                   ID = 10,
                   Name = "Report",
                   Text = "Report",
                   Url = "/report",
                   Deleted = false
               }
               );

            modelBuilder.Entity<RolePageAccess>().HasData(
                // Admin
               new RolePageAccess{ ID = 1, Deleted = false, RolesID=1, PagesID=1},
               new RolePageAccess { ID = 2, Deleted = false, RolesID = 1, PagesID = 2 },
               new RolePageAccess { ID = 3, Deleted = false, RolesID = 1, PagesID = 3 },
               new RolePageAccess { ID = 4, Deleted = false, RolesID = 1, PagesID = 4 },
               new RolePageAccess { ID = 5, Deleted = false, RolesID = 1, PagesID = 5 },
               new RolePageAccess { ID = 6, Deleted = false, RolesID = 1, PagesID = 6 },
               new RolePageAccess { ID = 7, Deleted = false, RolesID = 1, PagesID = 7 },
               new RolePageAccess { ID = 8, Deleted = false, RolesID = 1, PagesID = 8 },
               new RolePageAccess { ID = 9, Deleted = false, RolesID = 1, PagesID = 9 },
               new RolePageAccess { ID = 10, Deleted = false, RolesID = 1, PagesID = 10 },

               //  user

               new RolePageAccess { ID = 11, Deleted = false, RolesID = 2, PagesID = 1 },
               new RolePageAccess { ID = 12, Deleted = false, RolesID = 2, PagesID = 2 },
               new RolePageAccess { ID = 13, Deleted = false, RolesID = 2, PagesID = 3 },
               new RolePageAccess { ID = 14, Deleted = false, RolesID = 2, PagesID = 4 },
               new RolePageAccess { ID = 15, Deleted = false, RolesID = 2, PagesID = 5 },
               new RolePageAccess { ID = 16, Deleted = false, RolesID = 2, PagesID = 6 },
               new RolePageAccess { ID = 17, Deleted = false, RolesID = 2, PagesID = 7 },
               new RolePageAccess { ID = 18, Deleted = false, RolesID = 2, PagesID = 8 },
               new RolePageAccess { ID = 19, Deleted = false, RolesID = 2, PagesID = 9 },
               new RolePageAccess { ID = 20, Deleted = false, RolesID = 2, PagesID = 10 }
               );
        }
    }
}
