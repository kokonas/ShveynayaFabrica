namespace WindowsFormsApp4
{
    partial class Setting_TkaniForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panelstyle = new System.Windows.Forms.Panel();
            this.BackButt = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NazvanieBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SettBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SettingButt = new System.Windows.Forms.Button();
            this.Panelstyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 408);
            this.panel2.TabIndex = 22;
            // 
            // Panelstyle
            // 
            this.Panelstyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.Panelstyle.Controls.Add(this.BackButt);
            this.Panelstyle.Controls.Add(this.labelTitle);
            this.Panelstyle.Controls.Add(this.pictureBoxLogo);
            this.Panelstyle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panelstyle.Location = new System.Drawing.Point(0, 0);
            this.Panelstyle.Name = "Panelstyle";
            this.Panelstyle.Size = new System.Drawing.Size(1069, 100);
            this.Panelstyle.TabIndex = 21;
            // 
            // BackButt
            // 
            this.BackButt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButt.Location = new System.Drawing.Point(1075, 3);
            this.BackButt.Name = "BackButt";
            this.BackButt.Size = new System.Drawing.Size(95, 45);
            this.BackButt.TabIndex = 28;
            this.BackButt.Text = "Назад";
            this.BackButt.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(120, 38);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(0, 26);
            this.labelTitle.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 102);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(121, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Выберите фурнитуру";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ткани",
            "Пуговицы",
            "Украшения",
            "Изделия"});
            this.comboBox1.Location = new System.Drawing.Point(314, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 27);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(121, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Выберите артикул";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(314, 189);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 27);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(510, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Наименование";
            // 
            // NazvanieBox
            // 
            this.NazvanieBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NazvanieBox.Location = new System.Drawing.Point(633, 187);
            this.NazvanieBox.Multiline = true;
            this.NazvanieBox.Name = "NazvanieBox";
            this.NazvanieBox.Size = new System.Drawing.Size(358, 27);
            this.NazvanieBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(121, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Введите условие перехода товара в состояние обрезков:";
            // 
            // SettBox
            // 
            this.SettBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettBox.Location = new System.Drawing.Point(543, 271);
            this.SettBox.Name = "SettBox";
            this.SettBox.Size = new System.Drawing.Size(49, 26);
            this.SettBox.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(598, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "м²";
            // 
            // SettingButt
            // 
            this.SettingButt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingButt.Location = new System.Drawing.Point(125, 314);
            this.SettingButt.Name = "SettingButt";
            this.SettingButt.Size = new System.Drawing.Size(84, 37);
            this.SettingButt.TabIndex = 33;
            this.SettingButt.Text = "Ok";
            this.SettingButt.UseVisualStyleBackColor = true;
            this.SettingButt.Click += new System.EventHandler(this.SettingButt_Click);
            // 
            // Setting_TkaniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 508);
            this.Controls.Add(this.SettingButt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SettBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NazvanieBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panelstyle);
            this.Controls.Add(this.panel1);
            this.Name = "Setting_TkaniForm";
            this.Text = "Setting_TkaniForm";
            this.Panelstyle.ResumeLayout(false);
            this.Panelstyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Panelstyle;
        private System.Windows.Forms.Button BackButt;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NazvanieBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SettBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SettingButt;
    }
}