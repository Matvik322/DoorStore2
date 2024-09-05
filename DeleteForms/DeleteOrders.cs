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
    public partial class DeleteOrders : Form
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        public DeleteOrders()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
        }

        private void DeleteOrders_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
        }

        private void idOrder_DoubleClick(object sender, EventArgs e)
        {
            textHelper.ClearText(idOrder);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM orders WHERE order_id = @order_id";
            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                command.Parameters.AddWithValue("order_id", Convert.ToInt32(idOrder.Text));
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Заказ успешно удален.");
                }
                else
                {
                    MessageBox.Show("Заказ не найден.");
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
