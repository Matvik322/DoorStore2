using DoorStoreV2.Classes;
using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorStoreV2.ReportForms
{
    public partial class GraphBalance : Form
    {
        private DbConnectionClass dbConnection;
        public GraphBalance()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
        }

        private void GraphBalance_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
            getBalanceCurrentYear();
            CreateChart2(dataGridView1, "Баланс за текущий год", "Name my series");
        }

        private void CreateChart2(DataGridView grid, string nameTitle, string seriesName)
        {
            try
            {
                chart1.Series.Clear();
                chart1.Series.Add(seriesName);

                for (int i = 0; i < grid.RowCount; i++)
                {
                    var value = grid.Rows[i].Cells[0].Value?.ToString() ?? "";
                    var name = grid.Rows[i].Cells[1].Value?.ToString() ?? "";
                    chart1.Series[seriesName].Points.AddXY(name, value);
                }
                chart1.Titles.Clear();
                chart1.Titles.Add(nameTitle);

                chart1.ChartAreas[0].AxisX.Title = grid.Columns[1].HeaderText;
                chart1.ChartAreas[0].AxisY.Title = grid.Columns[0].HeaderText;

                MessageBox.Show("График сформирован", "Успех");
            }

            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Ошибка: Недостаточно столбцов в DataGridView", "Ошибка");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: недопустимые данные в DataGridView", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка");
            }
        }

        public void getBalanceCurrentYear()
        {
            string query = @"
            SELECT t.month,
                SUM(CASE WHEN t.type = 'salary' THEN t.amount ELSE 0 END) AS salary,
                SUM(CASE WHEN t.type = 'purchase' THEN t.amount ELSE 0 END) AS purchase,
                SUM(CASE WHEN t.type = 'profit' THEN t.amount ELSE 0 END) AS profit,
                SUM(CASE WHEN t.type = 'profit' THEN t.amount ELSE 0 END) - 
                    (SUM(CASE WHEN t.type = 'salary' THEN t.amount ELSE 0 END) + 
                    SUM(CASE WHEN t.type = 'purchase' THEN t.amount ELSE 0 END) ) AS balance
            FROM
            (
                SELECT 'salary' AS type, SUM(salary) AS amount, MONTH(CURRENT_DATE) AS month
                FROM staff
                WHERE YEAR(CURRENT_DATE) = YEAR(CURRENT_DATE)
                GROUP BY month

                UNION ALL

                SELECT 'purchase' AS type, SUM(price * count_door_in_stock) AS amount, MONTH(date_buy) AS month
                FROM door
                WHERE YEAR(date_buy) = YEAR(CURRENT_DATE)
                GROUP BY month

                UNION ALL

                SELECT 'profit' AS type, SUM(door.price * door_in_order.door_count) AS amount, MONTH(orders.date_order) AS month
                FROM door 
                INNER JOIN door_in_order ON door.door_id = door_in_order.id_door 
                INNER JOIN orders ON door_in_order.id_orders = orders.order_id 
                WHERE YEAR(orders.date_order) = YEAR(CURRENT_DATE)
                GROUP BY month
            ) t
            GROUP BY t.month
            ORDER BY t.month ASC;";

            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Баланс", typeof(double));
                    dataTable.Columns.Add("Месяц", typeof(int));

                    while (reader.Read())
                    {
                        double balance = reader.GetDouble("balance");
                        int month = reader.GetInt32("month");

                        dataTable.Rows.Add(balance, month);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.Columns["Месяц"].Width = 120;
                    dataGridView1.Columns["Баланс"].Width = 118;
                }
            }
        }

        private void minSizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closed_Click(object sender, EventArgs e)
        {
            dbConnection.Disconnect();
            this.Close();
        }
    }
}
