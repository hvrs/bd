using System.Windows.Forms.DataVisualization.Charting;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace olimp
{
    class connectToDatabase
    {
        public string connectionString = @"Data Source=10.111.105.2,1433\SQLEXPRESS;Initial Catalog=pr-20.102k-pg22;User ID=20.102k-10;Password=TrCk6orewq";
       
        public void signin(string login, out string password, out bool isUser)
        {           
            password = "";
            isUser = true;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlexp = $"SELECT password FROM users where login = '{login}'";
                SqlCommand sqlCommand = new SqlCommand(sqlexp, connection);
                password = sqlCommand.ExecuteScalar().ToString();
                connection.Close();

            }
            if (password == "")
            {
                isUser = false;
            }

        }   
    }
}
