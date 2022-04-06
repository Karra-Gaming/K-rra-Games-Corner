namespace KärraGamesCorner.Data.Models
{
    public class Token
    {
  
        public int Id { get; set; }
        public Guid GameToken  { get; set; }

        //varje token måste ha en user
        public ApplicationUser? ApplicationUser { get; set; }

        public Token(int id, ApplicationUser applicationUser)
        {
            Id = id;
            GameToken = Guid.NewGuid(); 
            ApplicationUser = applicationUser;
        }


    }
}