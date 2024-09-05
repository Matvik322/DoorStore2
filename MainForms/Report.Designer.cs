namespace DoorStoreV2.MainForms
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.label1 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.guna2Button15 = new Guna.UI2.WinForms.Guna2Button();
            this.saldoClient = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.guna2Button16 = new Guna.UI2.WinForms.Guna2Button();
            this.saldoDoor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.guna2Button14 = new Guna.UI2.WinForms.Guna2Button();
            this.saldoStaff = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.guna2Button13 = new Guna.UI2.WinForms.Guna2Button();
            this.balanceMoney = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstDate = new System.Windows.Forms.TextBox();
            this.secondDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.applyFilter = new Guna.UI2.WinForms.Guna2Button();
            this.reloadButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel14.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Отчет";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Silver;
            this.panel14.Controls.Add(this.panel18);
            this.panel14.Controls.Add(this.panel17);
            this.panel14.Controls.Add(this.panel16);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Location = new System.Drawing.Point(0, 74);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(625, 260);
            this.panel14.TabIndex = 18;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.White;
            this.panel18.Controls.Add(this.guna2Button15);
            this.panel18.Controls.Add(this.saldoClient);
            this.panel18.Controls.Add(this.label4);
            this.panel18.Location = new System.Drawing.Point(338, 137);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(255, 97);
            this.panel18.TabIndex = 2;
            // 
            // guna2Button15
            // 
            this.guna2Button15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button15.BackgroundImage")));
            this.guna2Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button15.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button15.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button15.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button15.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button15.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button15.ForeColor = System.Drawing.Color.White;
            this.guna2Button15.Location = new System.Drawing.Point(218, 12);
            this.guna2Button15.Name = "guna2Button15";
            this.guna2Button15.Size = new System.Drawing.Size(25, 25);
            this.guna2Button15.TabIndex = 4;
            this.guna2Button15.Text = "guna2Button15";
            this.guna2Button15.Click += new System.EventHandler(this.guna2Button15_Click);
            // 
            // saldoClient
            // 
            this.saldoClient.AutoSize = true;
            this.saldoClient.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saldoClient.Location = new System.Drawing.Point(3, 34);
            this.saldoClient.Name = "saldoClient";
            this.saldoClient.Size = new System.Drawing.Size(65, 20);
            this.saldoClient.TabIndex = 4;
            this.saldoClient.Text = "Деньги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Прибыль с продаж";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel17.Controls.Add(this.guna2Button16);
            this.panel17.Controls.Add(this.saldoDoor);
            this.panel17.Controls.Add(this.label5);
            this.panel17.Location = new System.Drawing.Point(16, 137);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(255, 97);
            this.panel17.TabIndex = 1;
            // 
            // guna2Button16
            // 
            this.guna2Button16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button16.BackgroundImage")));
            this.guna2Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button16.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button16.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button16.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button16.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button16.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button16.ForeColor = System.Drawing.Color.White;
            this.guna2Button16.Location = new System.Drawing.Point(219, 12);
            this.guna2Button16.Name = "guna2Button16";
            this.guna2Button16.Size = new System.Drawing.Size(25, 25);
            this.guna2Button16.TabIndex = 5;
            this.guna2Button16.Text = "guna2Button16";
            this.guna2Button16.Click += new System.EventHandler(this.guna2Button16_Click);
            // 
            // saldoDoor
            // 
            this.saldoDoor.AutoSize = true;
            this.saldoDoor.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saldoDoor.Location = new System.Drawing.Point(6, 34);
            this.saldoDoor.Name = "saldoDoor";
            this.saldoDoor.Size = new System.Drawing.Size(65, 20);
            this.saldoDoor.TabIndex = 2;
            this.saldoDoor.Text = "Деньги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Расходы на закупку";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.Controls.Add(this.guna2Button14);
            this.panel16.Controls.Add(this.saldoStaff);
            this.panel16.Controls.Add(this.label3);
            this.panel16.Location = new System.Drawing.Point(338, 15);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(255, 97);
            this.panel16.TabIndex = 1;
            // 
            // guna2Button14
            // 
            this.guna2Button14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button14.BackgroundImage")));
            this.guna2Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button14.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button14.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button14.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button14.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button14.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button14.ForeColor = System.Drawing.Color.White;
            this.guna2Button14.Location = new System.Drawing.Point(218, 8);
            this.guna2Button14.Name = "guna2Button14";
            this.guna2Button14.Size = new System.Drawing.Size(25, 25);
            this.guna2Button14.TabIndex = 3;
            this.guna2Button14.Text = "guna2Button14";
            this.guna2Button14.Click += new System.EventHandler(this.guna2Button14_Click);
            // 
            // saldoStaff
            // 
            this.saldoStaff.AutoSize = true;
            this.saldoStaff.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saldoStaff.Location = new System.Drawing.Point(3, 29);
            this.saldoStaff.Name = "saldoStaff";
            this.saldoStaff.Size = new System.Drawing.Size(65, 20);
            this.saldoStaff.TabIndex = 2;
            this.saldoStaff.Text = "Деньги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Расходы на зарплаты";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.Controls.Add(this.guna2Button13);
            this.panel15.Controls.Add(this.balanceMoney);
            this.panel15.Controls.Add(this.label2);
            this.panel15.Location = new System.Drawing.Point(16, 15);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(255, 97);
            this.panel15.TabIndex = 0;
            // 
            // guna2Button13
            // 
            this.guna2Button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button13.BackgroundImage")));
            this.guna2Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button13.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button13.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button13.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button13.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button13.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button13.ForeColor = System.Drawing.Color.White;
            this.guna2Button13.Location = new System.Drawing.Point(219, 8);
            this.guna2Button13.Name = "guna2Button13";
            this.guna2Button13.Size = new System.Drawing.Size(25, 25);
            this.guna2Button13.TabIndex = 2;
            this.guna2Button13.Text = "guna2Button13";
            this.guna2Button13.Click += new System.EventHandler(this.guna2Button13_Click);
            // 
            // balanceMoney
            // 
            this.balanceMoney.AutoSize = true;
            this.balanceMoney.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceMoney.Location = new System.Drawing.Point(5, 29);
            this.balanceMoney.Name = "balanceMoney";
            this.balanceMoney.Size = new System.Drawing.Size(65, 20);
            this.balanceMoney.TabIndex = 1;
            this.balanceMoney.Text = "Деньги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Баланс";
            // 
            // firstDate
            // 
            this.firstDate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstDate.Location = new System.Drawing.Point(191, 11);
            this.firstDate.Name = "firstDate";
            this.firstDate.Size = new System.Drawing.Size(136, 26);
            this.firstDate.TabIndex = 19;
            this.firstDate.Text = "Дата с";
            this.firstDate.Enter += new System.EventHandler(this.firstDate_Enter);
            // 
            // secondDate
            // 
            this.secondDate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondDate.Location = new System.Drawing.Point(364, 11);
            this.secondDate.Name = "secondDate";
            this.secondDate.Size = new System.Drawing.Size(136, 26);
            this.secondDate.TabIndex = 20;
            this.secondDate.Text = "Дата по";
            this.secondDate.Enter += new System.EventHandler(this.secondDate_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(333, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 32);
            this.label6.TabIndex = 21;
            this.label6.Text = "-";
            // 
            // applyFilter
            // 
            this.applyFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.applyFilter.BorderThickness = 1;
            this.applyFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.applyFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.applyFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.applyFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.applyFilter.FillColor = System.Drawing.Color.LimeGreen;
            this.applyFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applyFilter.ForeColor = System.Drawing.Color.White;
            this.applyFilter.Image = ((System.Drawing.Image)(resources.GetObject("applyFilter.Image")));
            this.applyFilter.Location = new System.Drawing.Point(519, 11);
            this.applyFilter.Name = "applyFilter";
            this.applyFilter.Size = new System.Drawing.Size(30, 26);
            this.applyFilter.TabIndex = 22;
            this.applyFilter.Click += new System.EventHandler(this.applyFilter_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.BorderThickness = 1;
            this.reloadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reloadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reloadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reloadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reloadButton.FillColor = System.Drawing.Color.RoyalBlue;
            this.reloadButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reloadButton.ForeColor = System.Drawing.Color.White;
            this.reloadButton.Image = ((System.Drawing.Image)(resources.GetObject("reloadButton.Image")));
            this.reloadButton.Location = new System.Drawing.Point(563, 11);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(30, 26);
            this.reloadButton.TabIndex = 23;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.applyFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.secondDate);
            this.Controls.Add(this.firstDate);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.label1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.Leave += new System.EventHandler(this.Report_Leave);
            this.panel14.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel18;
        private Guna.UI2.WinForms.Guna2Button guna2Button15;
        private System.Windows.Forms.Label saldoClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel17;
        private Guna.UI2.WinForms.Guna2Button guna2Button16;
        private System.Windows.Forms.Label saldoDoor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel16;
        private Guna.UI2.WinForms.Guna2Button guna2Button14;
        private System.Windows.Forms.Label saldoStaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel15;
        private Guna.UI2.WinForms.Guna2Button guna2Button13;
        private System.Windows.Forms.Label balanceMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstDate;
        private System.Windows.Forms.TextBox secondDate;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button applyFilter;
        private Guna.UI2.WinForms.Guna2Button reloadButton;
    }
}