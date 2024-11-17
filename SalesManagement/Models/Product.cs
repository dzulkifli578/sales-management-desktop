namespace SalesManagement.Models
{
    public class Product
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public required decimal Price { get; set; }
        public required int Stock { get; set; }
    }
}
