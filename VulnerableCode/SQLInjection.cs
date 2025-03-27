using System.Data.SqlClient;

namespace SemgrepTestProject.VulnerableCode
{
    public class SQLInjection
    {
        public bool CheckLogin(string username, string password)
        {
            // 🚨 SQL Injection
            string sql = $"SELECT * FROM Users WHERE Username = '{username}' AND Password = '{password}'";

            using (SqlConnection conn = new SqlConnection("Server=myServer;Database=myDB;User Id=myUser;Password=myPassword;"))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                return reader.HasRows;
            }
        }
    }
}
