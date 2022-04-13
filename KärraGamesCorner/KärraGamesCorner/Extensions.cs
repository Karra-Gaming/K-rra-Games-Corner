using KärraGamesCorner.Attributes;
using KärraGamesCorner.Data.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace KärraGamesCorner
{
    public static class Extensions
    {
        public static IQueryable<object> IncludeCartProducts(this IQueryable<object> queryable)
        {
            Type type = typeof(ApplicationUser);
            var props = type.GetProperties().Where(p => Attribute.IsDefined(p, typeof(IncludeAttribute)));
            queryable = props.Aggregate(queryable, (current, property) => current.Include(property.Name));
            return queryable;
        }
    }
}
