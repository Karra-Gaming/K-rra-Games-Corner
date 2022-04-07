using KärraGamesCorner.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace KärraGamesCorner
{
    public interface IRepository<T,U> where T : IEntity<U> where U : struct
    {
        Task<bool> CreateAsync(T type);
        Task<bool> DeleteAsync(T type);
        Task UpdateOrCreateAsync(T type);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(U id);
    }
}
