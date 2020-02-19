namespace WindowsFormsApp4
{
    partial class MenedgerForm
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
            this.labelZag = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginOut_button = new System.Windows.Forms.Button();
            this.Display_button = new System.Windows.Forms.Button();
            this.Recalculation_button = new System.Windows.Forms.Button();
            this.AssessmentFurnit_button = new System.Windows.Forms.Button();
            this.Nesting_button = new System.Windows.Forms.Button();
            this.AssessmentFabric_button = new System.Windows.Forms.Button();
            this.Accounting_button = new System.Windows.Forms.Button();
            this.Choice_button = new System.Windows.Forms.Button();
            this.Change_button = new System.Windows.Forms.Button();
            this.View_button = new System.Windows.Forms.Button();
            this.Formation_Offs_button = new System.Windows.Forms.Button();
            this.Formation_Tailings_button = new System.Windows.Forms.Button();
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
            this.panel2.Size = new System.Drawing.Size(100, 370);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.labelZag);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LoginOut_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 100);
            this.panel1.TabIndex = 7;
            // 
            // labelZag
            // 
            this.labelZag.AutoSize = true;
            this.labelZag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZag.Location = new System.Drawing.Point(120, 38);
            this.labelZag.Name = "labelZag";
            this.labelZag.Size = new System.Drawing.Size(215, 26);
            this.labelZag.TabIndex = 1;
            this.labelZag.Text = "Экран Менеджера";
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
            // LoginOut_button
            // 
            this.LoginOut_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginOut_button.Location = new System.Drawing.Point(780, 3);
            this.LoginOut_button.Name = "LoginOut_button";
            this.LoginOut_button.Size = new System.Drawing.Size(81, 38);
            this.LoginOut_button.TabIndex = 9;
            this.LoginOut_button.Text = "Выход";
            this.LoginOut_button.UseVisualStyleBackColor = true;
            this.LoginOut_button.Click += new System.EventHandler(this.LoginOut_button_Click);
            // 
            // Display_button
            // 
            this.Display_button.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Display_button.Location = new System.Drawing.Point(128, 346);
            this.Display_button.Name = "Display_button";
            this.Display_button.Size = new System.Drawing.Size(182, 52);
            this.Display_button.TabIndex = 19;
            this.Display_button.Text = "Отображение списка изделий";
            this.Display_button.UseVisualStyleBackColor = true;
            this.Display_button.Click += new System.EventHandler(this.Display_button_Click);
            // 
            // Recalculation_button
            // 
            this.Recalculation_button.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Recalculation_button.Location = new System.Drawing.Point(128, 286);
            this.Recalculation_button.Name = "Recalculation_button";
            this.Recalculation_button.Size = new System.Drawing.Size(182, 52);
            this.Recalculation_button.TabIndex = 18;
            this.Recalculation_button.Text = "Пересчёт в другую единицу измерения";
            this.Recalculation_button.UseVisualStyleBackColor = true;
            // 
            // AssessmentFurnit_button
            // 
            this.AssessmentFurnit_button.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AssessmentFurnit_button.Location = new System.Drawing.Point(128, 166);
            this.AssessmentFurnit_button.Name = "AssessmentFurnit_button";
            this.AssessmentFurnit_button.Size = new System.Drawing.Size(182, 52);
            this.AssessmentFurnit_button.TabIndex = 17;
            this.AssessmentFurnit_button.Text = "Оценка затрат фурнитуры";
            this.AssessmentFurnit_button.UseVisualStyleBackColor = true;
            // 
            // Nesting_button
            // 
            this.Nesting_button.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nesting_button.Location = new System.Drawing.Point(128, 226);
            this.Nesting_button.Name = "Nesting_button";
            this.Nesting_button.Size = new System.Drawing.Size(182, 52);
            this.Nesting_button.TabIndex = 16;
            this.Nesting_button.Text = "Раскрой";
            this.Nesting_button.UseVisualStyleBackColor = true;
            // 
            // AssessmentFabric_button
            // 
            this.AssessmentFabric_button.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AssessmentFabric_button.Location = new System.Drawing.Point(128, 106);
            this.AssessmentFabric_button.Name = "AssessmentFabric_button";
            this.AssessmentFabric_button.Size = new System.Drawing.Size(182, 52);
            this.AssessmentFabric_button.TabIndex = 15;
            this.AssessmentFabric_button.Text = "Оценка затрат ткани";
            this.AssessmentFabric_button.UseVisualStyleBackColor = true;
            // 
            // Accounting_button
            // 
            this.Accounting_button.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Accounting_button.Location = new System.Drawing.Point(128, 406);
            this.Accounting_button.Name = "Accounting_button";
            this.Accounting_button.Size = new System.Drawing.Size(182, 52);
            this.Accounting_button.TabIndex = 20;
            this.Accounting_button.Text = "Учёт производства изделий";
            this.Accounting_button.UseVisualStyleBackColor = true;
            this.Accounting_button.Click += new System.EventHandler(this.Accounting_button_Click);
            // 
            // Choice_button
            // 
            this.Choice_button.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Choice_button.Location = new System.Drawing.Point(329, 138);
            this.Choice_button.Name = "Choice_button";
            this.Choice_button.Size = new System.Drawing.Size(182, 54);
            this.Choice_button.TabIndex = 21;
            this.Choice_button.Text = "Выбор учётной единицы измерения";
            this.Choice_button.UseVisualStyleBackColor = true;
            // 
            // Change_button
            // 
            this.Change_button.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change_button.Location = new System.Drawing.Point(329, 198);
            this.Change_button.Name = "Change_button";
            this.Change_button.Size = new System.Drawing.Size(182, 54);
            this.Change_button.TabIndex = 22;
            this.Change_button.Text = "Изменение статуса заказа";
            this.Change_button.UseVisualStyleBackColor = true;
            // 
            // View_button
            // 
            this.View_button.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.View_button.Location = new System.Drawing.Point(329, 258);
            this.View_button.Name = "View_button";
            this.View_button.Size = new System.Drawing.Size(182, 54);
            this.View_button.TabIndex = 23;
            this.View_button.Text = "Просмотр спецификации изделия";
            this.View_button.UseVisualStyleBackColor = true;
            // 
            // Formation_Offs_button
            // 
            this.Formation_Offs_button.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Formation_Offs_button.Location = new System.Drawing.Point(329, 318);
            this.Formation_Offs_button.Name = "Formation_Offs_button";
            this.Formation_Offs_button.Size = new System.Drawing.Size(182, 54);
            this.Formation_Offs_button.TabIndex = 24;
            this.Formation_Offs_button.Text = "Формирование отчёта по списанию";
            this.Formation_Offs_button.UseVisualStyleBackColor = true;
            this.Formation_Offs_button.Click += new System.EventHandler(this.Formation_Offs_button_Click);
            // 
            // Formation_Tailings_button
            // 
            this.Formation_Tailings_button.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Formation_Tailings_button.Location = new System.Drawing.Point(329, 378);
            this.Formation_Tailings_button.Name = "Formation_Tailings_button";
            this.Formation_Tailings_button.Size = new System.Drawing.Size(182, 52);
            this.Formation_Tailings_button.TabIndex = 25;
            this.Formation_Tailings_button.Text = "Формирование отчёта по остаткам в (ед. изм)";
            this.Formation_Tailings_button.UseVisualStyleBackColor = true;
            this.Formation_Tailings_button.Click += new System.EventHandler(this.Formation_Tailings_button_Click);
            // 
            // MenedgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 470);
            this.Controls.Add(this.Formation_Tailings_button);
            this.Controls.Add(this.Formation_Offs_button);
            this.Controls.Add(this.View_button);
            this.Controls.Add(this.Choice_button);
            this.Controls.Add(this.Change_button);
            this.Controls.Add(this.Accounting_button);
            this.Controls.Add(this.Display_button);
            this.Controls.Add(this.Recalculation_button);
            this.Controls.Add(this.AssessmentFurnit_button);
            this.Controls.Add(this.Nesting_button);
            this.Controls.Add(this.AssessmentFabric_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MenedgerForm";
            this.Text = "MenedgerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenedgerForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelZag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LoginOut_button;
        private System.Windows.Forms.Button Display_button;
        private System.Windows.Forms.Button Recalculation_button;
        private System.Windows.Forms.Button AssessmentFurnit_button;
        private System.Windows.Forms.Button Nesting_button;
        private System.Windows.Forms.Button AssessmentFabric_button;
        private System.Windows.Forms.Button Accounting_button;
        private System.Windows.Forms.Button Choice_button;
        private System.Windows.Forms.Button Change_button;
        private System.Windows.Forms.Button View_button;
        private System.Windows.Forms.Button Formation_Offs_button;
        private System.Windows.Forms.Button Formation_Tailings_button;
    }
}