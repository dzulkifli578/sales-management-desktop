using Microsoft.Data.SqlClient;
using SalesManagement.Services;
using System.Data;

namespace SalesManagement.Controllers
{
    public class ReportController
    {
        private static DataGridView dataGridViewReport = new();

        public ReportController(DataGridView report)
        {
            dataGridViewReport = report;
        }

        public async Task LoadReports()
        {
            using (var connection = DatabaseService.getConnection())
            {
                await connection.OpenAsync();
                var query = "EXEC ShowSales";
                var command = new SqlCommand(query, connection);

                var adapter = new SqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewReport.DataSource = dataTable;
                dataGridViewReport.Columns["ID"].Visible = false;

                if (dataTable.Rows.Count <= 0)
                    throw new Exception("Report is not available.");
            }
        }
    }
}
