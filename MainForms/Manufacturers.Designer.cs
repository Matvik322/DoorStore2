﻿namespace DoorStoreV2.MainForms
{
    partial class Manufacturers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manufacturers));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button17 = new Guna.UI2.WinForms.Guna2Button();
            this.reloadButton = new Guna.UI2.WinForms.Guna2Button();
            this.search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.manufacturers_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_manufacturers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_information = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Производители";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.guna2Button9);
            this.panel1.Controls.Add(this.guna2Button17);
            this.panel1.Controls.Add(this.reloadButton);
            this.panel1.Controls.Add(this.search);
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 77);
            this.panel1.TabIndex = 2;
            // 
            // guna2Button9
            // 
            this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button9.FillColor = System.Drawing.Color.Brown;
            this.guna2Button9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button9.ForeColor = System.Drawing.Color.White;
            this.guna2Button9.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button9.Image")));
            this.guna2Button9.Location = new System.Drawing.Point(573, 24);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.Size = new System.Drawing.Size(30, 26);
            this.guna2Button9.TabIndex = 8;
            this.guna2Button9.Click += new System.EventHandler(this.guna2Button9_Click);
            // 
            // guna2Button17
            // 
            this.guna2Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Button17.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button17.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button17.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button17.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button17.FillColor = System.Drawing.Color.ForestGreen;
            this.guna2Button17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button17.ForeColor = System.Drawing.Color.White;
            this.guna2Button17.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button17.Image")));
            this.guna2Button17.Location = new System.Drawing.Point(537, 24);
            this.guna2Button17.Name = "guna2Button17";
            this.guna2Button17.Size = new System.Drawing.Size(30, 26);
            this.guna2Button17.TabIndex = 7;
            this.guna2Button17.Click += new System.EventHandler(this.guna2Button17_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reloadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reloadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reloadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reloadButton.FillColor = System.Drawing.Color.RoyalBlue;
            this.reloadButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reloadButton.ForeColor = System.Drawing.Color.White;
            this.reloadButton.Image = ((System.Drawing.Image)(resources.GetObject("reloadButton.Image")));
            this.reloadButton.Location = new System.Drawing.Point(216, 24);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(30, 26);
            this.reloadButton.TabIndex = 6;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Location = new System.Drawing.Point(20, 24);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(190, 26);
            this.search.TabIndex = 0;
            this.search.Text = "Поиск";
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            this.search.Enter += new System.EventHandler(this.search_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manufacturers_id,
            this.name_manufacturers,
            this.contact_information});
            this.dataGridView1.Location = new System.Drawing.Point(0, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 277);
            this.dataGridView1.TabIndex = 3;
            // 
            // manufacturers_id
            // 
            this.manufacturers_id.DataPropertyName = "manufacturers_id";
            this.manufacturers_id.HeaderText = "";
            this.manufacturers_id.Name = "manufacturers_id";
            this.manufacturers_id.Width = 88;
            // 
            // name_manufacturers
            // 
            this.name_manufacturers.DataPropertyName = "name_manufacturers";
            this.name_manufacturers.HeaderText = "Имя производителя";
            this.name_manufacturers.Name = "name_manufacturers";
            this.name_manufacturers.Width = 265;
            // 
            // contact_information
            // 
            this.contact_information.DataPropertyName = "contact_information";
            this.contact_information.HeaderText = "Контактная информация";
            this.contact_information.Name = "contact_information";
            this.contact_information.Width = 265;
            // 
            // Manufacturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Manufacturers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manufacturers";
            this.Load += new System.EventHandler(this.Manufacturers_Load);
            this.Leave += new System.EventHandler(this.Manufacturers_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2Button guna2Button17;
        private Guna.UI2.WinForms.Guna2Button reloadButton;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturers_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_manufacturers;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact_information;
    }
}