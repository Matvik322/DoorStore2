using DoorStoreV2.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DoorStoreV2
{
    public partial class Main : Form
    {
        private Form activeForm = null;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Open(new Door());
        }

        private void doorsButton_Click(object sender, EventArgs e)
        {
            Open(new Door());
        }

        private void typeDoorButton_Click(object sender, EventArgs e)
        {
            Open(new TypeDoor());
        }

        private void doorInOrder_Click(object sender, EventArgs e)
        {
            Open(new DoorsInOrder());
        }

        private void manufacturersButton_Click(object sender, EventArgs e)
        {
            Open(new Manufacturers());
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            Open(new Clients());
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            Open(new Orders());
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            Open(new Staff());
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            Open(new Report());
        }


        public void Open(Form form)
        {
            try
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                activeForm = form;
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                panel3.Controls.Add(form);
                panel3.Tag = form;
                form.BringToFront();
                form.Show();
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                Application.Restart();
            }
        }

        private void closed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minSizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
