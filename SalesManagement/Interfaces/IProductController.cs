namespace SalesManagement.Interfaces
{
    public interface IProductController
    {
        Task AddProduct(string name, decimal price, int stock);
        Task UpdateProduct(int id, string name, decimal price, int stock);
        Task DeleteProduct(int id);
    }
}
