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
    public partial class DeleteDoorInOrder : Form
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        public DeleteDoorInOrder()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();  
        }

        private void DeleteDoorInOrder_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM door_in_order WHERE door_in_order_id = @door_in_order_id";
            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                command.Parameters.AddWithValue("@door_in_order_id", Convert.ToInt32(idDoorInOrder.Text));
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Дверь успешно удалена.");
                }
                else
                {
                    MessageBox.Show("Дверь не найдена.");
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            dbConnection.Disconnect();
            this.Close();
        }

        private void idDoorInOrder_DoubleClick(object sender, EventArgs e)
        {
            textHelper.ClearText(idDoorInOrder);
        }
    }
}
