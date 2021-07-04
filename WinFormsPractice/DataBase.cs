using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPractice
{
    class DataBase
    {
        //MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;" +
        //    "username=root;password=root;database=users");
        MySqlConnection connection = new MySqlConnection("server=remotemysql.com;port=3306;" +
           "username=2cUv94ZnyC;password=f7vEfREIDf;database=2cUv94ZnyC");
        public void OpenConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
