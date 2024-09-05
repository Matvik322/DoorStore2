using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorStoreV2.ReloadForms
{
    public partial class SelectReloadDoor : Form
    {
        public SelectReloadDoor()
        {
            InitializeComponent();
        }

        private void minSizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            switch (updateField.Text)
            {
                case "Количество":
                    Open(new ReloadCountDoor());
                    break;
                case "Дату поставки":
                    Open(new ReloadDateDoor());
                    break;
            }
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
    }
}
