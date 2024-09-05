namespace DoorStoreV2.ReloadForms
{
    partial class SelectReloadDoor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectReloadDoor));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.minSizeForm = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.closed = new Guna.UI2.WinForms.Guna2Button();
            this.updateField = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 25);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.minSizeForm);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(250, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(25, 25);
            this.panel5.TabIndex = 1;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.closed);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(275, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(25, 25);
            this.panel4.TabIndex = 0;
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
            // updateField
            // 
            this.updateField.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateField.FormattingEnabled = true;
            this.updateField.Items.AddRange(new object[] {
            "Дату поставки",
            "Количество "});
            this.updateField.Location = new System.Drawing.Point(66, 48);
            this.updateField.Name = "updateField";
            this.updateField.Size = new System.Drawing.Size(171, 29);
            this.updateField.TabIndex = 16;
            this.updateField.Text = "Что обновить?";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.RoyalBlue;
            this.save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(0, 167);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(300, 33);
            this.save.TabIndex = 17;
            this.save.Text = "Выбрать";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // SelectReloadDoor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.save);
            this.Controls.Add(this.updateField);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectReloadDoor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectReloadDoor";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button minSizeForm;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button closed;
        private System.Windows.Forms.ComboBox updateField;
        private System.Windows.Forms.Button save;
    }
}