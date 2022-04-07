using KärraGamesCorner.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Core;

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

        public async Task<bool> DeleteAsync(U id)
        {
            if (id < 0) return false;
            
            if(await _dbSet.FirstOrDefaultAsync<T>(t => t.Id == type.Id) is null) return false;
             _dbSet.Remove(type);
             return true;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Task.FromResult(_dbSet);
        }

       
        public async Task<T> GetAsync(Guid guid)
        {

        }

        public async Task UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
