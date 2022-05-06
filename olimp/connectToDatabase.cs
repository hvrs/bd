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
        public void addEmployes(string surname, string name, string lastname, string numphon, string bank, string salary, string sex, string passpd, string INN, string dolj )
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlExpression = $"INSERT INTO Сотрудники (Фамилия, Имя, Отчество) VALUES ('{surname}', '{name}', '{lastname}')";
                string sqlExpression2 = $"INSERT INTO [Информация о сотрудниках] ([Номер телефона],[Банковский счет],[Заработная плата], Пол, [Паспортные данные], ИНН, Должность) VALUES ({numphon}, {bank}, {salary}, '{sex}', {passpd}, {INN}, '{dolj}')";
                SqlCommand sqlCommand1 = new SqlCommand(sqlExpression, connection);
                SqlCommand sqlCommand2 = new SqlCommand(sqlExpression2, connection);
                sqlCommand1.ExecuteNonQuery();
                sqlCommand2.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void addClients(string surname, string name, string lastname, string numphon, string numkard)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlExpression = $"INSERT INTO Клиенты (Фамилия, Имя, Отчество) VALUES ('{surname}', '{name}', '{lastname}')";
                string sqlExpression2 = $"INSERT INTO [Информация о клиентах] ([Номер телефона],[Номер бонусной карты], [Табельный номер]) VALUES ('{numphon}', '{numkard}', 1)";
                SqlCommand sqlCommand1 = new SqlCommand(sqlExpression, connection);
                SqlCommand sqlCommand2 = new SqlCommand(sqlExpression2, connection);
                sqlCommand1.ExecuteNonQuery();
                sqlCommand2.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
