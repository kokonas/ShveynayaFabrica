using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class PostuplenieTovarov : Form
    {
        public static SqlConnection sqlConnect = new SqlConnection("Data Source=LAPTOP-562FH47J\\SQL2017;Initial Catalog=Fabrica;Integrated Security=True");
        public PostuplenieTovarov()
        {
            InitializeComponent();
        }

        private void Out_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            KladovshicForm bF = new KladovshicForm();
            bF.Show();
        }

        Label T = new Label();
        DataGridView TkSc = new DataGridView();
        Label F = new Label();
        DataGridView FrSc = new DataGridView();

        Label Zak = new Label();
        TextBox ZakT = new TextBox();
        Label Kol = new Label();
        TextBox KolT = new TextBox();
        Label Cen = new Label();
        TextBox CenT = new TextBox();
        

        private void PostuplenieTovarov_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fabricaDataSet10.SkladFurnituri' table. You can move, or remove it, as needed.
            this.skladFurnituriTableAdapter.Fill(this.fabricaDataSet10.SkladFurnituri);
            // TODO: This line of code loads data into the 'fabricaDataSet9.ScladTcani' table. You can move, or remove it, as needed.
            this.scladTcaniTableAdapter.Fill(this.fabricaDataSet9.ScladTcani);
            sqlConnect.Open();

            
            T.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            T.AutoSize = true;
            T.Location = new Point(labelZag.Location.X, labelZag.Location.Y + labelZag.Height + 100);
            T.Text = "Количество тканей на складе!";
            this.Controls.Add(T);

            
            TkSc.Location = new Point(labelZag.Location.X, labelZag.Location.Y + labelZag.Height + 120);
            TkSc.DataSource = scladTcaniBindingSource;
            TkSc.AutoSize = true;
            this.Controls.Add(TkSc);

            
            F.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            F.AutoSize = true;
            F.Location = new Point(TkSc.Location.X, TkSc.Location.Y + TkSc.Height + 40);
            F.Text = "Количество фурнитуры на складе!";
            this.Controls.Add(F);

            
            FrSc.Location = new Point(F.Location.X, F.Location.Y + F.Height + 20);
            FrSc.DataSource = skladFurnituriBindingSource;
            FrSc.AutoSize = true;
            this.Controls.Add(FrSc);


            Zak.Location = new Point(FrSc.Location.X, FrSc.Location.Y + FrSc.Height + 20);
            Zak.Text = "Закупаемые товары - ";
            Zak.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            Zak.AutoSize = true;
            this.Controls.Add(Zak);

            ZakT.Location = new Point(Zak.Location.X + Zak.Width + 10, Zak.Location.Y);
            ZakT.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            ZakT.Size = new Size(56, 27);
            this.Controls.Add(ZakT);


            Kol.Location = new Point(Zak.Location.X, Zak.Location.Y + Zak.Height + 20);
            Kol.Text = "Их количество - ";
            Kol.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            Kol.AutoSize = true;
            this.Controls.Add(Kol);

            KolT.Location = new Point(Kol.Location.X + Kol.Width + 10, Kol.Location.Y);
            KolT.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            KolT.Size = new Size(56, 27);
            this.Controls.Add(KolT);


            Cen.Location = new Point(Kol.Location.X, Kol.Location.Y + Kol.Height + 20);
            Cen.Text = "Стоимость - ";
            Cen.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            Cen.AutoSize = true;
            this.Controls.Add(Cen);

            CenT.Location = new Point(Cen.Location.X + Cen.Width + 10, Cen.Location.Y);
            CenT.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            CenT.Size = new Size(56, 27);
            this.Controls.Add(CenT);


        }

        private void PostuplenieTovarov_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string tx = "Количество тканей на складе";
            e.Graphics.DrawString(tx, new Font("Microsoft Sans Serif", 16, FontStyle.Bold), Brushes.Black, new Point(100,150));

            Bitmap objBmp1 = new Bitmap(this.TkSc.Width, this.TkSc.Height);
            TkSc.DrawToBitmap(objBmp1, new Rectangle(0, 0, this.TkSc.Width, this.TkSc.Height));
            e.Graphics.DrawImage(objBmp1, 100, 200);

            string tz = "Количество фурнитуры на складе";
            e.Graphics.DrawString(tz, new Font("Microsoft Sans Serif", 16, FontStyle.Bold), Brushes.Black, new Point(100, 450));

            Bitmap objBmp2 = new Bitmap(this.FrSc.Width, this.FrSc.Height);
            FrSc.DrawToBitmap(objBmp2, new Rectangle(0, 0, this.FrSc.Width, this.FrSc.Height));
            e.Graphics.DrawImage(objBmp2, 100, 500);

            string t1 = "Закупаемые товары - "+ ZakT.Text+"";
            e.Graphics.DrawString(t1, new Font("Microsoft Sans Serif", 16, FontStyle.Bold), Brushes.Black, new Point(100, 700));
            string t2 = "Их количество - " + KolT.Text + "";
            e.Graphics.DrawString(t2, new Font("Microsoft Sans Serif", 16, FontStyle.Bold), Brushes.Black, new Point(100, 750));
            string t3 = "Стоимость - " + CenT.Text + "";
            e.Graphics.DrawString(t3, new Font("Microsoft Sans Serif", 16, FontStyle.Bold), Brushes.Black, new Point(100, 800));
            
        }

        private void Print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
