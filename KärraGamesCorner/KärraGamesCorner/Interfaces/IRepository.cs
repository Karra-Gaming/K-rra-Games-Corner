using KärraGamesCorner.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace KärraGamesCorner
{
    public interface IRepository<T> where T : class
    {
        Task<bool> CreateAsync(T type);
        Task<bool> DeleteAsync(params object[] keys);
        Task UpdateAsync(params object[] keys);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(params object[] keys);
    }
}
