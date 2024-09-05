namespace DoorStoreV2.ReloadForms
{
    partial class ReloadDateDoor
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.manufacturersBox = new System.Windows.Forms.ComboBox();
            this.newDeliveryDate = new System.Windows.Forms.TextBox();
            this.nameDoor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reload = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.manufacturersBox);
            this.panel1.Controls.Add(this.newDeliveryDate);
            this.panel1.Controls.Add(this.nameDoor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 163);
            this.panel1.TabIndex = 8;
            // 
            // manufacturersBox
            // 
            this.manufacturersBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturersBox.FormattingEnabled = true;
            this.manufacturersBox.Location = new System.Drawing.Point(116, 84);
            this.manufacturersBox.Name = "manufacturersBox";
            this.manufacturersBox.Size = new System.Drawing.Size(171, 29);
            this.manufacturersBox.TabIndex = 17;
            this.manufacturersBox.Text = "Производитель";
            // 
            // newDeliveryDate
            // 
            this.newDeliveryDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newDeliveryDate.Location = new System.Drawing.Point(116, 119);
            this.newDeliveryDate.Name = "newDeliveryDate";
            this.newDeliveryDate.Size = new System.Drawing.Size(171, 29);
            this.newDeliveryDate.TabIndex = 4;
            this.newDeliveryDate.Text = "Новая дата";
            this.newDeliveryDate.Enter += new System.EventHandler(this.newDeliveryDate_Enter);
            // 
            // nameDoor
            // 
            this.nameDoor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameDoor.Location = new System.Drawing.Point(116, 49);
            this.nameDoor.Name = "nameDoor";
            this.nameDoor.Size = new System.Drawing.Size(171, 29);
            this.nameDoor.TabIndex = 3;
            this.nameDoor.Text = "Название двери";
            this.nameDoor.DoubleClick += new System.EventHandler(this.nameDoor_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Обновить дату поставки ";
            // 
            // reload
            // 
            this.reload.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.reload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reload.FlatAppearance.BorderSize = 0;
            this.reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reload.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reload.Location = new System.Drawing.Point(0, 334);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(400, 33);
            this.reload.TabIndex = 27;
            this.reload.Text = "Обновить";
            this.reload.UseVisualStyleBackColor = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(0, 367);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(400, 33);
            this.exit.TabIndex = 26;
            this.exit.Text = "Закрыть";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ReloadDateButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReloadDateButton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReloadDateButton";
            this.Load += new System.EventHandler(this.ReloadDateButton_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox manufacturersBox;
        private System.Windows.Forms.TextBox newDeliveryDate;
        private System.Windows.Forms.TextBox nameDoor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Button exit;
    }
}