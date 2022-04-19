using KärraGamesCorner.Data.Models;

namespace KärraGamesCorner.Interfaces
{
    public interface IUnitOfWork
    {
        public IRepository<ApplicationUser> Users { get; }
        public IRepository<Genre> Genres { get; }
        public IRepository<Order> Orders { get; }
        public IRepository<Product> Products { get; }
        public IRepository<Token> Tokens { get; }
        public IRepository<CartProduct> CartProducts { get; }

        public Task CommitAsync();
    }
}
