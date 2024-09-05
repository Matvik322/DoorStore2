using DoorStoreV2.Classes;
using DoorStoreV2.MainForms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorStoreV2.ReloadForms
{
    public partial class ReloadStatusOrders : Form, ComboboxLoader
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        private Dictionary<int, string> clients;
        public ReloadStatusOrders()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
            clients = new Dictionary<int, string>();
        }

        private void ReloadStatusOrders_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
            LoadComboBox();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE orders SET status_order = @status_order WHERE date_order = @date_order " +
                    "AND id_clients = @id_clients";

                string dateString = dateOrder.Text;
                string format = "dd.MM.yyyy";
                DateTime dateOrders = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);

                using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.Add("@status_order", MySqlDbType.VarChar).Value = newStatus.Text;
                    command.Parameters.Add("@id_clients", MySqlDbType.Int32).Value = Convert.ToInt32(clientBox.SelectedValue);
                    command.Parameters.Add("@date_order", MySqlDbType.Date).Value = dateOrders;
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Дата поставки успешно изменена.");
                    }
                    else
                    {
                        MessageBox.Show("Ни одна запись не была изменена.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
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
                    clientBox.DataSource = new BindingSource(clients, null);
                    clientBox.DisplayMember = "Value";
                    clientBox.ValueMember = "Key";
                }
            }
            clientBox.Text = "Клиент";
        }

        private void dateOrder_DoubleClick(object sender, EventArgs e)
        {
            textHelper.ClearText(dateOrder);
        }

        private void newStatus_Enter(object sender, EventArgs e)
        {
            textHelper.ClearText(newStatus);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            dbConnection.Disconnect();
            this.Close();
        }
    }
}
