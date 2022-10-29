using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=document");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        public void cleardate()
        {
            MySqlCommand command = new MySqlCommand("TRUNCATE TABLE `documents`", GetConnection());
            MySqlCommand command1 = new MySqlCommand("TRUNCATE TABLE `documentitems`", GetConnection());
            openConnection();
            if (command.ExecuteNonQuery() == 0 && command1.ExecuteNonQuery()==0)
            {
            }
            closeConnection();
            
        }
    }
}
