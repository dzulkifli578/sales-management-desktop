using SalesManagement.Forms;
using SalesManagement.Views;

namespace SalesManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            Hide();
            var product = new ProductForm();
            product.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var product = new ProductForm();
            product.Show();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var sales = new SalesForm();
            sales.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var report = new ReportForm();
            report.Show();
        }
    }
}
