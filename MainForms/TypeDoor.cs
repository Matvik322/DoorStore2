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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DoorStoreV2
{
    public partial class TypeDoor : Form, ReloadButton, LoadDataAsync
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        private Task dataLoadTask;
        private Mutex mutex;
        public TypeDoor()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
            mutex = new Mutex();
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
            AddTypeDoor form = new AddTypeDoor();
            form.ShowDialog();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            DeleteTypeDoor form = new DeleteTypeDoor();
            form.ShowDialog();
        }

        private void TypeDoor_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
            if (dataLoadTask == null || dataLoadTask.IsCompleted)
            {
                dataLoadTask = Task.Run(() => LoadDataAsync());
            }
        }

        private void TypeDoor_Leave(object sender, EventArgs e)
        {
            dbConnection.Disconnect();
        }

        public void Performance()
        {
            string query = "SELECT * FROM type_doors";

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

        private void search_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "%" + search.Text + "%";

            string query = "SELECT * FROM type_doors WHERE name_type_doors LIKE @search OR name_type_doors = @searchFull ";

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

        public async Task LoadDataAsync()
        {
            if (mutex.WaitOne(0))
            {
                string query = "SELECT * FROM type_doors";
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
