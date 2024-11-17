using SalesManagement.Controllers;
namespace SalesManagement.Views
{
    public partial class SalesForm : Form
    {
        private readonly SaleController controller;

        public SalesForm()
        {
            InitializeComponent();
            controller = new SaleController(dataGridViewSales, comboBoxProduct, numericUpDownQuantity);
            loadProducts();
            clearInputs();
        }

        private async void loadProducts()
        {
            try
            {
                await controller.loadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearInputs()
        {
            controller.ClearInputs();
        }

        private void labelProduct_Click(object sender, EventArgs e)
        {
            comboBoxProduct.Focus();
        }

        private void labelQuantity_Click(object sender, EventArgs e)
        {
            numericUpDownQuantity.Focus();
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            try
            {
                controller.AddToCart();
                MessageBox.Show("Item added to cart successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                await controller.Checkout();
                MessageBox.Show("Item checkout successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var main = new MainForm();
            main.Show();
        }

        private void SalesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.ConfirmationToClose(sender, e);
        }
    }
}
