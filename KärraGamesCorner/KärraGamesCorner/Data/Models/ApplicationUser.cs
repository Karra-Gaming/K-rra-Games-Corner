using Microsoft.AspNetCore.Identity;

namespace KärraGamesCorner.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        
        public string  ImageUrl { get; set; } = string.Empty;
        public bool IsAdmin { get; set; }
        public List<Product> Cart { get; set; }
        public List<Token> PurchasedTokens { get; set; }

        public ApplicationUser()
        {
           
            Cart = new List<Product>();
            PurchasedTokens = new List<Token>();
        }


    }
}
