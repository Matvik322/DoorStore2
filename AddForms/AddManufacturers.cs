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

namespace DoorStoreV2.AddForms
{
    public partial class AddManufacturers : Form
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        public AddManufacturers()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
        }
        private void AddManufacturers_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            textHelper.ClearText(textBox2);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textHelper.ClearText(textBox1);
        }

        private void save_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO manufacturers (name_manufacturers, contact_information) " +
               "VALUES (@name_manufacturers, @contact_information)";

            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                command.Parameters.AddWithValue("@name_manufacturers", textBox2.Text);
                command.Parameters.AddWithValue("@contact_information", textBox1.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Производитель успешно добавлен!");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            dbConnection.Disconnect();
            this.Close();
        }
    }
}
