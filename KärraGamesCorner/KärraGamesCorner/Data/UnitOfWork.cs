using KärraGamesCorner.Data.Models;
using KärraGamesCorner.Interfaces;

namespace KärraGamesCorner.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<ApplicationUser, Guid> Users { get; private set; }
        public IRepository<Genre, int> Genres { get; private set; }
        public IRepository<Product, int> Products { get; private set; }
        public IRepository<Token, int> Tokens { get; private set; }

        private readonly ApplicationDbContext context;

        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;

            Users = new GenericRepository<ApplicationUser, Guid>(context);
            Genres = new GenericRepository<Genre, int>(context);
            Products = new GenericRepository<Product, int>(context);
            Tokens = new GenericRepository<Token, int>(context);
        }

        public async Task CommitAsync()
        {
            try
            {
                await context.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
