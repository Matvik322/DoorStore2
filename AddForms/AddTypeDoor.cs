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
    public partial class AddTypeDoor : Form
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        public AddTypeDoor()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
        }

        private void AddTypeDoor_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO type_doors (name_type_doors, description_doors) " +
               "VALUES (@name_type_doors, @description_doors)";

            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                command.Parameters.AddWithValue("@name_type_doors", name.Text);
                command.Parameters.AddWithValue("@description_doors", description.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Тип двери успешно добавлен!");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            dbConnection.Disconnect();
            this.Close();
        }

        private void name_DoubleClick(object sender, EventArgs e)
        {
            textHelper.ClearText(name);
        }

        private void description_Enter(object sender, EventArgs e)
        {
            textHelper.ClearText(description);
        }

        
    }
}
