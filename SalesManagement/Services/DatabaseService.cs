using Microsoft.Data.SqlClient;

namespace SalesManagement.Services
{
    public static class DatabaseService
    {
        private static string connection = @"Server=localhost; Database=SalesManagement; User Id=root; Password=root; TrustServerCertificate=True;";

        public static SqlConnection getConnection()
        {
            return new SqlConnection(connection);
        }
    }
}
