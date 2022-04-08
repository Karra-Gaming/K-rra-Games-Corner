namespace KärraGamesCorner.Data.Models
{
    public interface IEntity<T>
    {
        public T Id { get; }
    }
}
