using System.Data.SqlClient;

namespace SemgrepTestProject.Services
{
    public class DatabaseService
    {
        private string connectionString = "Server=myServer;Database=myDB;User Id=myUser;Password=myPassword;";

        public bool IsUserExists(string username)
        {
            // 🚨 SQL Injection Vulnerability
            string query = "SELECT COUNT(*) FROM Users WHERE Username = '" + username + "'";
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
