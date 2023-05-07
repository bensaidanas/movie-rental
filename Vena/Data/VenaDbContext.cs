using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vena.Models;

namespace Vena.Data
{
    public class VenaDbContext : IdentityDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public VenaDbContext(DbContextOptions<VenaDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            AppUser user = new AppUser()
            {
                FirstName = "Venus",
                LastName = "Vena",
                UserName = "Vena.Venus",
                Email = "Vena.Venus@gmail.com"
            };
            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();
            passwordHasher.HashPassword(user, "Venus@123");
            builder.Entity<AppUser>().HasData(user);
            IdentityRole role = new IdentityRole()
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = "1"
            };
            builder.Entity<IdentityRole>().HasData(role);

        }
    }
}
