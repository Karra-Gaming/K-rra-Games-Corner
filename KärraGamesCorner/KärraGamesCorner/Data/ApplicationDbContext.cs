using System.Net;
using System.Reflection;
using KärraGamesCorner.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace KärraGamesCorner.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Product> Products;
        public DbSet<ApplicationUser> ApplicationUsers;
        public DbSet<Token> Tokens;
        public DbSet<Genre> Genres;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //string fileName = "~/Resources/Produkter.Json";
            //string readAllText = File.ReadAllText(fileName);
            modelBuilder
                .Entity<Genre>().HasData(
                    new Genre() { Id = 1, Name = "Rollspel" },
                    new Genre() { Id = 2, Name = "Pussel" },
                    new Genre() { Id = 3, Name = "Sällskapsspel" },
                    new Genre() { Id = 4, Name = "Actionrollspel" },
                    new Genre() { Id = 5, Name = "Kortspel" },
                    new Genre() { Id = 6, Name = "Skräck" },
                    new Genre() { Id = 7, Name = "Äventyr" },
                    new Genre() { Id = 8, Name = "Strategi" },
                    new Genre() { Id = 9, Name = "FPS" },
                    new Genre() { Id = 10, Name = "Överlevnad" },
                    new Genre() { Id = 11, Name = "MMORPG" },
                    new Genre() { Id = 12, Name = "Racing" },
                    new Genre() { Id = 13, Name = "Simulator" });

            //Använd inte konstruktorn när du lägger till produkter
            //Product[] productList = Newtonsoft.Json.JsonConvert.DeserializeObject<Product[]>(readAllText);
            //var prod = new Product[] { new Product(1, "bla", "bla", 20, new Genre(), "", ""), };
            var prod = new Product(){
                Id = 2,
                Name = "bla",
                Description = "bla",
                Price = 20,
                GenreId = 2,
                ImageUrl = "",
                Producer = ""
            };

            modelBuilder
                .Entity<Product>().HasData(prod);

Guid ADMIN_ID = Guid.NewGuid();
            string ROLE_ID = Guid.NewGuid().ToString();

            //seed admin role
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            });

            //create user
            var appUser = new ApplicationUser()
            {
                Id = ADMIN_ID,
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM"
            };

            //set user password
            PasswordHasher<ApplicationUser> ph = new PasswordHasher<ApplicationUser>();
            appUser.PasswordHash = ph.HashPassword(appUser, "admin");

            //seed user
            builder.Entity<ApplicationUser>().HasData(appUser);

            //set user role to admin
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID.ToString()
            });
            base.OnModelCreating(modelBuilder);
                    
            

        }
    }
}