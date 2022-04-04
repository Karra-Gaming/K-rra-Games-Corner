namespace KärraGamesCorner.Data.Models
{
    public class Token
    {
  
        public int Id { get; set; }
        public Guid GameToken  { get; set; }

        //varje token måste ha en user
        public User? User { get; set; }

        public Token(int id, User user)
        {
            Id = id;
            GameToken = Guid.NewGuid(); 
            User = user;
        }


    }
}