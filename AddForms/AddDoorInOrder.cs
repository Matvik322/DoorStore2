using DoorStoreV2.Classes;
using DoorStoreV2.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace DoorStoreV2.AddForms
{
    public partial class AddDoorInOrder : Form, ComboboxLoader
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        private List<int> orders;
        private Dictionary<int, string> doors;
        public AddDoorInOrder()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
            orders = new List<int>();
            doors = new Dictionary<int, string>();
        }
        private void AddDoorInOrder_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
            LoadComboBox();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textHelper.ClearText(count);
        }

        private void save_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO door_in_order (id_orders, id_door, door_count) " +
               "VALUES (@id_orders, @id_door, @door_count)";

            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                command.Parameters.AddWithValue("@id_orders", Convert.ToInt32(order.SelectedValue));
                command.Parameters.AddWithValue("@id_door", Convert.ToInt32(door.SelectedValue));
                command.Parameters.AddWithValue("@door_count", Convert.ToInt32(count.Text));

                command.ExecuteNonQuery();
                MessageBox.Show("Дверь успешно добавлена!");

                string updateQuery = $@"UPDATE door 
                        INNER JOIN door_in_order ON door.door_id = door_in_order.id_door 
                        SET door.count_door_in_stock = door.count_door_in_stock - {Convert.ToInt32(count.Text)}
                        WHERE door.door_id = {Convert.ToInt32(door.SelectedValue)}";

                using (MySqlCommand commandUpdate = new MySqlCommand(updateQuery, dbConnection.connection))
                {
                    commandUpdate.ExecuteNonQuery();
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            dbConnection.Disconnect();
            this.Close();
        }

        public void LoadComboBox()
        {
            int firstCountColumn = 0;
            int secondCountColumn = 3;

            string queryOrders = "SELECT * FROM orders ORDER BY order_id DESC";
            using (MySqlCommand commandOrders = new MySqlCommand(queryOrders, dbConnection.connection))
            {
                using (MySqlDataReader readerOrders = commandOrders.ExecuteReader())
                {
                    while (readerOrders.Read())
                    {
                        int ordersId = readerOrders.GetInt32(firstCountColumn);
                        orders.Add(ordersId);
                    }
                    order.DataSource = new BindingSource(orders, null);
                }
            }

            string queryDoors = "SELECT * FROM door ORDER BY door_id DESC";
            using (MySqlCommand commandDoors = new MySqlCommand(queryDoors, dbConnection.connection))
            {
                using (MySqlDataReader readerDoors = commandDoors.ExecuteReader())
                {
                    while (readerDoors.Read())
                    {
                        int doorsId = readerDoors.GetInt32(firstCountColumn);
                        string doorsName = readerDoors.GetString(secondCountColumn);
                        doors.Add(doorsId, doorsName);
                    }
                    door.DataSource = new BindingSource(doors, null);
                    door.DisplayMember = "Value";
                    door.ValueMember = "Key";
                }
            }

            door.Text = "Дверь";
            order.Text = "Заказ";
        }
    }
}
