namespace WindowsFormsApp4
{
    partial class Show_Furnituri
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginOut_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelZag = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.articulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isobrashenieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnituraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fabricaDataSet1 = new WindowsFormsApp4.FabricaDataSet1();
            this.furnituraTableAdapter = new WindowsFormsApp4.FabricaDataSet1TableAdapters.FurnituraTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnituraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 350);
            this.panel2.TabIndex = 12;
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
            this.panel1.TabIndex = 11;
            // 
            // LoginOut_button
            // 
            this.LoginOut_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginOut_button.Location = new System.Drawing.Point(684, 12);
            this.LoginOut_button.Name = "LoginOut_button";
            this.LoginOut_button.Size = new System.Drawing.Size(104, 45);
            this.LoginOut_button.TabIndex = 7;
            this.LoginOut_button.Text = "Назад";
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
            this.labelZag.Size = new System.Drawing.Size(453, 26);
            this.labelZag.TabIndex = 1;
            this.labelZag.Text = "Экран отображения списка фурнитуры.";
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articulDataGridViewTextBoxColumn,
            this.naimenovanieDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.dlinaDataGridViewTextBoxColumn,
            this.isobrashenieDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.furnituraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(106, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 220);
            this.dataGridView1.TabIndex = 13;
            // 
            // articulDataGridViewTextBoxColumn
            // 
            this.articulDataGridViewTextBoxColumn.DataPropertyName = "Articul";
            this.articulDataGridViewTextBoxColumn.HeaderText = "Articul";
            this.articulDataGridViewTextBoxColumn.Name = "articulDataGridViewTextBoxColumn";
            // 
            // naimenovanieDataGridViewTextBoxColumn
            // 
            this.naimenovanieDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.HeaderText = "Naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.Name = "naimenovanieDataGridViewTextBoxColumn";
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "Tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            // 
            // dlinaDataGridViewTextBoxColumn
            // 
            this.dlinaDataGridViewTextBoxColumn.DataPropertyName = "Dlina";
            this.dlinaDataGridViewTextBoxColumn.HeaderText = "Dlina";
            this.dlinaDataGridViewTextBoxColumn.Name = "dlinaDataGridViewTextBoxColumn";
            // 
            // isobrashenieDataGridViewTextBoxColumn
            // 
            this.isobrashenieDataGridViewTextBoxColumn.DataPropertyName = "Isobrashenie";
            this.isobrashenieDataGridViewTextBoxColumn.HeaderText = "Isobrashenie";
            this.isobrashenieDataGridViewTextBoxColumn.Name = "isobrashenieDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // furnituraBindingSource
            // 
            this.furnituraBindingSource.DataMember = "Furnitura";
            this.furnituraBindingSource.DataSource = this.fabricaDataSet1;
            // 
            // fabricaDataSet1
            // 
            this.fabricaDataSet1.DataSetName = "FabricaDataSet1";
            this.fabricaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // furnituraTableAdapter
            // 
            this.furnituraTableAdapter.ClearBeforeFill = true;
            // 
            // Show_Furnituri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Show_Furnituri";
            this.Text = "Show_Furnituri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Show_Furnituri_FormClosing);
            this.Load += new System.EventHandler(this.Show_Furnituri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnituraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LoginOut_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelZag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FabricaDataSet1 fabricaDataSet1;
        private System.Windows.Forms.BindingSource furnituraBindingSource;
        private FabricaDataSet1TableAdapters.FurnituraTableAdapter furnituraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isobrashenieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
    }
}