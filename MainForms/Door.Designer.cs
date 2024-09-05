namespace DoorStoreV2
{
    partial class Door
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Door));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reload = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button17 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.door_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_door = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_manufacturers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_type_doors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.door_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size_door = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_door_in_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Двери";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.reload);
            this.panel1.Controls.Add(this.guna2Button9);
            this.panel1.Controls.Add(this.guna2Button17);
            this.panel1.Controls.Add(this.guna2Button7);
            this.panel1.Controls.Add(this.search);
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 77);
            this.panel1.TabIndex = 1;
            // 
            // reload
            // 
            this.reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reload.FillColor = System.Drawing.Color.DodgerBlue;
            this.reload.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reload.ForeColor = System.Drawing.Color.White;
            this.reload.Image = ((System.Drawing.Image)(resources.GetObject("reload.Image")));
            this.reload.Location = new System.Drawing.Point(578, 24);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(30, 26);
            this.reload.TabIndex = 11;
            this.reload.Click += new System.EventHandler(this.reload_Click);
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
            this.guna2Button9.Location = new System.Drawing.Point(542, 24);
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
            this.guna2Button17.Location = new System.Drawing.Point(506, 24);
            this.guna2Button17.Name = "guna2Button17";
            this.guna2Button17.Size = new System.Drawing.Size(30, 26);
            this.guna2Button17.TabIndex = 7;
            this.guna2Button17.Click += new System.EventHandler(this.guna2Button17_Click);
            // 
            // guna2Button7
            // 
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button7.Image")));
            this.guna2Button7.Location = new System.Drawing.Point(216, 24);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(30, 26);
            this.guna2Button7.TabIndex = 6;
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.door_id,
            this.name_door,
            this.id_manufacturers,
            this.id_type_doors,
            this.door_material,
            this.size_door,
            this.price,
            this.count_door_in_stock,
            this.date_buy});
            this.dataGridView1.Location = new System.Drawing.Point(0, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // door_id
            // 
            this.door_id.DataPropertyName = "door_id";
            this.door_id.HeaderText = "";
            this.door_id.Name = "door_id";
            this.door_id.Width = 50;
            // 
            // name_door
            // 
            this.name_door.DataPropertyName = "name_door";
            this.name_door.HeaderText = "Название двери";
            this.name_door.Name = "name_door";
            // 
            // id_manufacturers
            // 
            this.id_manufacturers.DataPropertyName = "name_manufacturers";
            this.id_manufacturers.HeaderText = "Производитель";
            this.id_manufacturers.Name = "id_manufacturers";
            // 
            // id_type_doors
            // 
            this.id_type_doors.DataPropertyName = "name_type_doors";
            this.id_type_doors.HeaderText = "Тип двери";
            this.id_type_doors.Name = "id_type_doors";
            // 
            // door_material
            // 
            this.door_material.DataPropertyName = "door_material";
            this.door_material.HeaderText = "Материал";
            this.door_material.Name = "door_material";
            // 
            // size_door
            // 
            this.size_door.DataPropertyName = "size_door";
            this.size_door.HeaderText = "Размер";
            this.size_door.Name = "size_door";
            this.size_door.Width = 80;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            this.price.Width = 80;
            // 
            // count_door_in_stock
            // 
            this.count_door_in_stock.DataPropertyName = "count_door_in_stock";
            this.count_door_in_stock.HeaderText = "Кол-во";
            this.count_door_in_stock.Name = "count_door_in_stock";
            this.count_door_in_stock.Width = 50;
            // 
            // date_buy
            // 
            this.date_buy.DataPropertyName = "date_buy";
            this.date_buy.HeaderText = "Дата закупки";
            this.date_buy.Name = "date_buy";
            // 
            // Door
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Door";
            this.Text = "Door";
            this.Load += new System.EventHandler(this.Door_Load);
            this.Leave += new System.EventHandler(this.Door_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox search;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button17;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2Button reload;
        private System.Windows.Forms.DataGridViewTextBoxColumn door_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_door;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_manufacturers;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_type_doors;
        private System.Windows.Forms.DataGridViewTextBoxColumn door_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn size_door;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_door_in_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_buy;
    }
}