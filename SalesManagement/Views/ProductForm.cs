using SalesManagement.Controllers;
using SalesManagement.Models;

namespace SalesManagement.Forms
{
    public partial class ProductForm : Form
    {
        private readonly ProductController controller;
        private static int id = 0;

        public ProductForm()
        {
            InitializeComponent();
            controller = new ProductController(textBoxProductName, numericUpDownPrice, numericUpDownStock);
            loadProducts();
            clearInputs();
        }

        private void loadProducts()
        {
            try
            {
                controller.loadProducts(dataGridViewProduct);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearInputs()
        {
            controller.clearInputs();
        }

        private void dataGridViewProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                id = Convert.ToInt32(dataGridViewProduct.Rows[e.RowIndex].Cells["ID"].Value);
                textBoxProductName.Text = dataGridViewProduct.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                numericUpDownPrice.Text = dataGridViewProduct.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                numericUpDownStock.Text = dataGridViewProduct.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
            }
        }

        private void labelProductName_Click(object sender, EventArgs e)
        {
            textBoxProductName.Focus();
        }

        private void labelPrice_Click(object sender, EventArgs e)
        {
            numericUpDownPrice.Focus();
        }

        private void labelStock_Click(object sender, EventArgs e)
        {
            numericUpDownStock.Focus();
        }

        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var main = new MainForm();
            main.Show();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Name = textBoxProductName.Text,
                Price = Convert.ToDecimal(numericUpDownPrice.Value),
                Stock = Convert.ToInt32(numericUpDownStock.Value)
            };

            try
            {
                await controller.AddProduct();
                MessageBox.Show("Product added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                await controller.UpdateProduct(id);
                MessageBox.Show("Product edited successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                await controller.DeleteProduct(id);
                MessageBox.Show("Product deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
