using DoorStoreV2.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoorStoreV2.ReportForms
{
    public partial class GraphSalary : Form
    {
        private DbConnectionClass dbConnection;
        public GraphSalary()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
        }

        private void GraphSalary_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
            QueryForDataGrid();
            CreateChart2(dataGridView1, "Расходы на зарплату за год", "Name my series");
        }

        public void QueryForDataGrid()
        {
            string query = "SELECT SUM(salary) FROM staff";
            int countColumn = 0;

            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Сумма потраченная на зарплату", typeof(double));
                    dataTable.Columns.Add("Месяц", typeof(int));

                    while (reader.Read())
                    {
                        for (int i = 1; i <= 12; i++)
                        {
                            if (i > DateTime.Now.Month)
                            {
                                dataTable.Rows.Add(0, i);
                            }
                            else
                            {
                                double salary = reader.GetDouble(countColumn);
                                dataTable.Rows.Add(salary, i);
                            }
                        }
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.Columns["Месяц"].Width = 120;
                    dataGridView1.Columns["Сумма потраченная на зарплату"].Width = 118;
                }
            }
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

        private void closed_Click(object sender, EventArgs e)
        {
            dbConnection.Disconnect();
            this.Close();
        }

        private void minSizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
