using DoorStoreV2.Classes;
using DoorStoreV2.MainForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorStoreV2
{
    public partial class SignUp : Form
    {
        private DbConnectionClass dbConnection;

        public SignUp()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
        }

        public void ValidateSignUp()
        {
            string query = "SELECT * FROM users";
            string passwordToLogin = Hashing.Hash(password.Text);
            bool isUserValid = false;

            using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string loginDb = reader.GetValue(1).ToString();
                        string passwordDb = reader.GetValue(2).ToString();
                        string roleDB = reader.GetValue(3).ToString();

                        if (loginDb.Equals(login.Text) && passwordDb.Equals(passwordToLogin) && roleDB.Equals("administrator"))
                        {
                            isUserValid = true;
                            break;
                        }
                    }
                }
            }

            if (isUserValid)
            {
                MessageBox.Show("Добро пожаловать!!!");
                Open(new Main());
            }
            else
            {
                MessageBox.Show("Перепроверьте введенные данные!!!");
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
        }

        private void SignUp_Leave(object sender, EventArgs e)
        {
            dbConnection.connection.Dispose();
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            ValidateSignUp();
        }

        public void Open(Form form)
        {
            this.Hide();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                Thread.Sleep(150);
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Open(new Register());
        }

        private void closed_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minSizeForm_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
