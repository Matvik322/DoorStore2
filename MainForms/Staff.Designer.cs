namespace DoorStoreV2.MainForms
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.TextBox();
            this.deleteStaff = new Guna.UI2.WinForms.Guna2Button();
            this.addStaff = new Guna.UI2.WinForms.Guna2Button();
            this.reloadForm = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staff_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employment_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пероснал";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.deleteStaff);
            this.panel1.Controls.Add(this.addStaff);
            this.panel1.Controls.Add(this.reloadForm);
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 77);
            this.panel1.TabIndex = 3;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Location = new System.Drawing.Point(20, 24);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(190, 26);
            this.search.TabIndex = 9;
            this.search.Text = "Поиск ";
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            this.search.Enter += new System.EventHandler(this.search_Enter);
            // 
            // deleteStaff
            // 
            this.deleteStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteStaff.FillColor = System.Drawing.Color.Brown;
            this.deleteStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteStaff.ForeColor = System.Drawing.Color.White;
            this.deleteStaff.Image = ((System.Drawing.Image)(resources.GetObject("deleteStaff.Image")));
            this.deleteStaff.Location = new System.Drawing.Point(581, 24);
            this.deleteStaff.Name = "deleteStaff";
            this.deleteStaff.Size = new System.Drawing.Size(30, 26);
            this.deleteStaff.TabIndex = 8;
            this.deleteStaff.Click += new System.EventHandler(this.deleteStaff_Click);
            // 
            // addStaff
            // 
            this.addStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addStaff.FillColor = System.Drawing.Color.ForestGreen;
            this.addStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStaff.ForeColor = System.Drawing.Color.White;
            this.addStaff.Image = ((System.Drawing.Image)(resources.GetObject("addStaff.Image")));
            this.addStaff.Location = new System.Drawing.Point(545, 24);
            this.addStaff.Name = "addStaff";
            this.addStaff.Size = new System.Drawing.Size(30, 26);
            this.addStaff.TabIndex = 7;
            this.addStaff.Click += new System.EventHandler(this.addStaff_Click);
            // 
            // reloadForm
            // 
            this.reloadForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reloadForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reloadForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reloadForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reloadForm.FillColor = System.Drawing.Color.RoyalBlue;
            this.reloadForm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reloadForm.ForeColor = System.Drawing.Color.White;
            this.reloadForm.Image = ((System.Drawing.Image)(resources.GetObject("reloadForm.Image")));
            this.reloadForm.Location = new System.Drawing.Point(216, 24);
            this.reloadForm.Name = "reloadForm";
            this.reloadForm.Size = new System.Drawing.Size(30, 26);
            this.reloadForm.TabIndex = 6;
            this.reloadForm.Click += new System.EventHandler(this.reloadForm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staff_id,
            this.staff_name,
            this.salary,
            this.job_title,
            this.employment_date});
            this.dataGridView1.Location = new System.Drawing.Point(0, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 277);
            this.dataGridView1.TabIndex = 4;
            // 
            // staff_id
            // 
            this.staff_id.DataPropertyName = "staff_id";
            this.staff_id.HeaderText = "";
            this.staff_id.Name = "staff_id";
            this.staff_id.Width = 50;
            // 
            // staff_name
            // 
            this.staff_name.DataPropertyName = "staff_name";
            this.staff_name.HeaderText = "ФИО";
            this.staff_name.Name = "staff_name";
            this.staff_name.Width = 150;
            // 
            // salary
            // 
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "Зарплата";
            this.salary.Name = "salary";
            this.salary.Width = 135;
            // 
            // job_title
            // 
            this.job_title.DataPropertyName = "job_title";
            this.job_title.HeaderText = "Должность";
            this.job_title.Name = "job_title";
            this.job_title.Width = 150;
            // 
            // employment_date
            // 
            this.employment_date.DataPropertyName = "employment_date";
            this.employment_date.HeaderText = "Дата принятия на работу";
            this.employment_date.Name = "employment_date";
            this.employment_date.Width = 137;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox search;
        private Guna.UI2.WinForms.Guna2Button deleteStaff;
        private Guna.UI2.WinForms.Guna2Button addStaff;
        private Guna.UI2.WinForms.Guna2Button reloadForm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn employment_date;
    }
}