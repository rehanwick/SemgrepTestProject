using system.data.sqlclient;

namespace semgreptestproject.services
{
    public class databaseservice
    {
        private string connectionstring = "server=myserver;database=mydb;user id=myuser;password=mypassword;";

        public bool isuserexists(string username)
        {

            string query = "select count(*) from users where username = '" + username + "'";

            using (sqlconnection conn = new sqlconnection(connectionstring))
            {
                sqlcommand cmd = new sqlcommand(query, conn);
                conn.open();
                int count = (int)cmd.executescalar();
                return count > 0;
            }
        }
    }
}
