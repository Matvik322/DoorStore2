using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorStoreV2.Classes
{
    public class DbConnectionClass
    {
        private readonly string connectionString;
        public MySqlConnection connection { get; private set; }

        public DbConnectionClass(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Connect()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
        }
    }
}
