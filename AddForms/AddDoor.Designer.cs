namespace DoorStoreV2.AddForms
{
    partial class AddDoor
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
            this.dateBuy = new System.Windows.Forms.TextBox();
            this.manufacturersBox = new System.Windows.Forms.ComboBox();
            this.typeDoorBox = new System.Windows.Forms.ComboBox();
            this.materail = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.size = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.dateBuy);
            this.panel1.Controls.Add(this.manufacturersBox);
            this.panel1.Controls.Add(this.typeDoorBox);
            this.panel1.Controls.Add(this.materail);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.size);
            this.panel1.Controls.Add(this.count);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 334);
            this.panel1.TabIndex = 4;
            // 
            // dateBuy
            // 
            this.dateBuy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateBuy.Location = new System.Drawing.Point(116, 294);
            this.dateBuy.Name = "dateBuy";
            this.dateBuy.Size = new System.Drawing.Size(171, 29);
            this.dateBuy.TabIndex = 17;
            this.dateBuy.Text = "Дата закупки";
            this.dateBuy.Enter += new System.EventHandler(this.dateBuy_Enter);
            // 
            // manufacturersBox
            // 
            this.manufacturersBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturersBox.FormattingEnabled = true;
            this.manufacturersBox.Location = new System.Drawing.Point(116, 84);
            this.manufacturersBox.Name = "manufacturersBox";
            this.manufacturersBox.Size = new System.Drawing.Size(171, 29);
            this.manufacturersBox.TabIndex = 16;
            this.manufacturersBox.Text = "Производитель";
            // 
            // typeDoorBox
            // 
            this.typeDoorBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeDoorBox.FormattingEnabled = true;
            this.typeDoorBox.Location = new System.Drawing.Point(116, 49);
            this.typeDoorBox.Name = "typeDoorBox";
            this.typeDoorBox.Size = new System.Drawing.Size(171, 29);
            this.typeDoorBox.TabIndex = 15;
            this.typeDoorBox.Text = "Тип двери";
            // 
            // materail
            // 
            this.materail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materail.Location = new System.Drawing.Point(116, 154);
            this.materail.Name = "materail";
            this.materail.Size = new System.Drawing.Size(171, 29);
            this.materail.TabIndex = 14;
            this.materail.Text = "Материал";
            this.materail.Enter += new System.EventHandler(this.materail_Enter);
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(115, 224);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(172, 29);
            this.price.TabIndex = 11;
            this.price.Text = "Цена";
            this.price.Enter += new System.EventHandler(this.price_Enter);
            // 
            // size
            // 
            this.size.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size.Location = new System.Drawing.Point(116, 189);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(171, 29);
            this.size.TabIndex = 10;
            this.size.Text = "Размер двери";
            this.size.Enter += new System.EventHandler(this.size_Enter);
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.Location = new System.Drawing.Point(116, 259);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(171, 29);
            this.count.TabIndex = 9;
            this.count.Text = "Количество";
            this.count.Enter += new System.EventHandler(this.count_Enter);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(116, 119);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(171, 29);
            this.name.TabIndex = 6;
            this.name.Text = "Имя";
            this.name.DoubleClick += new System.EventHandler(this.name_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление двери";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.LimeGreen;
            this.save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(0, 334);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(400, 33);
            this.save.TabIndex = 7;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
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
            this.exit.TabIndex = 6;
            this.exit.Text = "Закрыть";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // AddDoor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.save);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDoor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDoor";
            this.Load += new System.EventHandler(this.AddDoor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox materail;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox manufacturersBox;
        private System.Windows.Forms.ComboBox typeDoorBox;
        private System.Windows.Forms.TextBox dateBuy;
    }
}