namespace WindowsFormsApp4
{
    partial class PostuplenieTovarov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostuplenieTovarov));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Out_button = new System.Windows.Forms.Button();
            this.labelZag = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fabricaDataSet9 = new WindowsFormsApp4.FabricaDataSet9();
            this.scladTcaniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scladTcaniTableAdapter = new WindowsFormsApp4.FabricaDataSet9TableAdapters.ScladTcaniTableAdapter();
            this.fabricaDataSet10 = new WindowsFormsApp4.FabricaDataSet10();
            this.skladFurnituriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladFurnituriTableAdapter = new WindowsFormsApp4.FabricaDataSet10TableAdapters.SkladFurnituriTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Print = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scladTcaniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladFurnituriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 492);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.Out_button);
            this.panel1.Controls.Add(this.labelZag);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 100);
            this.panel1.TabIndex = 9;
            // 
            // Out_button
            // 
            this.Out_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Out_button.Location = new System.Drawing.Point(726, 12);
            this.Out_button.Name = "Out_button";
            this.Out_button.Size = new System.Drawing.Size(104, 45);
            this.Out_button.TabIndex = 7;
            this.Out_button.Text = "Назад";
            this.Out_button.UseVisualStyleBackColor = true;
            this.Out_button.Click += new System.EventHandler(this.Out_button_Click);
            // 
            // labelZag
            // 
            this.labelZag.AutoSize = true;
            this.labelZag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZag.Location = new System.Drawing.Point(120, 38);
            this.labelZag.Name = "labelZag";
            this.labelZag.Size = new System.Drawing.Size(252, 26);
            this.labelZag.TabIndex = 1;
            this.labelZag.Text = "Поступление товаров";
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
            // fabricaDataSet9
            // 
            this.fabricaDataSet9.DataSetName = "FabricaDataSet9";
            this.fabricaDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scladTcaniBindingSource
            // 
            this.scladTcaniBindingSource.DataMember = "ScladTcani";
            this.scladTcaniBindingSource.DataSource = this.fabricaDataSet9;
            // 
            // scladTcaniTableAdapter
            // 
            this.scladTcaniTableAdapter.ClearBeforeFill = true;
            // 
            // fabricaDataSet10
            // 
            this.fabricaDataSet10.DataSetName = "FabricaDataSet10";
            this.fabricaDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skladFurnituriBindingSource
            // 
            this.skladFurnituriBindingSource.DataMember = "SkladFurnituri";
            this.skladFurnituriBindingSource.DataSource = this.fabricaDataSet10;
            // 
            // skladFurnituriTableAdapter
            // 
            this.skladFurnituriTableAdapter.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Print
            // 
            this.Print.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Print.Location = new System.Drawing.Point(520, 137);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(142, 33);
            this.Print.TabIndex = 11;
            this.Print.Text = "Распечатать";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // PostuplenieTovarov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1113, 592);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PostuplenieTovarov";
            this.Text = "PostuplenieTovarov";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PostuplenieTovarov_FormClosing);
            this.Load += new System.EventHandler(this.PostuplenieTovarov_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scladTcaniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladFurnituriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Out_button;
        private System.Windows.Forms.Label labelZag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FabricaDataSet9 fabricaDataSet9;
        private System.Windows.Forms.BindingSource scladTcaniBindingSource;
        private FabricaDataSet9TableAdapters.ScladTcaniTableAdapter scladTcaniTableAdapter;
        private FabricaDataSet10 fabricaDataSet10;
        private System.Windows.Forms.BindingSource skladFurnituriBindingSource;
        private FabricaDataSet10TableAdapters.SkladFurnituriTableAdapter skladFurnituriTableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button Print;
    }
}