using DoorStoreV2.AddForms;
using DoorStoreV2.Classes;
using DoorStoreV2.DeleteForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorStoreV2.MainForms
{
    public partial class DoorsInOrder : Form, ReloadButton, LoadDataAsync
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        private Task dataLoadTask;
        private Mutex mutex;
        public DoorsInOrder()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
            mutex = new Mutex();
        }

        private void DoorsInOrder_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
            if (dataLoadTask == null || dataLoadTask.IsCompleted)
            {
                dataLoadTask = Task.Run(() => LoadDataAsync());
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "%" + search.Text + "%";

            string query = "SELECT door_in_order.door_in_order_id, door_in_order.id_orders, door.name_door, door_in_order.door_count " +
                "FROM door_in_order JOIN door ON door_in_order.id_door = door.door_id " +
                "WHERE door.name_door LIKE @search OR door.name_door = @searchFull ";

            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                command.Parameters.AddWithValue("@search", searchQuery);
                command.Parameters.AddWithValue("@searchFull", search.Text);
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

        private void search_Enter(object sender, EventArgs e)
        {
            textHelper.ClearText(search);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
           Performance();
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            AddDoorInOrder form = new AddDoorInOrder();
            form.ShowDialog();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            DeleteDoorInOrder form = new DeleteDoorInOrder();
            form.ShowDialog();
        }

        public void Performance()
        {
            string query = "SELECT door_in_order.door_in_order_id, door_in_order.id_orders, door.name_door, door_in_order.door_count " +
                "FROM door_in_order JOIN door ON door_in_order.id_door = door.door_id ";

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
            search.Text = "Поиск";
        }

        public async Task LoadDataAsync()
        {
            if (mutex.WaitOne(0))
            {
                string query = "SELECT door_in_order.door_in_order_id, door_in_order.id_orders, door.name_door, door_in_order.door_count " +
                "FROM door_in_order JOIN door ON door_in_order.id_door = door.door_id ";
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
    }
}
