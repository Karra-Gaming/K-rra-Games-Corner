using KärraGamesCorner.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace KärraGamesCorner.Data
{
    public class GenericRepository<T,U> : IRepository<T,U> where T : class, IEntity<U> where U  : struct
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            _dbSet = applicationDbContext.Set<T>();
        }

        public async Task<bool> CreateAsync(T type)
        {
            if (type is null) return false;
            if (await _dbSet.ContainsAsync(type)) return false;
            await _dbSet.AddAsync(type);

            return true;
        }

        public async Task<bool> DeleteAsync(T type)
        {
            if (!_dbSet.Any(t => t.Id.Equals(type.Id)))
            {
                return await Task.FromResult(false);
            }

            _dbSet.Remove(type);
            return await Task.FromResult(true);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Task.FromResult(_dbSet);
        }

        public async Task<T> GetAsync(U id)
        {
            return await Task.FromResult(_dbSet.FirstOrDefault(t => t.Id.Equals(id))!);
        }

        public async Task UpdateOrCreateAsync(T type)
        {
            if (type is null)
            {
                return;
            }
            else if (!_dbSet.Any(t => t.Id.Equals(type.Id)))
            {
                await CreateAsync(type);
                return;
            }

            _dbSet.Update(type);
        }
    }
}
