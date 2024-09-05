using DoorStoreV2.Classes;
using DoorStoreV2.MainForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoorStoreV2.AddForms
{
    public partial class AddDoor : Form, ComboboxLoader
    {
        private DbConnectionClass dbConnection;
        private TextHelper textHelper;
        private Dictionary<int, string> typeDoorsDictionary;
        private Dictionary<int, string> manufacturersDictionary;
        public AddDoor()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
            textHelper = new TextHelper();
            typeDoorsDictionary = new Dictionary<int, string>();
            manufacturersDictionary = new Dictionary<int, string>();
        }

        private void AddDoor_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
            LoadComboBox();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string dateString = dateBuy.Text;
            string format = "dd.MM.yyyy";
            DateTime dateBuyDoor = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);

            string query = "INSERT INTO door (id_type_doors, id_manufacturers, name_door, door_material, size_door, price, count_door_in_stock, date_buy) " +
               "VALUES (@id_type_doors, @id_manufacturers, @name_door, @door_material, @size_door, @price, @count_door_in_stock, @date_buy)";

            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                command.Parameters.AddWithValue("@id_type_doors", Convert.ToInt32(typeDoorBox.SelectedValue));
                command.Parameters.AddWithValue("@id_manufacturers", Convert.ToInt32(manufacturersBox.SelectedValue));
                command.Parameters.AddWithValue("@name_door", name.Text);
                command.Parameters.AddWithValue("@door_material", materail.Text);
                command.Parameters.AddWithValue("@size_door", size.Text);
                command.Parameters.AddWithValue("@price", Convert.ToDouble(price.Text));
                command.Parameters.AddWithValue("@count_door_in_stock", Convert.ToInt32(count.Text));
                command.Parameters.AddWithValue("@date_buy", dateString);
                command.ExecuteNonQuery();
                MessageBox.Show("Дверь успешно добавлена!");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            dbConnection.Disconnect();
            this.Close();
        }

        private void name_DoubleClick(object sender, EventArgs e)
        {
            textHelper.ClearText(name);
        }

        private void materail_Enter(object sender, EventArgs e)
        {
            textHelper.ClearText(materail);
        }

        private void size_Enter(object sender, EventArgs e)
        {
            textHelper.ClearText(size);
        }

        private void price_Enter(object sender, EventArgs e)
        {
            textHelper.ClearText(price);
        }

        private void count_Enter(object sender, EventArgs e)
        {
            textHelper.ClearText(count);
        }

        private void dateBuy_Enter(object sender, EventArgs e)
        {
            textHelper.ClearText(dateBuy);
        }

        public void LoadComboBox()
        {
            int firstCountColumn = 0;
            int secondCountColumn = 1;

            string queryTypeDoor = "SELECT * FROM type_doors ORDER BY type_doors_id DESC";
            using (MySqlCommand command = new MySqlCommand(queryTypeDoor, dbConnection.connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int typeDoorId = reader.GetInt32(firstCountColumn);
                        string typeDoorName = reader.GetString(secondCountColumn);
                        typeDoorsDictionary.Add(typeDoorId, typeDoorName);
                    }
                    typeDoorBox.DataSource = new BindingSource(typeDoorsDictionary.ToList(), null);
                    typeDoorBox.DisplayMember = "Value";
                    typeDoorBox.ValueMember = "Key";
                }
            }

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
            typeDoorBox.Text = "Тип двери";
        }
    }  
}

