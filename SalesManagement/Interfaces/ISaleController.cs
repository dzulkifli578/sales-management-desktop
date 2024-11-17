namespace SalesManagement.Interfaces
{
    public interface ISaleController
    {
        Task<ComboBox> loadProducts();
        DataGridView AddToCart();
        Task Checkout();
    }
}
