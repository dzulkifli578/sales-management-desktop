using SalesManagement.Controllers;

namespace SalesManagement.Views
{
    public partial class ReportForm : Form
    {
        private readonly ReportController controller;

        public ReportForm()
        {
            InitializeComponent();
            controller = new ReportController(dataGridViewReport);
            loadReports();
        }

        private async void loadReports()
        {
            await controller.LoadReports();
        }

        private void ReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var main = new MainForm();
            main.Show();
        }
    }
}
