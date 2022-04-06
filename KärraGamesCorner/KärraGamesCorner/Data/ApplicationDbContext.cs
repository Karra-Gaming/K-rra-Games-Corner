using KärraGamesCorner.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<ApplicationUser>(u =>
        //    {
        //        u.HasMany<Product>().WithMany <ApplicationUser>()
        //    });
        //}
    }
}