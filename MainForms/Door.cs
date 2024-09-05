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
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace DoorStoreV2
{
    public partial class Door : Form, ReloadButton, LoadDataAsync
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        private Task dataLoadTask;
        private Mutex mutex;
        public Door()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
            mutex = new Mutex();
        }

        private void Door_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
            if (dataLoadTask == null || dataLoadTask.IsCompleted)
            {
                dataLoadTask = Task.Run(() => LoadDataAsync());
            }
        }
        private void Door_Leave(object sender, EventArgs e)
        {
            dbConnection.Disconnect();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Performance();
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            AddDoor form = new AddDoor();
            form.ShowDialog();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            DeleteDoor form = new DeleteDoor();
            form.ShowDialog();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            SelectReloadDoor form = new SelectReloadDoor();
            form.ShowDialog();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "%" + search.Text + "%";

            string query = "SELECT door.door_id, manufacturers.name_manufacturers, type_doors.name_type_doors, door.name_door, door.door_material, " +
            "door.size_door, door.price, door.count_door_in_stock, door.date_buy " +
            "FROM door JOIN manufacturers ON door.id_manufacturers = manufacturers.manufacturers_id " +
            "JOIN type_doors ON type_doors.type_doors_id = door.id_type_doors " +
            "WHERE type_doors.name_type_doors LIKE @search " +
            "OR type_doors.name_type_doors = @searchFull " +
            "OR manufacturers.name_manufacturers LIKE @search " +
            "OR manufacturers.name_manufacturers = @searchFull " +
            "OR door.name_door LIKE @search " +
            "OR door.name_door = @searchFull " +
            "OR door.door_material LIKE @search " +
            "OR door.door_material = @searchFull";

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

        public void Performance()
        {
            string query = "SELECT door.door_id, manufacturers.name_manufacturers, type_doors.name_type_doors, door.name_door, " +
                    "door.door_material,door.size_door, door.price, door.count_door_in_stock, door.date_buy " +
                    "FROM door JOIN manufacturers ON door.id_manufacturers = manufacturers.manufacturers_id " +
                    "JOIN type_doors ON type_doors.type_doors_id = door.id_type_doors " +
                    "ORDER BY door.door_id ";

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
                string query = "SELECT door.door_id, manufacturers.name_manufacturers, type_doors.name_type_doors, door.name_door, " +
                    "door.door_material,door.size_door, door.price, door.count_door_in_stock, door.date_buy " +
                    "FROM door JOIN manufacturers ON door.id_manufacturers = manufacturers.manufacturers_id " +
                    "JOIN type_doors ON type_doors.type_doors_id = door.id_type_doors " +
                    "ORDER BY door.door_id ";
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
