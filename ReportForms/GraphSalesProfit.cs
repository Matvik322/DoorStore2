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
    public partial class GraphSalesProfit : Form
    {
        private DbConnectionClass dbConnection;
        public GraphSalesProfit()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
        }

        private void GrapSalesProfit_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
            QueryForDataGrid();
            CreateChart2(dataGridView1, "Прибыль с продаж за текущий год", "Name my series");
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
            string query = "SELECT MONTH(orders.date_order) AS month_number, " +
                 "IFNULL(SUM(door.price * door_in_order.door_count), 0) AS profit " +
                 "FROM door INNER JOIN door_in_order ON door.door_id = door_in_order.id_door " +
                 "INNER JOIN orders ON door_in_order.id_orders = orders.order_id " +
                 "WHERE YEAR(orders.date_order) = YEAR(CURRENT_DATE)" +
                 "GROUP BY MONTH(orders.date_order) " +
                 "ORDER BY month_number";
            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Прибыль с продаж", typeof(decimal));
                    dataTable.Columns.Add("Месяц", typeof(int));

                    while (reader.Read())
                    {
                        decimal profit = reader.GetDecimal(1);
                        int month = reader.GetInt32(0);

                        dataTable.Rows.Add(profit, month);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.Columns["Месяц"].Width = 120;
                    dataGridView1.Columns["Прибыль с продаж"].Width = 118;
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
