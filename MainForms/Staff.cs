using DoorStoreV2.AddForms;
using DoorStoreV2.Classes;
using DoorStoreV2.DeleteForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorStoreV2.MainForms
{
    public partial class Staff : Form, ReloadButton
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        private Task dataLoadTask;
        private Mutex mutex;
        public Staff()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
            mutex = new Mutex();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
            if (dataLoadTask == null || dataLoadTask.IsCompleted)
            {
                dataLoadTask = Task.Run(() => LoadDataAsync());
            }
        }

        private void search_Enter(object sender, EventArgs e)
        {
            textHelper.ClearText(search);
        }

        public void Performance()
        {
            string query = "SELECT * FROM staff";

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
                string query = "SELECT * FROM staff";
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

        private void reloadForm_Click(object sender, EventArgs e)
        {
            Performance();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "%" + search.Text + "%";

            string query = "SELECT * FROM staff WHERE staff_name LIKE @search OR staff_name = @searchName OR job_title = @jobTitleSearch";

            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                command.Parameters.AddWithValue("@search", searchQuery);
                command.Parameters.AddWithValue("@searchName", search.Text);
                command.Parameters.AddWithValue("@jobTitleSearch", search.Text);
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

        private void addStaff_Click(object sender, EventArgs e)
        {
            AddStaff form = new AddStaff();
            form.ShowDialog();
        }

        private void deleteStaff_Click(object sender, EventArgs e)
        {
            DeleteStaff form = new DeleteStaff();
            form.ShowDialog();
        }

    }
}
