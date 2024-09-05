using DoorStoreV2.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorStoreV2.DeleteForms
{
    public partial class DeleteStaff : Form
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        public DeleteStaff()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
        }

        private void DeleteStaff_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM staff WHERE staff_id = @staff_id";
            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                command.Parameters.AddWithValue("staff_id", Convert.ToInt32(idStaff.Text));
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Сотрудник успешно удален.");
                }
                else
                {
                    MessageBox.Show("Сотрудник не найден.");
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            dbConnection.Disconnect();
            this.Close();
        }

        private void idStaff_DoubleClick(object sender, EventArgs e)
        {
            textHelper.ClearText(idStaff);
        }
    }
}
