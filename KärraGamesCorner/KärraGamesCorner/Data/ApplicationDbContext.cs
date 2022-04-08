using System.Net;
using System.Reflection;
using KärraGamesCorner.Data.Models;
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
            ////string fileName = "Resources/Produkter.Json";
            ////string readAllText = File.ReadAllText(fileName);
            //modelBuilder
            //    .Entity<Genre>().HasData(
            //        new Genre (){Id = 1, Name = "Rollspel"},
            //        new Genre() { Id = 2, Name = "Pussel" },
            //        new Genre() { Id = 3, Name = "Sällskapsspel" },
            //        new Genre() { Id = 4, Name = "Actionrollspel" },
            //        new Genre() { Id = 5, Name = "Kortspel" },
            //        new Genre() { Id = 6, Name = "Skräck" },
            //        new Genre() { Id = 7, Name = "Äventyr" },
            //        new Genre() { Id = 8, Name = "Strategi" },
            //        new Genre() { Id = 9, Name = "FPS" },
            //        new Genre() { Id = 10, Name = "Överlevnad" },
            //        new Genre() { Id = 11, Name = "MMORPG" },
            //        new Genre() { Id = 12, Name = "Racing" },
            //        new Genre() { Id = 13, Name = "Simulator" });

            ////Använd inte konstruktorn när du lägger till produkter
            ////Product[] productList = Newtonsoft.Json.JsonConvert.DeserializeObject<Product[]>(readAllText);
            //var prod = new Product[] { new Product(1, "bla", "bla", 20, new Genre(), "", ""), };
            //new Product(2, "bla", "bla", 20, GenreId = 2, "", "");

            //modelBuilder
            //    .Entity<Product>().HasData(prod);

            base.OnModelCreating(modelBuilder);
                    
            
        }
    }
}