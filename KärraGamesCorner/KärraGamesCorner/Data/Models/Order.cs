using System.ComponentModel.DataAnnotations.Schema;

namespace KärraGamesCorner.Data.Models
{
    public class Order 
    {
        public int Id { get; set; }
        //En order kan bara ha en user
        public ApplicationUser User { get; set; }
        //Så kan man göra en if-sats som sållar
        public ICollection<CartProduct> Products { get; set; }
        public DateTime OrderOfDate { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal TotalPrice { get; set; }
        public string Address { get; set; } = string.Empty;

        public Order()
        {
           
            GetTotalPrice();
        }

        public void GetTotalPrice()
        {
            if (Products != null)
            {
                var cartProducts = Products.ToList();
                foreach (var product in cartProducts)
                {
                    TotalPrice += product.Product.Price * product.Amount;
                }
               
            }
           

        }
    }
}
