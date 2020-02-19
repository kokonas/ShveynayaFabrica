namespace WindowsFormsApp4
{
    partial class RegisterForm
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
            this.buttonReg = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textInitials = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReg
            // 
            this.buttonReg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.Location = new System.Drawing.Point(308, 322);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(208, 34);
            this.buttonReg.TabIndex = 21;
            this.buttonReg.Text = "Регистрация";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(236, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "ФИО";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(230, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Логин";
            // 
            // textInitials
            // 
            this.textInitials.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInitials.Location = new System.Drawing.Point(308, 266);
            this.textInitials.Name = "textInitials";
            this.textInitials.Size = new System.Drawing.Size(208, 24);
            this.textInitials.TabIndex = 17;
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(308, 218);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(208, 24);
            this.textPassword.TabIndex = 16;
            // 
            // textLogin
            // 
            this.textLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLogin.Location = new System.Drawing.Point(308, 176);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(208, 24);
            this.textLogin.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 14;
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.Location = new System.Drawing.Point(626, 12);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(162, 51);
            this.LoginButton.TabIndex = 23;
            this.LoginButton.Text = "Вы зарегистрированы?";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Регистрация";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.logo_02;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 350);
            this.panel2.TabIndex = 22;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textInitials);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Clousing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textInitials;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LoginButton;
    }
}