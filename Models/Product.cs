namespace StorageApi.Models
{
    public class Product
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = null!;
        public int Price { get; set; } = 0;
        public string Category { get; set; } = null!;
        public string Shelf { get; set; } = null!;
        public int Count { get; set; } = 0;
        public string Description { get; set; } = null!;
    }
}
