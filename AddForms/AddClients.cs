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
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace DoorStoreV2.AddForms
{
    public partial class AddClients : Form
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        public AddClients()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
        }
        private void AddClients_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
        }
        private void name_DoubleClick(object sender, EventArgs e)
        {
            textHelper.ClearText(name);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textHelper.ClearText(textBox1);
        }

        private void save_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO clients (client_name, contact_information) " +
               "VALUES (@client_name, @contact_information)";

            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                command.Parameters.AddWithValue("@client_name", name.Text);
                command.Parameters.AddWithValue("@contact_information", textBox1.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("Клиент успешно добавлен!");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            dbConnection.Disconnect();
            this.Close();
        }
    }
}
