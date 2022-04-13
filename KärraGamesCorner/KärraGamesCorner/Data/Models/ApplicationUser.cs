using KärraGamesCorner.Attributes;
using Microsoft.AspNetCore.Identity;

namespace KärraGamesCorner.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? ImageUrl { get; set; } = string.Empty;
        [Include]
        public ICollection<CartProduct> CartProducts { get; set; }
        public ICollection<Token> PurchasedTokens { get; set; }
        public ICollection<Order> Orders { get; set; }

        public ApplicationUser()
        {
            CartProducts = new List<CartProduct>();
            PurchasedTokens = new List<Token>();
            Orders = new List<Order>();
        }


    }
}
