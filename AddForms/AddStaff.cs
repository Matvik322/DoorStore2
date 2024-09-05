using DoorStoreV2.Classes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoorStoreV2.AddForms
{
    public partial class AddStaff : Form
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;

        public AddStaff()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
        }
        private void AddStaff_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string dateString = employmentDate.Text;
            string format = "dd.MM.yyyy";
            DateTime dateEmployment = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);

            string query = "INSERT INTO staff (staff_name, salary, employment_date, job_title) " +
               "VALUES (@staff_name, @salary, @employment_date, @job_title)";

            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                command.Parameters.AddWithValue("@staff_name", fullname.Text);
                command.Parameters.AddWithValue("@salary", Convert.ToDouble(salary.Text));
                command.Parameters.AddWithValue("@employment_date", dateEmployment);
                command.Parameters.AddWithValue("@job_title", jobTitle.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Сотрудник успешно добавлен!");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            dbConnection.Disconnect();
            this.Close();
        }

        private void fullname_DoubleClick(object sender, EventArgs e)
        {
            textHelper.ClearText(fullname);
        }

        private void employmentDate_Enter(object sender, EventArgs e)
        {
            textHelper.ClearText(employmentDate);
        }

        private void jobTitle_Enter(object sender, EventArgs e)
        {
            textHelper.ClearText(jobTitle);
        }

        private void salary_DoubleClick(object sender, EventArgs e)
        {
            textHelper.ClearText(salary);
        }
    }
}
