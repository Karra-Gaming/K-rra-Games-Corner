namespace KärraGamesCorner.Data.Models
{
    public class Genre : IEntity<int>
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get; set; }
    }
}