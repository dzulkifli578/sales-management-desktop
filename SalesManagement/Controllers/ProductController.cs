using Microsoft.Data.SqlClient;
using SalesManagement.Services;
using System.Data;

namespace SalesManagement.Controllers
{
    public class ProductController
    {
        private static TextBox textBoxProductName = new();
        private static NumericUpDown numericUpDownPrice = new();
        private static NumericUpDown numericUpDownStock = new();

        public ProductController(TextBox name, NumericUpDown price, NumericUpDown stock)
        {
            textBoxProductName = name;
            numericUpDownPrice = price;
            numericUpDownStock = stock;
        }
        public async Task AddProduct()
        {
            validateInputs();

            try
            {
                using (var connection = DatabaseService.getConnection())
                {
                    await connection.OpenAsync();
                    var query = "EXEC AddProduct @name, @price, @stock";
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", textBoxProductName.Text);
                    command.Parameters.AddWithValue("@price", numericUpDownPrice.Value);
                    command.Parameters.AddWithValue("@stock", numericUpDownStock.Value);
                    await command.ExecuteNonQueryAsync();
                    clearInputs();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to add product {ex}.");
            }
        }

        public async Task UpdateProduct(int? id)
        {
            if (id <= 0 || id == null) throw new Exception("ID cannot be null or less than 1.");
            validateInputs();

            try
            {
                using (var connection = DatabaseService.getConnection())
                {
                    await connection.OpenAsync();
                    var query = "EXEC UpdateProduct @id, @name, @price, @stock";
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", textBoxProductName.Text);
                    command.Parameters.AddWithValue("@price", numericUpDownPrice.Value);
                    command.Parameters.AddWithValue("@stock", numericUpDownStock.Value);
                    await command.ExecuteNonQueryAsync();
                    clearInputs();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update product {ex}.");
            }
        }

        public async Task DeleteProduct(int? id)
        {
            if (id <= 0 || id == null) throw new Exception("ID cannot be null or less than 1.");

            try
            {
                using (var connection = DatabaseService.getConnection())
                {
                    await connection.OpenAsync();
                    var query = "EXEC DeleteProduct @id";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        await command.ExecuteNonQueryAsync();
                        clearInputs();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to delete product {ex}.");
            }
        }

        public DataGridView loadProducts(DataGridView product)
        {
            using (var connection = DatabaseService.getConnection())
            {
                connection.Open();

                var query = "EXEC ShowProducts";
                var dataAdapter = new SqlDataAdapter(query, connection);

                var dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                product.DataSource = dataTable;
                product.Columns["ID"].Visible = false;

                return product;
            }
        }

        private static void validateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBoxProductName.Text))
                throw new Exception("Product name cannot be empty!");

            if (numericUpDownPrice.Value <= 0)
                throw new Exception("Product price must be greater than 0!");

            if (numericUpDownStock.Value < 0)
                throw new Exception("Product stock cannot be negative!");
        }

        public void clearInputs()
        {
            textBoxProductName.ResetText();
            numericUpDownPrice.Value = numericUpDownPrice.Minimum;
            numericUpDownStock.Value = numericUpDownStock.Minimum;
        }
    }
}
