namespace KärraGamesCorner.Data.Models
{
    public class Product
    {
        

        public int Id { get; set; }
        public string Name { get; set; } 

        public string Description { get; set; } 

        public decimal Price { get; set; }

        public Genre? Genre { get; set; }
        public int GenreId { get; set; }

        public string ImageUrl { get; set; } 

        public string Producer { get; set; }

        //måste ha för att kunna skapa junction table för cart
        public List<User> UserCart { get; set; }
        public Product(int id, string name, string description, decimal price, Genre? genre, int genreId, string imageUrl, string producer)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Genre = genre;
            GenreId = genreId;
            ImageUrl = imageUrl;
            Producer = producer;

            UserCart = new List<User>();


        }


    }
}
