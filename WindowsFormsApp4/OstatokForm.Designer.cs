namespace WindowsFormsApp4
{
    partial class OstatokForm
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
            this.fabricaDataSet4 = new WindowsFormsApp4.FabricaDataSet4();
            this.furnituraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furnituraTableAdapter = new WindowsFormsApp4.FabricaDataSet4TableAdapters.FurnituraTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tkanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fabricaDataSet5 = new WindowsFormsApp4.FabricaDataSet5();
            this.tkanyTableAdapter = new WindowsFormsApp4.FabricaDataSet5TableAdapters.TkanyTableAdapter();
            this.fabricaDataSet6 = new WindowsFormsApp4.FabricaDataSet6();
            this.scladTcaniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scladTcaniTableAdapter = new WindowsFormsApp4.FabricaDataSet6TableAdapters.ScladTcaniTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panelstyle = new System.Windows.Forms.Panel();
            this.BackButt = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ok_Click = new System.Windows.Forms.Button();
            this.NazvanieBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fabricaDataSet7 = new WindowsFormsApp4.FabricaDataSet7();
            this.obreskiTkaniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obreskiTkaniTableAdapter = new WindowsFormsApp4.FabricaDataSet7TableAdapters.ObreskiTkaniTableAdapter();
            this.fabricaDataSet8 = new WindowsFormsApp4.FabricaDataSet8();
            this.obreskiTkaniBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.obreskiTkaniTableAdapter1 = new WindowsFormsApp4.FabricaDataSet8TableAdapters.ObreskiTkaniTableAdapter();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnituraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scladTcaniBindingSource)).BeginInit();
            this.Panelstyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obreskiTkaniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obreskiTkaniBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // fabricaDataSet4
            // 
            this.fabricaDataSet4.DataSetName = "FabricaDataSet4";
            this.fabricaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // furnituraBindingSource
            // 
            this.furnituraBindingSource.DataMember = "Furnitura";
            this.furnituraBindingSource.DataSource = this.fabricaDataSet4;
            // 
            // furnituraTableAdapter
            // 
            this.furnituraTableAdapter.ClearBeforeFill = true;
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
            this.comboBox1.Location = new System.Drawing.Point(299, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 27);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(299, 188);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 27);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tkanyBindingSource
            // 
            this.tkanyBindingSource.DataMember = "Tkany";
            this.tkanyBindingSource.DataSource = this.fabricaDataSet5;
            // 
            // fabricaDataSet5
            // 
            this.fabricaDataSet5.DataSetName = "FabricaDataSet5";
            this.fabricaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tkanyTableAdapter
            // 
            this.tkanyTableAdapter.ClearBeforeFill = true;
            // 
            // fabricaDataSet6
            // 
            this.fabricaDataSet6.DataSetName = "FabricaDataSet6";
            this.fabricaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scladTcaniBindingSource
            // 
            this.scladTcaniBindingSource.DataMember = "ScladTcani";
            this.scladTcaniBindingSource.DataSource = this.fabricaDataSet6;
            // 
            // scladTcaniTableAdapter
            // 
            this.scladTcaniTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(299, 251);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(235, 27);
            this.comboBox3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 738);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Panelstyle
            // 
            this.Panelstyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.Panelstyle.Controls.Add(this.BackButt);
            this.Panelstyle.Controls.Add(this.labelTitle);
            this.Panelstyle.Controls.Add(this.pictureBoxLogo);
            this.Panelstyle.Controls.Add(this.menuStrip1);
            this.Panelstyle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panelstyle.Location = new System.Drawing.Point(0, 0);
            this.Panelstyle.Name = "Panelstyle";
            this.Panelstyle.Size = new System.Drawing.Size(1323, 100);
            this.Panelstyle.TabIndex = 18;
            // 
            // BackButt
            // 
            this.BackButt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButt.Location = new System.Drawing.Point(1180, 30);
            this.BackButt.Name = "BackButt";
            this.BackButt.Size = new System.Drawing.Size(95, 45);
            this.BackButt.TabIndex = 28;
            this.BackButt.Text = "Назад";
            this.BackButt.UseVisualStyleBackColor = true;
            this.BackButt.Click += new System.EventHandler(this.BackButt_Click);
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
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 76);
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
            this.menuStrip1.Size = new System.Drawing.Size(1323, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.печатьToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // Ok_Click
            // 
            this.Ok_Click.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok_Click.Location = new System.Drawing.Point(110, 312);
            this.Ok_Click.Name = "Ok_Click";
            this.Ok_Click.Size = new System.Drawing.Size(163, 30);
            this.Ok_Click.TabIndex = 21;
            this.Ok_Click.Text = "OK";
            this.Ok_Click.UseVisualStyleBackColor = true;
            this.Ok_Click.Click += new System.EventHandler(this.Ok_Click_Click);
            // 
            // NazvanieBox
            // 
            this.NazvanieBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NazvanieBox.Location = new System.Drawing.Point(737, 191);
            this.NazvanieBox.Multiline = true;
            this.NazvanieBox.Name = "NazvanieBox";
            this.NazvanieBox.Size = new System.Drawing.Size(358, 27);
            this.NazvanieBox.TabIndex = 22;
            this.NazvanieBox.TextChanged += new System.EventHandler(this.NazvanieBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Выберите фурнитуру";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(106, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Выберите артикул";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(106, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Выберите ед. измерения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(300, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(614, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Наименование";
            // 
            // fabricaDataSet7
            // 
            this.fabricaDataSet7.DataSetName = "FabricaDataSet7";
            this.fabricaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obreskiTkaniBindingSource
            // 
            this.obreskiTkaniBindingSource.DataMember = "ObreskiTkani";
            this.obreskiTkaniBindingSource.DataSource = this.fabricaDataSet7;
            // 
            // obreskiTkaniTableAdapter
            // 
            this.obreskiTkaniTableAdapter.ClearBeforeFill = true;
            // 
            // fabricaDataSet8
            // 
            this.fabricaDataSet8.DataSetName = "FabricaDataSet8";
            this.fabricaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obreskiTkaniBindingSource1
            // 
            this.obreskiTkaniBindingSource1.DataMember = "ObreskiTkani";
            this.obreskiTkaniBindingSource1.DataSource = this.fabricaDataSet8;
            // 
            // obreskiTkaniTableAdapter1
            // 
            this.obreskiTkaniTableAdapter1.ClearBeforeFill = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // OstatokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 838);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NazvanieBox);
            this.Controls.Add(this.Ok_Click);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panelstyle);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OstatokForm";
            this.Text = "OstatokForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OstatokForm_FormClosing);
            this.Load += new System.EventHandler(this.OstatokForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnituraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scladTcaniBindingSource)).EndInit();
            this.Panelstyle.ResumeLayout(false);
            this.Panelstyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obreskiTkaniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obreskiTkaniBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FabricaDataSet4 fabricaDataSet4;
        private System.Windows.Forms.BindingSource furnituraBindingSource;
        private FabricaDataSet4TableAdapters.FurnituraTableAdapter furnituraTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private FabricaDataSet5 fabricaDataSet5;
        private System.Windows.Forms.BindingSource tkanyBindingSource;
        private FabricaDataSet5TableAdapters.TkanyTableAdapter tkanyTableAdapter;
        private FabricaDataSet6 fabricaDataSet6;
        private System.Windows.Forms.BindingSource scladTcaniBindingSource;
        private FabricaDataSet6TableAdapters.ScladTcaniTableAdapter scladTcaniTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Panelstyle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button Ok_Click;
        private System.Windows.Forms.TextBox NazvanieBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BackButt;
        private FabricaDataSet7 fabricaDataSet7;
        private System.Windows.Forms.BindingSource obreskiTkaniBindingSource;
        private FabricaDataSet7TableAdapters.ObreskiTkaniTableAdapter obreskiTkaniTableAdapter;
        private FabricaDataSet8 fabricaDataSet8;
        private System.Windows.Forms.BindingSource obreskiTkaniBindingSource1;
        private FabricaDataSet8TableAdapters.ObreskiTkaniTableAdapter obreskiTkaniTableAdapter1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
    }
}