using DoorStoreV2.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DoorStoreV2.MainForms
{
    public partial class Register : Form
    {
        private DbConnectionClass dbConnection;
        public Register()
        {
            InitializeComponent();
            dbConnection = new DbConnectionClass(DbUtility.ConnectionString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Open(new SignUp());
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

        private void Reg_Click(object sender, EventArgs e)
        {
                string query = "INSERT INTO users (login, password) " +
            "VALUES (@login, @password)";
            if(password.Text.Equals(confirmationPassword.Text))
            {
                using (MySqlCommand command = new MySqlCommand(query, dbConnection.connection))
                {
                    if (ValidationLogin.Validation(login.Text) && PassValidation.Validation(password.Text))
                    {
                        command.Parameters.AddWithValue("@login", login.Text);
                        command.Parameters.AddWithValue("@password", Hashing.Hash(password.Text));
                        command.ExecuteNonQuery();
                        MessageBox.Show("Вы успешно зарегестрировались!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            dbConnection.Connect();
        }

        private void Register_Leave(object sender, EventArgs e)
        {
            dbConnection.connection.Dispose();
        }

        private void minSizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
