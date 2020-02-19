namespace WindowsFormsApp4
{
    partial class AvtorisForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panelstyle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.Panelstyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 102);
            this.panel1.TabIndex = 0;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(223, 190);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(61, 18);
            this.labelPassword.TabIndex = 14;
            this.labelPassword.Text = "Пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(234, 151);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(50, 18);
            this.labelLogin.TabIndex = 13;
            this.labelLogin.Text = "Логин";
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(316, 190);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(222, 24);
            this.textPassword.TabIndex = 12;
            // 
            // textLogin
            // 
            this.textLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLogin.Location = new System.Drawing.Point(316, 151);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(222, 24);
            this.textLogin.TabIndex = 11;
            // 
            // buttonReg
            // 
            this.buttonReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReg.Location = new System.Drawing.Point(453, 264);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(124, 35);
            this.buttonReg.TabIndex = 10;
            this.buttonReg.Text = "Регистрация";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.Location = new System.Drawing.Point(274, 264);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(102, 34);
            this.buttonEnter.TabIndex = 9;
            this.buttonEnter.Text = "Вход";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 350);
            this.panel2.TabIndex = 16;
            // 
            // Panelstyle
            // 
            this.Panelstyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.Panelstyle.Controls.Add(this.labelTitle);
            this.Panelstyle.Controls.Add(this.pictureBoxLogo);
            this.Panelstyle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panelstyle.Location = new System.Drawing.Point(0, 0);
            this.Panelstyle.Name = "Panelstyle";
            this.Panelstyle.Size = new System.Drawing.Size(800, 100);
            this.Panelstyle.TabIndex = 15;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(120, 38);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(216, 26);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Окно авторизации";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLogo.Image = global::WindowsFormsApp4.Properties.Resources.logo_02;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // AvtorisForm
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panelstyle);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.panel1);
            this.Name = "AvtorisForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AvtorisForm_FormClosing);
            this.Load += new System.EventHandler(this.AvtorisForm_Load);
            this.Panelstyle.ResumeLayout(false);
            this.Panelstyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Panelstyle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

