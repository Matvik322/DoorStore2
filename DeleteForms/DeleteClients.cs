using DoorStoreV2.AddForms;
using DoorStoreV2.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorStoreV2.DeleteForms
{
    public partial class DeleteClients : Form
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        public DeleteClients()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
        }
        private void DeleteClients_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
        }
        private void idClient_DoubleClick(object sender, EventArgs e)
        {
            textHelper.ClearText(idClient);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM clients WHERE client_id = @client_id";
            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                command.Parameters.AddWithValue("@client_id", Convert.ToInt32(idClient));
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Клиент успешно удален.");
                }
                else
                {
                    MessageBox.Show("Клиент не найден.");
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            dbConnection.Disconnect();
            this.Close();
        }
    }
}
