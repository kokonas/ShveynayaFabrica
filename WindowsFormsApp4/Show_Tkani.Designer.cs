namespace WindowsFormsApp4
{
    partial class Show_Tkani
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelZag = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Table_Tkani = new System.Windows.Forms.DataGridView();
            this.articulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shirinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tkanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fabricaDataSet = new WindowsFormsApp4.FabricaDataSet();
            this.tkanyTableAdapter = new WindowsFormsApp4.FabricaDataSetTableAdapters.TkanyTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Tkani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.Back_button);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.labelZag);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 8;
            // 
            // Back_button
            // 
            this.Back_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_button.Location = new System.Drawing.Point(684, 12);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(104, 45);
            this.Back_button.TabIndex = 7;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.LoginOut_button_Click);
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
            this.labelZag.Size = new System.Drawing.Size(404, 26);
            this.labelZag.TabIndex = 1;
            this.labelZag.Text = "Экран отображения списка тканей.";
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
            // Table_Tkani
            // 
            this.Table_Tkani.AutoGenerateColumns = false;
            this.Table_Tkani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_Tkani.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articulDataGridViewTextBoxColumn,
            this.naimenovanieDataGridViewTextBoxColumn,
            this.cvetDataGridViewTextBoxColumn,
            this.shirinaDataGridViewTextBoxColumn,
            this.dlinaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn});
            this.Table_Tkani.DataSource = this.tkanyBindingSource;
            this.Table_Tkani.Location = new System.Drawing.Point(106, 106);
            this.Table_Tkani.Name = "Table_Tkani";
            this.Table_Tkani.Size = new System.Drawing.Size(643, 216);
            this.Table_Tkani.TabIndex = 9;
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
            // cvetDataGridViewTextBoxColumn
            // 
            this.cvetDataGridViewTextBoxColumn.DataPropertyName = "Cvet";
            this.cvetDataGridViewTextBoxColumn.HeaderText = "Cvet";
            this.cvetDataGridViewTextBoxColumn.Name = "cvetDataGridViewTextBoxColumn";
            // 
            // shirinaDataGridViewTextBoxColumn
            // 
            this.shirinaDataGridViewTextBoxColumn.DataPropertyName = "Shirina";
            this.shirinaDataGridViewTextBoxColumn.HeaderText = "Shirina";
            this.shirinaDataGridViewTextBoxColumn.Name = "shirinaDataGridViewTextBoxColumn";
            // 
            // dlinaDataGridViewTextBoxColumn
            // 
            this.dlinaDataGridViewTextBoxColumn.DataPropertyName = "Dlina";
            this.dlinaDataGridViewTextBoxColumn.HeaderText = "Dlina";
            this.dlinaDataGridViewTextBoxColumn.Name = "dlinaDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // tkanyBindingSource
            // 
            this.tkanyBindingSource.DataMember = "Tkany";
            this.tkanyBindingSource.DataSource = this.fabricaDataSet;
            // 
            // fabricaDataSet
            // 
            this.fabricaDataSet.DataSetName = "FabricaDataSet";
            this.fabricaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tkanyTableAdapter
            // 
            this.tkanyTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 350);
            this.panel2.TabIndex = 10;
            // 
            // Show_Tkani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Table_Tkani);
            this.Controls.Add(this.panel1);
            this.Name = "Show_Tkani";
            this.Text = "Show_Tkani";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Show_Tkani_FormClosing);
            this.Load += new System.EventHandler(this.Kladovshic_show_Tkani_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Tkani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelZag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView Table_Tkani;
        private FabricaDataSet fabricaDataSet;
        private System.Windows.Forms.BindingSource tkanyBindingSource;
        private FabricaDataSetTableAdapters.TkanyTableAdapter tkanyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shirinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
    }
}