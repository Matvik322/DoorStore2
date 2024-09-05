using DoorStoreV2.Classes;
using DoorStoreV2.ReportForms;
using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
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

namespace DoorStoreV2.MainForms
{
    public partial class Report : Form
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        public Report()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
            ReportCurrentMonth();
        }

        public void UpdateDataFromDatabase()
        {
            double salary = 0;
            double purchase = 0;
            double profit = 0;
            double balance;

            string format = "dd.MM.yyyy";
            string firstDateString = firstDate.Text;
            string secondDateString = secondDate.Text;

            DateTime firstDateReport;
            DateTime secondDateReport;

            if (DateTime.TryParseExact(firstDateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out firstDateReport) &&
                DateTime.TryParseExact(secondDateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out secondDateReport))
            {
                string queryFirst = "SELECT SUM(salary) FROM staff";
                using (MySqlCommand command = new MySqlCommand(queryFirst, dbConnection.connection))
                {
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        salary = Convert.ToDouble(result);
                        saldoStaff.Text = salary.ToString();
                    }
                }

                string querySecond = "SELECT SUM(price * count_door_in_stock) FROM door " +
                                "WHERE date_buy BETWEEN @firstDate AND @secondDate";
                using (MySqlCommand command = new MySqlCommand(querySecond, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@firstDate", firstDateReport);
                    command.Parameters.AddWithValue("@secondDate", secondDateReport);
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        purchase = Convert.ToDouble(result);
                        saldoDoor.Text = purchase.ToString();
                    }
                }

                string queryThird = "SELECT SUM(door.price * door_in_order.door_count) " +
                                "FROM door INNER JOIN door_in_order ON door.door_id = door_in_order.id_door " +
                                "INNER JOIN orders ON door_in_order.id_orders = orders.order_id " +
                                "WHERE orders.date_order BETWEEN @firstDate AND @secondDate";
                using (MySqlCommand command = new MySqlCommand(queryThird, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@firstDate", firstDateReport);
                    command.Parameters.AddWithValue("@secondDate", secondDateReport);
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        profit = Convert.ToDouble(result);
                        saldoClient.Text = profit.ToString();
                    }
                }

                balance = profit - (salary + purchase);
                balanceMoney.Text = balance.ToString();
            }
            else
            {
                MessageBox.Show("Неправильный формат даты. Введите дату в формате dd.MM.yyyy");
            }
        }

        public void ReportCurrentMonth()
        {
            double salary = 0;
            double purchase = 0;
            double profit = 0;
            double balance;

            string queryFirstMonth = "SELECT IFNULL(SUM(salary), 0) FROM staff"; 
            using (MySqlCommand command = new MySqlCommand(queryFirstMonth, dbConnection.connection))
            {
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    salary = Convert.ToDouble(result);
                }
            }
            saldoStaff.Text = salary.ToString();

            string querySecondMonth = "SELECT IFNULL(SUM(price * count_door_in_stock), 0) FROM door " +
                "WHERE MONTH(date_buy) = MONTH(CURRENT_DATE) AND YEAR(date_buy) = YEAR(CURRENT_DATE)";
            using (MySqlCommand command = new MySqlCommand(querySecondMonth, dbConnection.connection))
            {
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    purchase = Convert.ToDouble(result);
                }
            }
            saldoDoor.Text = purchase.ToString();

            string queryThirdMonth = "SELECT IFNULL(SUM(door.price * door_in_order.door_count), 0) " +
                "FROM door INNER JOIN door_in_order ON door.door_id = door_in_order.id_door " +
                "INNER JOIN orders ON door_in_order.id_orders = orders.order_id " +
                "WHERE MONTH(orders.date_order) = MONTH(CURRENT_DATE) AND YEAR(orders.date_order) = YEAR(CURRENT_DATE)";
            using (MySqlCommand command = new MySqlCommand(queryThirdMonth, dbConnection.connection))
            {
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    profit = Convert.ToDouble(result);
                }
            }
            saldoClient.Text = profit.ToString();

            balance = profit - (salary + purchase);
            balanceMoney.Text = balance.ToString();

            firstDate.Text = "Дата с";
            secondDate.Text = "Дата по";
        }

        private void Report_Leave(object sender, EventArgs e)
        {
            dbConnection.Disconnect();
        }

        private void firstDate_Enter(object sender, EventArgs e)
        {
            textHelper.ClearText(firstDate);
        }

        private void secondDate_Enter(object sender, EventArgs e)
        {
            textHelper.ClearText(secondDate);
        }

        private void applyFilter_Click(object sender, EventArgs e)
        {
            UpdateDataFromDatabase();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            ReportCurrentMonth();
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            GraphSalary form = new GraphSalary();
            form.ShowDialog();
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            GraphProcurementCosts form = new GraphProcurementCosts();
            form.ShowDialog();
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            GraphSalesProfit form = new GraphSalesProfit();
            form.ShowDialog();
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            GraphBalance form = new GraphBalance();
            form.ShowDialog();
        }
    }
}
