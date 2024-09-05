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

namespace DoorStoreV2.ReportForms
{
    public partial class GraphProcurementCosts : Form
    {
        private DbConnectionClass dbConnection;
        public GraphProcurementCosts()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
        }

        private void GrapProcurementCosts_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
            QueryForDataGrid();
            CreateChart2(dataGridView1, "Расходы на закупку за текущий год", "Name my series");
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

        public void QueryForDataGrid()
        {
            string query = "SELECT MONTH(date_buy) AS month_number, " +
               "IFNULL(SUM(price * count_door_in_stock), 0) AS expenses " +
               "FROM door " +
               "WHERE YEAR(date_buy) = YEAR(CURRENT_DATE) " +
               "GROUP BY MONTH(date_buy) " +
               "ORDER BY month_number";

            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Сумма потраченная на закупку", typeof(double));
                    dataTable.Columns.Add("Месяц", typeof(int));

                    while (reader.Read())
                    {
                        double expenses = reader.GetDouble(1);
                        int month = reader.GetInt32(0);

                        dataTable.Rows.Add(expenses, month);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.Columns["Месяц"].Width = 120;
                    dataGridView1.Columns["Сумма потраченная на закупку"].Width = 118;
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
