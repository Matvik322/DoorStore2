using DoorStoreV2.Classes;
using MySql.Data.MySqlClient;
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

namespace DoorStoreV2.ReloadForms
{
    public partial class ReloadDateDoor : Form, ComboboxLoader
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        private Dictionary<int, string> manufacturersDictionary;
        public ReloadDateDoor()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
            manufacturersDictionary = new Dictionary<int, string>();
        }

        private void ReloadDateButton_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
            LoadComboBox();
        }

        public void LoadComboBox()
        {
            int firstCountColumn = 0;
            int secondCountColumn = 1;

            string queryManufacturers = "SELECT * FROM manufacturers ORDER BY manufacturers_id DESC";
            using (MySqlCommand command = new MySqlCommand(queryManufacturers, dbConnection.connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int manufacturersId = reader.GetInt32(firstCountColumn);
                        string manufacturersName = reader.GetString(secondCountColumn);
                        manufacturersDictionary.Add(manufacturersId, manufacturersName);
                    }
                    manufacturersBox.DataSource = new BindingSource(manufacturersDictionary.ToList(), null);
                    manufacturersBox.DisplayMember = "Value";
                    manufacturersBox.ValueMember = "Key";
                }
            }

            manufacturersBox.Text = "Производители";
        }

        private void reload_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE door SET date_buy = @date_buy WHERE name_door = @name_door " +
                    "AND id_manufacturers = @id_manufacturers";

                string dateString = newDeliveryDate.Text;
                string format = "dd.MM.yyyy";
                DateTime dateBuyDoor = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);

                using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.Add("@name_door", MySqlDbType.VarChar).Value = nameDoor.Text;
                    command.Parameters.Add("@id_manufacturers", MySqlDbType.Int32).Value = Convert.ToInt32(manufacturersBox.SelectedValue);
                    command.Parameters.Add("@date_buy", MySqlDbType.Date).Value = dateBuyDoor;
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Дата поставки успешно изменена.");
                    }
                    else
                    {
                        MessageBox.Show("Ни одна запись не была изменена.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            dbConnection.Disconnect();
            this.Close();
        }

        private void nameDoor_DoubleClick(object sender, EventArgs e)
        {
            textHelper.ClearText(nameDoor);
        }

        private void newDeliveryDate_Enter(object sender, EventArgs e)
        {
            textHelper.ClearText(newDeliveryDate);
        }
    }
}
