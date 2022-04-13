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

        public Order()
        {
            Products = User.CartProducts;
        }
    }
}
