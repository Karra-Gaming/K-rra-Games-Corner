namespace KärraGamesCorner.Data.Models
{
    public class User
    {
      
        public int Id { get; set; }
        public string UserName { get; set; } 
        public string  Email { get; set; } 
        public string  Password { get; set; } 
        public string  ImageUrl { get; set; } = string.Empty;
        public bool IsAdmin { get; set; }
        public string PhoneNumber { get; set; }
        public List<Product> Cart { get; set; }
        public List<Token> PurchasedTokens { get; set; }

        public User(int id, string userName, string email, string password, 
             string phoneNumber)
        {
            Id = id;
            UserName = userName;
            Email = email;
            Password = password;           
            PhoneNumber = phoneNumber;
            Cart = new List<Product>();
            PurchasedTokens = new List<Token>();
        }


    }
}
