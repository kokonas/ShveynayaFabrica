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
    public partial class IsdelieVipusk : Form
    {
        public static SqlConnection sqlConnect = new SqlConnection("Data Source=LAPTOP-562FH47J\\SQL2017;Initial Catalog=Fabrica;Integrated Security=True");
        public IsdelieVipusk()
        {
            InitializeComponent();
        }

        private void IsdelieVipusk_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginOut_button_Click(object sender, EventArgs e)
        {
             if(AvtorisForm.name == "Director")
            {
                this.Hide();
                DirektorForm DirForm = new DirektorForm();
                DirForm.Show();
            }
            if (AvtorisForm.name == "Menedger")
            {
                this.Hide();
                MenedgerForm usForm = new MenedgerForm();
                usForm.Show();
            }
            if (AvtorisForm.name == "user")
            {
                this.Hide();
                ZakazchicForm Zfr = new ZakazchicForm();
                Zfr.Show();
            }
        }

        //////////// Переменные ////////////
        private string ArtikIsdelia;
        private double tkShir, tkDlin, tkCen, tkPlosh; // переменные для ткани
        private string tkNaim, tkArt; // переменные для ткани
        private double frShir, frDlin, frCen, frKol; // переменные для фурнитуры
        private string frNaim, frArt; // переменные для фурнитуры
        ////////////////////////////////////

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        DataGridView SeeIsdFur = new DataGridView();
        DataGridView SeeIsdTkan = new DataGridView();

        private void IsdelieVipusk_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            SqlCommand cmd1 = sqlConnect.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from Isdelie";
            cmd1.ExecuteNonQuery();
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter(cmd1);
            da4.Fill(dt4);
            foreach (DataRow dr in dt4.Rows)
            {
                ArtikIsdelia = Convert.ToString(dr[0]);
                NasvanieLabel.Text = dr["Naimenovenie"].ToString();
                comboBox1.Items.Add(dr["Articul"].ToString());
            }
            sqlConnect.Close();

            SeeIsdFur.Columns.Add("col1", "ArticulFurnituri");
            SeeIsdFur.Columns.Add("col2", "Naimenovanie");
            SeeIsdFur.Columns.Add("col3", "Dlina");
            SeeIsdFur.Columns.Add("col4", "Shirina");
            SeeIsdFur.Columns.Add("col5", "Kolichestvo");
            SeeIsdFur.Columns.Add("col6", "Cena");
            SeeIsdFur.Location = new Point(ArIsOk.Location.X, ArIsOk.Location.Y + ArIsOk.Height + 50);
            SeeIsdFur.Size = new Size(650, 80);


            SeeIsdTkan.Columns.Add("col1", "ArticulTkani");
            SeeIsdTkan.Columns.Add("col2", "Naimenovanie");
            SeeIsdTkan.Columns.Add("col3", "Dlina");
            SeeIsdTkan.Columns.Add("col4", "Shirina");
            SeeIsdTkan.Columns.Add("col5", "Cena");
            SeeIsdTkan.Location = new Point(SeeIsdFur.Location.X, SeeIsdFur.Location.Y + SeeIsdFur.Height + 20);
            SeeIsdTkan.Size = new Size(560, 80);

        }

        


        private void ArIsOk_Click(object sender, EventArgs e)
        {

            sqlConnect.Open();

            ///////// Работа с тканями /////////
            SqlCommand cmd = sqlConnect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ArticulTkani, Shirina, Dlina from TkaniIsdekia where ArticulIsdelia = '"+ comboBox1.SelectedItem.ToString()+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                tkArt = dr[0].ToString();
                tkDlin = Convert.ToDouble(dr[1]);
                tkShir = Convert.ToDouble(dr[2]);
            }

            cmd.CommandText = "select Cena, Naimenovanie from Tkany where Articul = '" + tkArt + "'";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                tkCen = Convert.ToDouble(dr[0]);
                tkNaim = dr[1].ToString();
            }
            tkPlosh = tkDlin * tkShir;
            tkCen = tkPlosh * tkCen;
            

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ArticulFurnituri, Shirina, Dlina, Kolichestvo from FurnituraIsdelia where ArticulIsdelia = '" + comboBox1.SelectedItem.ToString() + "'";
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                frArt = dr[0].ToString();
                frShir = Convert.ToDouble(dr[1]);
                frDlin = Convert.ToDouble(dr[2]);
                frKol = Convert.ToDouble(dr[3]);
            }

            cmd.CommandText = "select Cena, Naimenovanie from Furnitura where Articul = '" + frArt + "'";
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                frCen = Convert.ToDouble(dr[0]);
                frNaim = dr[1].ToString();
            }
            frCen = frKol * frCen;

            SeeIsdFur.Rows.Add(frArt, frNaim, frDlin, frShir, frKol, frCen);
            this.Controls.Add(SeeIsdFur);

            tkDlin = tkDlin * 2;
            tkShir = tkShir * 2;
            tkCen = tkCen * 2;

            SeeIsdTkan.Rows.Add(tkArt, tkNaim, tkDlin, tkShir, tkCen);
            this.Controls.Add(SeeIsdTkan);

            sqlConnect.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string tx = "Состав изделия с артиклом " + comboBox1.SelectedItem.ToString() + "\nИмеющее название: "+ NasvanieLabel.Text+"";
            e.Graphics.DrawString(tx, new Font("Microsoft Sans Serif", 16, FontStyle.Bold), Brushes.Black, new Point(100, 95));

            Bitmap objBmp1 = new Bitmap(this.SeeIsdTkan.Width, this.SeeIsdTkan.Height);
            SeeIsdTkan.DrawToBitmap(objBmp1, new Rectangle(0, 0, this.SeeIsdTkan.Width, this.SeeIsdTkan.Height));
            e.Graphics.DrawImage(objBmp1, 100, 180);

            Bitmap objBmp2 = new Bitmap(this.SeeIsdFur.Width, this.SeeIsdFur.Height);
            SeeIsdFur.DrawToBitmap(objBmp2, new Rectangle(0, 0, this.SeeIsdFur.Width, this.SeeIsdFur.Height));
            e.Graphics.DrawImage(objBmp2, 100, 280);
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}