using KärraGamesCorner.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace KärraGamesCorner.Data
{
    public interface IRepository<T,U> where T : IEntity<U> where U : struct
    {
        Task<bool> CreateAsync(T type);
        Task<bool> DeleteAsync(U id);
        Task UpdateAsync();
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(Guid guid);
    }
}
