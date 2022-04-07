using KärraGamesCorner.Data.Models;

namespace KärraGamesCorner.Interfaces
{
    public interface IUnitOfWork
    {
        public IRepository<ApplicationUser, Guid> Users { get; }
        public IRepository<Genre, int> Genres { get; }
        public IRepository<Product, int> Products { get; }
        public IRepository<Token, int> Tokens { get; }

        public Task CommitAsync();
    }
}
