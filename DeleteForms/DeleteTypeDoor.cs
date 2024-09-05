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
    public partial class DeleteTypeDoor : Form
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        public DeleteTypeDoor()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
        }

        private void DeleteTypeDoor_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textHelper.ClearText(textBox1);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM type_doors WHERE type_doors_id = @type_doors_id";
            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                command.Parameters.AddWithValue("@type_doors_id", Convert.ToInt32(textBox1.Text));
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Тип двери успешно удален.");
                }
                else
                {
                    MessageBox.Show("Тип двери не найден.");
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
