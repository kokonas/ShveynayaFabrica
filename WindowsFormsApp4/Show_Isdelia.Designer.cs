namespace WindowsFormsApp4
{
    partial class Show_Isdelia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Isdelia));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panelstyle = new System.Windows.Forms.Panel();
            this.Back_button = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Panelstyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(116, 384);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(95, 37);
            this.Back.TabIndex = 1;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Next.Location = new System.Drawing.Point(665, 396);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(95, 37);
            this.Next.TabIndex = 2;
            this.Next.Text = "Вперёд";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 453);
            this.panel2.TabIndex = 19;
            // 
            // Panelstyle
            // 
            this.Panelstyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.Panelstyle.Controls.Add(this.Back_button);
            this.Panelstyle.Controls.Add(this.labelTitle);
            this.Panelstyle.Controls.Add(this.pictureBoxLogo);
            this.Panelstyle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panelstyle.Location = new System.Drawing.Point(0, 24);
            this.Panelstyle.Name = "Panelstyle";
            this.Panelstyle.Size = new System.Drawing.Size(945, 100);
            this.Panelstyle.TabIndex = 18;
            // 
            // Back_button
            // 
            this.Back_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_button.Location = new System.Drawing.Point(693, 3);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(104, 45);
            this.Back_button.TabIndex = 8;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(120, 38);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(414, 26);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Экран отображения списка изделий";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.печатьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Show_Isdelia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panelstyle);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Show_Isdelia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show_Isdelia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Show_Isdelia_FormClosing);
            this.Load += new System.EventHandler(this.Show_Isdelia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Panelstyle.ResumeLayout(false);
            this.Panelstyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Panelstyle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}