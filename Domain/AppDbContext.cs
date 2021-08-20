using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServiceApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "5d59f0d8-f9ac-457c-8a9e-b97353f03ac2",
                Name="admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "4f434624-fe0b-4e8b-9434-de824cdeeac5",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@gmail.com",
                NormalizedEmail = "MY@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null,"superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
              RoleId = "5d59f0d8-f9ac-457c-8a9e-b97353f03ac2",
              UserId = "4f434624-fe0b-4e8b-9434-de824cdeeac5"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("4805b6d7-fdc0-46b1-8182-ac456c502fb9"),
                CodeWord = "PageIndex",
                Title = "Main Page"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("949adf2f-c440-4baf-9eab-d84e511b5854"),
                CodeWord = "PageServices",
                Title = "Our Services"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("3a505d61-37f2-44dd-b4c2-1bf50f2847b3"),
                CodeWord = "PageContacts",
                Title = "Contacts"
            });
        }
    }
}
