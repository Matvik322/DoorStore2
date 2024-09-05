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
using System.Globalization;
using MySql.Data.MySqlClient;

namespace DoorStoreV2.AddForms
{
    public partial class AddOrders : Form, ComboboxLoader
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        private Dictionary<int, string> clients;
        public AddOrders()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
            clients = new Dictionary<int, string>();
        }

        private void AddOrders_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
            LoadComboBox();
        }

        private void dateOrder_DoubleClick(object sender, EventArgs e)
        {
            textHelper.ClearText(dateOrder);
        }

        private void status_Enter(object sender, EventArgs e)
        {
            textHelper.ClearText(status);
        }

        private void save_Click(object sender, EventArgs e)
        {
            string dateString = dateOrder.Text;
            string format = "dd.MM.yyyy";
            DateTime dateOrders = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);

            string query = "INSERT INTO orders (id_clients, date_order, status_order) " +
               "VALUES (@id_clients, @date_order, @status_order)";

            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                command.Parameters.AddWithValue("@id_clients", Convert.ToInt32(client.SelectedValue));
                command.Parameters.AddWithValue("@date_order", dateOrders);
                command.Parameters.AddWithValue("@status_order", status.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Заказ успешно добавлен!");
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
            int secondCountColumn = 1;

            string queryClients = "SELECT * FROM clients ORDER BY clients.client_id DESC";
            using (MySqlCommand commandClients = new MySqlCommand(queryClients, dbConnection.connection))
            {
                using (MySqlDataReader readerClients = commandClients.ExecuteReader())
                {
                    while (readerClients.Read())
                    {
                        int clientsId = readerClients.GetInt32(firstCountColumn);
                        string clientsName = readerClients.GetString(secondCountColumn);
                        clients.Add(clientsId, clientsName);
                    }
                    client.DataSource = new BindingSource(clients, null);
                    client.DisplayMember = "Value";
                    client.ValueMember = "Key";
                }
            }
            client.Text = "Клиент";
        }
    }
}
