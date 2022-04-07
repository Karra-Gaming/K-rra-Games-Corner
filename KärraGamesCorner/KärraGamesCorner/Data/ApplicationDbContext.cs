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
            //string fileName = "Resources/Produkter.Json";
            //string readAllText = File.ReadAllText(fileName);

            //Product[] productList = Newtonsoft.Json.JsonConvert.DeserializeObject<Product[]>(readAllText);
            //var prod = new Product[] { new Product(1, "bla", "bla", 20, new Genre(), "", ""), };
            //new Product(2, "bla", "bla", 20, new Genre(), "", "");

            modelBuilder
                .ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly())
                .Entity<Product>().HasData(prod);
                    
            
        }
    }
}