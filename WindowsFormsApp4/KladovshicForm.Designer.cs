namespace WindowsFormsApp4
{
    partial class KladovshicForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginOut_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelZag = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Inventory_button = new System.Windows.Forms.Button();
            this.Offs_button = new System.Windows.Forms.Button();
            this.Receipt_button = new System.Windows.Forms.Button();
            this.Calculation_button = new System.Windows.Forms.Button();
            this.DisplayFabric_button = new System.Windows.Forms.Button();
            this.DisplayHardware_button = new System.Windows.Forms.Button();
            this.ObtainingInfo_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 350);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.LoginOut_button);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.labelZag);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 7;
            // 
            // LoginOut_button
            // 
            this.LoginOut_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginOut_button.Location = new System.Drawing.Point(684, 12);
            this.LoginOut_button.Name = "LoginOut_button";
            this.LoginOut_button.Size = new System.Drawing.Size(104, 45);
            this.LoginOut_button.TabIndex = 7;
            this.LoginOut_button.Text = "Выход";
            this.LoginOut_button.UseVisualStyleBackColor = true;
            this.LoginOut_button.Click += new System.EventHandler(this.LoginOut_button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(847, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelZag
            // 
            this.labelZag.AutoSize = true;
            this.labelZag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZag.Location = new System.Drawing.Point(120, 38);
            this.labelZag.Name = "labelZag";
            this.labelZag.Size = new System.Drawing.Size(227, 26);
            this.labelZag.TabIndex = 1;
            this.labelZag.Text = "Экран Кладовщика";
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
            // Inventory_button
            // 
            this.Inventory_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Inventory_button.Location = new System.Drawing.Point(115, 127);
            this.Inventory_button.Name = "Inventory_button";
            this.Inventory_button.Size = new System.Drawing.Size(196, 45);
            this.Inventory_button.TabIndex = 9;
            this.Inventory_button.Text = "Инвентаризация";
            this.Inventory_button.UseVisualStyleBackColor = true;
            // 
            // Offs_button
            // 
            this.Offs_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Offs_button.Location = new System.Drawing.Point(115, 189);
            this.Offs_button.Name = "Offs_button";
            this.Offs_button.Size = new System.Drawing.Size(196, 47);
            this.Offs_button.TabIndex = 10;
            this.Offs_button.Text = "Списание материалов";
            this.Offs_button.UseVisualStyleBackColor = true;
            // 
            // Receipt_button
            // 
            this.Receipt_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Receipt_button.Location = new System.Drawing.Point(115, 253);
            this.Receipt_button.Name = "Receipt_button";
            this.Receipt_button.Size = new System.Drawing.Size(196, 49);
            this.Receipt_button.TabIndex = 11;
            this.Receipt_button.Text = "Поступление материалов";
            this.Receipt_button.UseVisualStyleBackColor = true;
            this.Receipt_button.Click += new System.EventHandler(this.Receipt_button_Click);
            // 
            // Calculation_button
            // 
            this.Calculation_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculation_button.Location = new System.Drawing.Point(115, 317);
            this.Calculation_button.Name = "Calculation_button";
            this.Calculation_button.Size = new System.Drawing.Size(196, 51);
            this.Calculation_button.TabIndex = 12;
            this.Calculation_button.Text = "Расчёт закупочной стоимости материалов";
            this.Calculation_button.UseVisualStyleBackColor = true;
            // 
            // DisplayFabric_button
            // 
            this.DisplayFabric_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisplayFabric_button.Location = new System.Drawing.Point(337, 136);
            this.DisplayFabric_button.Name = "DisplayFabric_button";
            this.DisplayFabric_button.Size = new System.Drawing.Size(223, 45);
            this.DisplayFabric_button.TabIndex = 13;
            this.DisplayFabric_button.Text = "Отображение списка тканей";
            this.DisplayFabric_button.UseVisualStyleBackColor = true;
            this.DisplayFabric_button.Click += new System.EventHandler(this.DisplayFabric_button_Click);
            // 
            // DisplayHardware_button
            // 
            this.DisplayHardware_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisplayHardware_button.Location = new System.Drawing.Point(337, 198);
            this.DisplayHardware_button.Name = "DisplayHardware_button";
            this.DisplayHardware_button.Size = new System.Drawing.Size(223, 53);
            this.DisplayHardware_button.TabIndex = 14;
            this.DisplayHardware_button.Text = "Отображение списка фурнитуры";
            this.DisplayHardware_button.UseVisualStyleBackColor = true;
            this.DisplayHardware_button.Click += new System.EventHandler(this.DisplayHardware_button_Click);
            // 
            // ObtainingInfo_button
            // 
            this.ObtainingInfo_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ObtainingInfo_button.Location = new System.Drawing.Point(337, 270);
            this.ObtainingInfo_button.Name = "ObtainingInfo_button";
            this.ObtainingInfo_button.Size = new System.Drawing.Size(223, 50);
            this.ObtainingInfo_button.TabIndex = 15;
            this.ObtainingInfo_button.Text = "Получение информации о материалах на складе";
            this.ObtainingInfo_button.UseVisualStyleBackColor = true;
            // 
            // KladovshicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ObtainingInfo_button);
            this.Controls.Add(this.DisplayHardware_button);
            this.Controls.Add(this.DisplayFabric_button);
            this.Controls.Add(this.Calculation_button);
            this.Controls.Add(this.Receipt_button);
            this.Controls.Add(this.Offs_button);
            this.Controls.Add(this.Inventory_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "KladovshicForm";
            this.Text = "KladovshicForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KladovshicForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LoginOut_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelZag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Inventory_button;
        private System.Windows.Forms.Button Offs_button;
        private System.Windows.Forms.Button Receipt_button;
        private System.Windows.Forms.Button Calculation_button;
        private System.Windows.Forms.Button DisplayFabric_button;
        private System.Windows.Forms.Button DisplayHardware_button;
        private System.Windows.Forms.Button ObtainingInfo_button;
    }
}