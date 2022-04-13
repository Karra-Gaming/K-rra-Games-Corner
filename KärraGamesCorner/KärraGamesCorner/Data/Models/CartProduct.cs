using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KärraGamesCorner.Data.Models
{
    public class CartProduct 
    {
        
        public ApplicationUser User { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public string ApplicationUserId { get => User.Id;
            set => User.Id = value;
        }

        public int ProductId
        {
            get => Product.Id;
            set => Product.Id = value;

        }

        public CartProduct()
        {

        }


    }
}
