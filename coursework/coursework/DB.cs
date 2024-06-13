using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework
{
    internal class DB
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ERV89Q2\\SQLEXPRESS01;Initial Catalog=Trains;User ID=sa;Password=12345; TrustServerCertificate=true");
        public void openConnetion()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnetion()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
