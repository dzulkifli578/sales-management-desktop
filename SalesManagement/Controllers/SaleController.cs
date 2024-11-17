using Microsoft.Data.SqlClient;
using SalesManagement.Interfaces;
using SalesManagement.Models;
using SalesManagement.Services;

namespace SalesManagement.Controllers
{
    public class SaleController : ISaleController
    {
        private static ComboBox comboBoxProduct = new();
        private static DataGridView dataGridViewSales = new();
        private static NumericUpDown numericUpDownQuantity = new();
        private static List<Product> products = [];
        private static List<SaleDetail> cart = [];

        public SaleController(DataGridView sales, ComboBox products, NumericUpDown quantity)
        {
            comboBoxProduct = products;
            dataGridViewSales = sales;
            numericUpDownQuantity = quantity;
        }

        public async Task<ComboBox> loadProducts()
        {
            using (var connection = DatabaseService.getConnection())
            {
                await connection.OpenAsync();
                var query = "EXEC ShowProducts";
                var command = new SqlCommand(query, connection);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    products.Clear();
                    while (await reader.ReadAsync())
                    {
                        products.Add(new Product
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Name = Convert.ToString(reader["Name"])!,
                            Price = Convert.ToDecimal(reader["Price"]),
                            Stock = Convert.ToInt32(reader["Stock"]),
                        });
                    }

                    if (products.Count <= 0)
                        throw new Exception("No products found in the database.");

                    comboBoxProduct.DataSource = products;
                    comboBoxProduct.DisplayMember = "Name";
                    comboBoxProduct.ValueMember = "ID";

                    return comboBoxProduct;
                }
            }
        }

        public DataGridView AddToCart()
        {
            var selectedProduct = comboBoxProduct.SelectedItem as Product;
            int quantity = Convert.ToInt32(numericUpDownQuantity.Value);

            if (selectedProduct == null)
                throw new Exception("Product not selected.");

            if (quantity > selectedProduct.Stock)
                throw new Exception($"Insufficient stock! Available stock: {selectedProduct.Stock}");

            selectedProduct.Stock -= quantity;
            decimal subtotal = selectedProduct.Price * quantity;

            cart.Add(new SaleDetail
            {
                ProductID = selectedProduct.ID,
                ProductName = selectedProduct.Name,
                Quantity = quantity,
                SubTotal = subtotal,
            });

            dataGridViewSales.DataSource = null;
            dataGridViewSales.DataSource = cart;
            ClearInputs();

            return dataGridViewSales;
        }

        public async Task Checkout()
        {
            using (var connection = DatabaseService.getConnection())
            {
                await connection.OpenAsync();
                var transaction = connection.BeginTransaction();

                try
                {
                    var querySale = "INSERT INTO Sales (TotalAmount) OUTPUT INSERTED.SaleID VALUES (@total)";
                    var commandSale = new SqlCommand(querySale, connection, transaction);
                    commandSale.Parameters.AddWithValue("@total", cart.Sum(c => c.SubTotal));
                    int saleID = Convert.ToInt32(await commandSale.ExecuteScalarAsync());

                    foreach (var item in cart)
                    {
                        var queryDetail = "INSERT INTO SalesDetails (SaleID, ProductID, Quantity, SubTotal) VALUES (@saleID, @productID, @quantity, @subtotal)";
                        var commandDetail = new SqlCommand(queryDetail, connection, transaction);
                        commandDetail.Parameters.AddWithValue("@saleID", saleID);
                        commandDetail.Parameters.AddWithValue("@productID", item.ProductID);
                        commandDetail.Parameters.AddWithValue("@quantity", item.Quantity);
                        commandDetail.Parameters.AddWithValue("@subtotal", item.SubTotal);
                        await commandDetail.ExecuteNonQueryAsync();
                    };

                    transaction.Commit();
                    cart.Clear();
                    dataGridViewSales.DataSource = null;
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception($"Transaction failed: {ex}");
                }
            }
        }

        public void ClearInputs()
        {
            comboBoxProduct.ResetText();
            numericUpDownQuantity.Value = numericUpDownQuantity.Minimum;
        }

        public void ConfirmationToClose(object sender, FormClosingEventArgs e)
        {
            if (cart.Any())
            {
                var result = MessageBox.Show("There are still items in the cart, are you sure you want to close them?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
