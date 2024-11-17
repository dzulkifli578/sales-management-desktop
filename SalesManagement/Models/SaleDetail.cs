namespace SalesManagement.Models
{
    public class SaleDetail
    {
        public int ID { get; set; }
        public required int ProductID { get; set; }
        public required string ProductName { get; set; }
        public required int Quantity { get; set; }
        public required decimal SubTotal { get; set; }
    }
}
