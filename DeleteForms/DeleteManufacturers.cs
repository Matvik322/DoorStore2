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

namespace DoorStoreV2.DeleteForms
{
    public partial class DeleteManufacturers : Form
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        public DeleteManufacturers()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
        }

        private void DeleteManufacturers_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
        }

        private void idManufacturers_DoubleClick(object sender, EventArgs e)
        {
            textHelper.ClearText(idManufacturers);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM manufacturers WHERE manufacturers_id = @manufacturers_id";
            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                command.Parameters.AddWithValue("@manufacturers_id", Convert.ToInt32(idManufacturers.Text));
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Производитель успешно удален.");
                }
                else
                {
                    MessageBox.Show("Производитель не найден.");
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            dbConnection.Disconnect();
            this.Close();
        }
    }
}
