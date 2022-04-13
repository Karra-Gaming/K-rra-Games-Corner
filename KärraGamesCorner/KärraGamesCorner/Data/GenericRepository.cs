using System.Text;
using KärraGamesCorner.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace KärraGamesCorner.Data
{
    public class GenericRepository<T> : IRepository<T> where T : class
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

        public async Task<bool> DeleteAsync(params object[] keys)
        {
            var entity = await _dbSet.FindAsync(keys);
            if (entity is null) return false;
            
            _dbSet.Remove(entity);
            return await Task.FromResult(true);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Task.FromResult(_dbSet);
        }

        public async Task<T> GetAsync(params object[] keys)
        {
            return await Task.FromResult(await _dbSet.FindAsync(keys));
        }

        public async Task UpdateAsync(params object[] keys)
        {
            var entity = await _dbSet.FindAsync(keys);
            if (entity is null) return;

            _dbSet.Update(entity);
        }
    }
}
