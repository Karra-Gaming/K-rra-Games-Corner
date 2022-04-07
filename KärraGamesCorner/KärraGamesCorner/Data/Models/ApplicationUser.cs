using Microsoft.AspNetCore.Identity;

namespace KärraGamesCorner.Data.Models
{
    public class ApplicationUser : IdentityUser, IEntity<Guid>
    {
        public new Guid Id => Guid.Parse(base.Id);
        public string? ImageUrl { get; set; } = string.Empty;
        public IEnumerable<Product> Cart { get; set; }
        public IEnumerable<Token> PurchasedTokens { get; set; }

        public ApplicationUser()
        {
            Cart = new List<Product>();
            PurchasedTokens = new List<Token>();
        }


    }
}
