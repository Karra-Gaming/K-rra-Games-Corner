namespace KärraGamesCorner.Data.Models
{
    public class Token
    {
  
        public int Id { get; set; }
        public Guid GameToken  { get; set; }

        //Varje token måste ha en user
        public ApplicationUser? ApplicationUser { get; set; }
        //Varje token måste vara kopplad till en produkt
        public Product Product { get; set; }

        public Token()
        {
            
        }
        public Token(int id, ApplicationUser applicationUser, Product product)
        {
            Id = id;
            GameToken = Guid.NewGuid(); 
            ApplicationUser = applicationUser;
            Product = product;

        }


    }
}