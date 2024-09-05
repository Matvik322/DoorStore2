namespace DoorStoreV2.ReportForms
{
    partial class GraphBalance
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphBalance));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.minSizeForm = new Guna.UI2.WinForms.Guna2Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.closed = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 25);
            this.panel5.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.minSizeForm);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(750, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(25, 25);
            this.panel7.TabIndex = 1;
            // 
            // minSizeForm
            // 
            this.minSizeForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minSizeForm.BackgroundImage")));
            this.minSizeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minSizeForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minSizeForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minSizeForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minSizeForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minSizeForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minSizeForm.FillColor = System.Drawing.Color.Transparent;
            this.minSizeForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minSizeForm.ForeColor = System.Drawing.Color.White;
            this.minSizeForm.Location = new System.Drawing.Point(0, 0);
            this.minSizeForm.Name = "minSizeForm";
            this.minSizeForm.Size = new System.Drawing.Size(25, 25);
            this.minSizeForm.TabIndex = 0;
            this.minSizeForm.Click += new System.EventHandler(this.minSizeForm_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.closed);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(775, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(25, 25);
            this.panel8.TabIndex = 0;
            // 
            // closed
            // 
            this.closed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closed.BackgroundImage")));
            this.closed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closed.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closed.FillColor = System.Drawing.Color.Transparent;
            this.closed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closed.ForeColor = System.Drawing.Color.White;
            this.closed.Location = new System.Drawing.Point(0, 0);
            this.closed.Name = "closed";
            this.closed.Size = new System.Drawing.Size(25, 25);
            this.closed.TabIndex = 0;
            this.closed.Click += new System.EventHandler(this.closed_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 575);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(560, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 575);
            this.panel2.TabIndex = 10;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(560, 575);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 575);
            this.dataGridView1.TabIndex = 2;
            // 
            // GraphBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GraphBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GraphBalance";
            this.Load += new System.EventHandler(this.GraphBalance_Load);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2Button minSizeForm;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2Button closed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}