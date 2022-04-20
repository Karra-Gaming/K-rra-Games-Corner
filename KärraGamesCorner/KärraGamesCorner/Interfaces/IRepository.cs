using KärraGamesCorner.Data;
using KärraGamesCorner.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq.Expressions;

namespace KärraGamesCorner
{
    public interface IRepository<T> where T : class
    {
       
        Task CreateAsync(T type);
        Task DeleteAsync(T type);
        Task DeleteAsync(object id);
        Task UpdateAsync(T type);
        Task<IEnumerable<T>> GetAsync(
            Expression<Func<T, bool>> filter = null,
            string include = "");
    }
}
