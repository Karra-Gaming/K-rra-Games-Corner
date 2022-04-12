using Microsoft.AspNetCore.Identity;

namespace KärraGamesCorner.Data.Models
{
    public class ApplicationUser : IdentityUser, IEntity<Guid>
    {
        public new Guid Id
        {
            get => Guid.Parse(base.Id);
            set => base.Id = value.ToString();
        }
        public string? ImageUrl { get; set; } = string.Empty;
        public ICollection<CartProduct> CartProducts { get; set; }
        public ICollection<Token> PurchasedTokens { get; set; }

        public ApplicationUser()
        {
            CartProducts = new List<CartProduct>();
            PurchasedTokens = new List<Token>();
        }


    }
}
