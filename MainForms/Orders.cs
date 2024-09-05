using DoorStoreV2.AddForms;
using DoorStoreV2.Classes;
using DoorStoreV2.DeleteForms;
using DoorStoreV2.ReloadForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorStoreV2.MainForms
{
    public partial class Orders : Form, ReloadButton, LoadDataAsync
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        private Task dataLoadTask;
        private Mutex mutex;
        public Orders()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
            mutex = new Mutex();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
            if (dataLoadTask == null || dataLoadTask.IsCompleted)
            {
                dataLoadTask = Task.Run(() => LoadDataAsync());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text;
            DateTime searchDate;
            bool isValidDate = DateTime.TryParseExact(searchQuery, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out searchDate);

            string query = "SELECT orders.order_id, clients.client_fullname, orders.date_order, orders.status_order " +
                "FROM orders INNER JOIN clients ON orders.id_clients = clients.client_id " + 
                "WHERE orders.date_order = @search";
            
            if (isValidDate)
            {
                using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@search", searchDate);
                    DataTable dataTable = new DataTable();

                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable.DefaultView;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.RowHeadersVisible = false;
                }
            }
            
        }
       
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textHelper.ClearText(textBox1);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Performance();
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            AddOrders form = new AddOrders();
            form.ShowDialog();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            DeleteOrders form = new DeleteOrders();
            form.ShowDialog();
        }

        public void Performance()
        {
            string query = "SELECT orders.order_id, clients.client_fullname, orders.date_order, orders.status_order " +
            "FROM orders INNER JOIN clients ON orders.id_clients = clients.client_id";

            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                DataTable dataTable = new DataTable();

                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable.DefaultView;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.RowHeadersVisible = false;
            }

            textBox1.Text = "Поиск по дате";
        }

        public async Task LoadDataAsync()
        {
            if (mutex.WaitOne(0))
            {
                string query = "SELECT orders.order_id, clients.client_fullname, orders.date_order, orders.status_order " +
                "FROM orders INNER JOIN clients ON orders.id_clients = clients.client_id";
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        await dataAdapter.FillAsync(dataTable);

                        dataGridView1.Invoke(new Action(() =>
                        {
                            dataGridView1.DataSource = dataTable.DefaultView;
                            dataGridView1.AllowUserToAddRows = false;
                            dataGridView1.RowHeadersVisible = false;
                        }));
                    }
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
        }

        private void reload_Click(object sender, EventArgs e)
        {
            ReloadStatusOrders form = new ReloadStatusOrders();
            form.ShowDialog();
        }
    }
}
