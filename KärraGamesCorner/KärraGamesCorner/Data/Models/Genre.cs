namespace KärraGamesCorner.Data.Models
{
    public class Genre : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}