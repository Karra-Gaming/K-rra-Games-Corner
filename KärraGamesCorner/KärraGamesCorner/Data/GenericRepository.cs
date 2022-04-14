using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace KärraGamesCorner.Data
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
            _dbSet = this.context.Set<T>();
        }

        public async Task CreateAsync(T type)
        {
            _dbSet.AddAsync(type);
        }

        public Task DeleteAsync(T type)
        {
            if (context.Entry(type).State == EntityState.Detached)
            {
                _dbSet.Attach(type);
            }
            _dbSet.Remove(type);
            return Task.CompletedTask;
        }

        public async Task DeleteAsync(object id)
        {
            T entity = await _dbSet.FindAsync(id);
            await DeleteAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAsync(
            Expression<Func<T, bool>> filter = null,
            string include = "")
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in include.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return query.AsEnumerable();
        }

        public Task UpdateAsync(T type)
        {
            _dbSet.Attach(type);
            context.Entry(type).State = EntityState.Modified;
            return Task.CompletedTask;
        }
    }
}
