namespace DoorStoreV2
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sign = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.minSizeForm = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.closed = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
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
            // login
            // 
            this.login.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(88, 119);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(212, 26);
            this.login.TabIndex = 0;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(88, 169);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(212, 26);
            this.password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(159, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Войти";
            // 
            // Sign
            // 
            this.Sign.BackColor = System.Drawing.Color.RoyalBlue;
            this.Sign.FlatAppearance.BorderSize = 0;
            this.Sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sign.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sign.Location = new System.Drawing.Point(88, 212);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(212, 41);
            this.Sign.TabIndex = 3;
            this.Sign.Text = "Войти";
            this.Sign.UseVisualStyleBackColor = false;
            this.Sign.Click += new System.EventHandler(this.Sign_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(53, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(286, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "Нет аккаунта? Создайте прямо сейчас";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(92, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(92, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пароль";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.Sign);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.login);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 400);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 25);
            this.panel1.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.minSizeForm);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(350, 0);
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
            this.minSizeForm.Click += new System.EventHandler(this.minSizeForm_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.closed);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(375, 0);
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
            this.closed.Click += new System.EventHandler(this.closed_Click_1);
            // 
            // SignUpMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.Leave += new System.EventHandler(this.SignUp_Leave);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sign;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button minSizeForm;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button closed;
    }
}