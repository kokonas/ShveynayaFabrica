using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{
    public partial class OstatokForm : Form
    {
        public static SqlConnection sqlConnect = new SqlConnection("Data Source=LAPTOP-562FH47J\\SQL2017;Initial Catalog=Fabrica;Integrated Security=True");
        public OstatokForm()
        {
            InitializeComponent();
        }

        private ComboBox comboBoxDin = new ComboBox();

        private void OstatokForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fabricaDataSet8.ObreskiTkani' table. You can move, or remove it, as needed.
            this.obreskiTkaniTableAdapter1.Fill(this.fabricaDataSet8.ObreskiTkani);
            // TODO: This line of code loads data into the 'fabricaDataSet7.ObreskiTkani' table. You can move, or remove it, as needed.
            this.obreskiTkaniTableAdapter.Fill(this.fabricaDataSet7.ObreskiTkani);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricaDataSet6.ScladTcani". При необходимости она может быть перемещена или удалена.
            this.scladTcaniTableAdapter.Fill(this.fabricaDataSet6.ScladTcani);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricaDataSet5.Tkany". При необходимости она может быть перемещена или удалена.
            this.tkanyTableAdapter.Fill(this.fabricaDataSet5.Tkany);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricaDataSet4.Furnitura". При необходимости она может быть перемещена или удалена.
            this.furnituraTableAdapter.Fill(this.fabricaDataSet4.Furnitura);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                sqlConnect.Open();
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Tkany";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {

                    comboBox2.Items.Add(dr["Articul"].ToString());
                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                sqlConnect.Open();
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Articul, Naimenovanie, Tip from Furnitura where Tip = 'Пуговица круглая' or Tip='пуговица'"; cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    NazvanieBox.Text = dr["Naimenovanie"].ToString();
                    comboBox2.Items.Add(dr["Articul"].ToString());
                }
            }

            if (comboBox1.SelectedIndex == 2)
            {
                sqlConnect.Open();
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Articul, Naimenovanie, Tip from Furnitura where Tip = 'Бусины, бисер' or Tip='Цепочка декоративная'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    NazvanieBox.Text = dr["Naimenovanie"].ToString();
                    comboBox2.Items.Add(dr["Articul"].ToString());
                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                sqlConnect.Open();
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Isdelie";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    NazvanieBox.Text = dr["Naimenovenie"].ToString();
                    comboBox2.Items.Add(dr["Articul"].ToString());
                }
            }

            List<string> list1 = new List<string>() { "Рулон", "м"};
            List<string> list2 = new List<string>() { "шт", "кг", "м²" };
            List<string> list3 = new List<string>() { "шт" };
            List<string> list4 = new List<string>() { "шт" };
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox3.DataSource = list1;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                comboBox3.DataSource = new BindingSource() { DataSource = list2 };
            }
            if (comboBox1.SelectedIndex == 2)
            {
                comboBox3.DataSource = new BindingSource() { DataSource = list3 };
            }
            if (comboBox1.SelectedIndex == 3)
            {
                comboBox3.DataSource = new BindingSource() { DataSource = list4 };
            }

            sqlConnect.Close();
        }

        private TextBox OstTex = new TextBox();
        private Label OstLab = new Label();
        private TextBox InBox = new TextBox();
        private TextBox InBoX = new TextBox();
        private Label LabSumm = new Label();
        private TextBox Setting = new TextBox();
        private Label PlK = new Label();
        private double Dlina, pglp;
        private double Cena, CenaPg, ves, vesKG, vesG, Ce1, PlPG, CnPg;
        private int x, y, kolpgv, Kl, SumPg, Kpg, kll;
        private double D;
        private string Rl, At, Tex, Pr, imag, ArIs;
        private double SumDln, Pl, P, Cen, CenObr, Cn, Obrz, Ploshad, O, K;

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();

            PictureBox img = new PictureBox();
            img.Location = new Point(Ok_Click.Location.X, Ok_Click.Location.Y + Ok_Click.Height + 260);
            img.AutoSize = true;

            SqlCommand cmdq = sqlConnect.CreateCommand();
            cmdq.CommandType = CommandType.Text;
            cmdq.CommandText = "select Isobrashenie from Tkany where Articul = '" + comboBox2.SelectedItem.ToString() + "'";
            cmdq.ExecuteNonQuery();
            DataTable dtq = new DataTable();
            SqlDataAdapter daq = new SqlDataAdapter(cmdq);
            daq.Fill(dtq);
            foreach (DataRow dr in dtq.Rows)
            {
                imag = dr[0].ToString();
                MessageBox.Show("" + imag);
                this.Controls.Add(img);
            }
            img.Image = new Bitmap(imag.ToString());
            sqlConnect.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private double Ob;
        private int Kol, obrez;
        private string ArtIs;

        private void Ok_Click_Click(object sender, EventArgs e)
        {
            // Создание динамических форм
            double val = 0.0;

            Label OstLaB = new Label();
            OstLaB.Location = new Point(Ok_Click.Location.X, Ok_Click.Location.Y + Ok_Click.Height + 120);
            OstLaB.Font = new Font("Times New Roman", (float)12, FontStyle.Bold);
            OstLaB.Width = 365;
            OstLaB.Height = 27;

            InBoX.Location = new Point(Ok_Click.Location.X + Ok_Click.Width + 215, Ok_Click.Location.Y + Ok_Click.Height + 120);
            InBoX.Font = new Font("Times New Roman", (float)12, FontStyle.Bold);
            InBoX.Width = 60;
            InBoX.Height = 27;


            //Label для отображения информации
            OstLab.Location = new Point(Ok_Click.Location.X, Ok_Click.Location.Y + Ok_Click.Height + 30);
            OstLab.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            OstLab.Width = NazvanieBox.Width;
            OstLab.Height = NazvanieBox.Height;


            Label OstLab1 = new Label();
            OstLab1.Location = new Point(Ok_Click.Location.X, Ok_Click.Location.Y + Ok_Click.Height + 60);
            OstLab1.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            OstLab1.Width = 358;
            OstLab1.Height = 27;

            

            Label Isd = new Label();
            Isd.Location = new Point(Ok_Click.Location.X, Ok_Click.Location.Y + Ok_Click.Height + 90);
            Isd.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            Isd.AutoSize = true;
            Isd.Text = "Выерите изделие:";

            
            comboBoxDin.Location = new Point(Isd.Location.X + Isd.Width + 20, Isd.Location.Y);
            comboBoxDin.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            comboBoxDin.AutoSize = true;
            

            //Button для отображение информации закупочной стоимости после ввода информации в TextBox
            Button SumButton = new Button();
            SumButton.Size = new Size(175, 30);
            SumButton.Location = new Point(Ok_Click.Location.X, Ok_Click.Location.Y + Ok_Click.Height + 160);
            SumButton.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            SumButton.Text = "Вычислить закупочную стоимость";
            SumButton.Click += new EventHandler(SumButton_Click);

            Label InLab = new Label();//Label для отображение информации
            InLab.Location = new Point(494, 337);
            InLab.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            sqlConnect.Open();
            // Операции с тканями
            
            if (comboBox1.SelectedIndex == 0 && comboBox3.SelectedIndex == 0) // comboBox1 = Ткани, comboBo3 = Рулон.
                {
                try
                {
                    PictureBox img = new PictureBox();
                    img.Location = new Point(Ok_Click.Location.X, Ok_Click.Location.Y + Ok_Click.Height + 245);
                    img.AutoSize = true;

                    SqlCommand cmdq = sqlConnect.CreateCommand();
                    cmdq.CommandType = CommandType.Text;
                    cmdq.CommandText = "select Isobrashenie from Tkany where Articul = '" + comboBox2.SelectedItem.ToString() + "'";
                    cmdq.ExecuteNonQuery();
                    DataTable dtq = new DataTable();
                    SqlDataAdapter daq = new SqlDataAdapter(cmdq);
                    daq.Fill(dtq);
                    foreach (DataRow dr in dtq.Rows)
                    {
                        imag = dr[0].ToString();
                        MessageBox.Show("" + imag);
                        img.Image = new Bitmap(imag.ToString());
                        this.Controls.Add(img);
                    }




                    Label OstSum = new Label();
                    OstSum.Location = new Point(Ok_Click.Location.X, Ok_Click.Location.Y + Ok_Click.Height + 90);
                    OstSum.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                    OstSum.Width = 325;
                    OstSum.Height = 27;

                    

                    SqlCommand cmd = sqlConnect.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select sum(Dlina*Shirina) from ScladTcani where ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        //label4.Text = dr["summa"].ToString();
                        val = Convert.ToDouble(dr[0]);
                        OstTex.Text = dr[0].ToString();
                        OstLaB.Text = "Введите количество метров используемой ткани ";
                        OstLab.Text = "На складе хранится " + val.ToString("F2") + " м² ткани.";
                        this.Controls.Add(OstLab);
                        this.Controls.Add(InBox);
                        this.Controls.Add(SumButton);
                        this.Controls.Add(InLab);
                        this.Controls.Add(OstLaB);
                        this.Controls.Add(InBoX);
                    }
                    cmd.CommandText = "select sum(Dlina) from ScladTcani where ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        Dlina = Convert.ToDouble(dr[0]);
                        SumDln = Convert.ToDouble(dr[0]);
                        //Dlina = val;
                        OstLab1.Text = "На остатках числится " + Dlina.ToString("F2") + " погонных метров ткани.";
                        this.Controls.Add(OstLab1);
                    }

                    cmd.CommandText = "select Cena * @Dlina from Tkany, ScladTcani where Articul = '" + comboBox2.SelectedItem.ToString() + "'";
                    SqlParameter valParam = new SqlParameter("@Dlina", Dlina);
                    cmd.Parameters.Add(valParam);

                    cmd.ExecuteNonQuery();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        Cena = Convert.ToDouble(dr[0]);
                        OstSum.Text = "На закупочную сумму" + Cena.ToString("F2") + " ₽.";
                        this.Controls.Add(OstSum);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Такого товара нет на складе");
                }
            }
            

            if (comboBox1.SelectedIndex == 0 && comboBox3.SelectedIndex == 1) // comboBox1 = Ткани, comboBox3 = м.
            {
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT SUM (Dlina) FROM ScladTcani WHERE ArticulTkani = '" + comboBox2.SelectedValue + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    OstLab.Text = "Результат";
                    OstTex.Text = dr[0].ToString();
                    this.Controls.Add(OstTex);
                    this.Controls.Add(OstLab);
                    this.Controls.Add(InBox);
                    this.Controls.Add(SumButton);
                    this.Controls.Add(InLab);
                }
            }

            if (comboBox1.SelectedIndex == 0 && comboBox3.SelectedIndex == 2) // comboBox1 = Ткани, comboBox3 = см.
            {
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT SUM (Dlina / 100) FROM ScladTcani  WHERE ArticulTkani = '" + comboBox2.SelectedValue + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    OstLab.Text = "Результат";
                    OstTex.Text = dr[0].ToString();
                    this.Controls.Add(OstTex);
                    this.Controls.Add(OstLab);
                    this.Controls.Add(InBox);
                    this.Controls.Add(SumButton);
                    this.Controls.Add(InLab);
                }
            }

            if (comboBox1.SelectedIndex == 0 && comboBox3.SelectedIndex == 3) //comboBox1 = Ткани, comboBox3 = мм.
            {
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT SUM (Dlina / 1000) FROM ScladTcani  WHERE ArticulTkani = '" + comboBox2.SelectedValue + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    OstLab.Text = "Результат";
                    OstTex.Text = dr[0].ToString();
                    this.Controls.Add(OstTex);
                    this.Controls.Add(OstLab);
                    this.Controls.Add(InBox);
                    this.Controls.Add(SumButton);
                    this.Controls.Add(InLab);
                }
            }

            /////////////////////////////////////////////////////////////////////////////
            //Операции с пуговицами
            if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 0) //comboBox1= Пуговицы, comboBox3 = шт.
            {

                Label OstSum = new Label();
                OstSum.Location = new Point(Ok_Click.Location.X, Ok_Click.Location.Y + Ok_Click.Height + 60);
                OstSum.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                OstSum.Width = 325;
                OstSum.Height = 27;

                TextBox NasvIs = new TextBox();
                NasvIs.Location = new Point(comboBoxDin.Location.X + comboBoxDin.Width + 20, comboBoxDin.Location.Y);
                NasvIs.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                NasvIs.AutoSize = true;

                this.Controls.Add(comboBoxDin);
                this.Controls.Add(NasvIs);

                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select sum(Kolichestvo) from SkladFurnituri  where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    kolpgv = Convert.ToInt32(dr[0]);
                    OstLaB.Text = "Введите количество штук используемых пуговиц ";
                    OstLab.Text = OstLab.Text = "На складе хранится " + kolpgv + " шт пуговиц.";
                    this.Controls.Add(OstTex);
                    this.Controls.Add(OstLab);
                    this.Controls.Add(InBox);
                    this.Controls.Add(SumButton);
                    this.Controls.Add(InLab);
                    this.Controls.Add(InBoX);
                    this.Controls.Add(OstLaB);
                }

                cmd.CommandText = "select Articul, Naimenovenie from Isdelie";
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    NasvIs.Text = dr["Naimenovenie"].ToString();
                    comboBoxDin.Items.Add(dr["Articul"].ToString());
                }

                cmd.CommandText = "select Cena from Furnitura where Articul = '" + comboBox2.SelectedItem.ToString() + "'";
                SqlParameter kolParam = new SqlParameter("@kolpgv", kolpgv);
                cmd.Parameters.Add(kolParam);
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    CenaPg = Convert.ToDouble(dr[0]);
                    Ce1 = CenaPg * kolpgv;
                    //MessageBox.Show("CenaPg = " + CenaPg);
                    OstSum.Text = "На закупочную сумму" + Ce1.ToString() + " ₽.";
                    this.Controls.Add(OstSum);
                }

                
            }

            if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 1) //comboBox1= Пуговицы, comboBox3 = кг.
            {
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select sum(Kolichestvo) from SkladFurnituri  where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    kolpgv = Convert.ToInt32(dr[0]);
                }

                cmd.CommandText = "SELECT Ves FROM Furnitura WHERE Articul = '" + comboBox2.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ves = Convert.ToDouble(dr[0]);
                }
                vesKG = kolpgv * ves;
                OstLab.Text = OstLab.Text = "На складе хранится " + vesKG + " кг пуговиц.";
                this.Controls.Add(OstLab);
            }

            if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 2) //comboBox1= Пуговицы, comboBox3 = м в квадрате.
            {
                Label LbInf = new Label();
                LbInf.Location = new Point(label5.Location.X, label5.Location.Y + label5.Height + 55);
                LbInf.Font = new Font("Times New Roman", (float)12, FontStyle.Bold);
                LbInf.AutoSize = true;
                LbInf.Text = "Введите условие перехода товара в состояние остатков:";

                Setting.Location = new Point(LbInf.Location.X, LbInf.Location.Y + LbInf.Height + 15);
                Setting.Font = new Font("Times New Roman", (float)12, FontStyle.Bold);
                Setting.Width = 30;
                Setting.Height = 27;

                Button DelButton = new Button();
                DelButton.Size = new Size(175, 30);
                DelButton.Location = new Point(label5.Location.X, label5.Location.Y + label5.Height + 140);
                DelButton.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                DelButton.Text = "Вычислить закупочную стоимость";
                DelButton.Click += new EventHandler(DelButton_Click);

                this.Controls.Add(DelButton);
                this.Controls.Add(Setting);
                this.Controls.Add(LbInf);

                

                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Shirina * Dlina from Furnitura where Articul = '" + comboBox2.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    pglp = Convert.ToDouble(dr[0]);
                    
                    OstTex.Text = dr[0].ToString();
                    
                }

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select sum(Kolichestvo) from SkladFurnituri  where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    kolpgv = Convert.ToInt32(dr[0]);
                }
                OstLab.Text = OstLab.Text = "На складе хранится " + kolpgv * pglp + " м² данной фурнитуры.";
                this.Controls.Add(OstLab);

                
            }

            ////////////////////////////////////////////////////////////////////////////
            //Операции с украшениями
            if (comboBox1.SelectedIndex == 2 && comboBox3.SelectedIndex == 0) //comboBox1= Пуговицы, comboBox3 = кг.
            {
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT  SUM(Kolichestvo) FROM SkladFurnituri  WHERE ArticulFurnituri = '" + comboBox2.SelectedValue + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    OstLab.Text = "Результат";
                    OstTex.Text = dr[0].ToString();
                    SumPg = Convert.ToInt32(dr[0]);
                    this.Controls.Add(OstTex);
                    this.Controls.Add(OstLab);
                    this.Controls.Add(InBox);
                    this.Controls.Add(SumButton);
                    this.Controls.Add(InLab);
                }
            }

            sqlConnect.Close();
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnect.Open();
            if (comboBox1.SelectedIndex == 0)
            {
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Tkany where Articul = '" + comboBox2.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    NazvanieBox.Text = dr["Naimenovanie"].ToString();
                }
            }

            if (comboBox1.SelectedIndex == 1)
            {

                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Naimenovanie from Furnitura  where Articul = '" + comboBox2.SelectedValue + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    NazvanieBox.Text = dr["Naimenovanie"].ToString();
                }
            }

            if (comboBox1.SelectedIndex == 2)
            {

                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Naimenovanie from Furnitura  where Articul = '" + comboBox2.SelectedValue + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    NazvanieBox.Text = dr["Naimenovanie"].ToString();
                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Naimenovenie FROM Isdelie  WHERE Articul = '" + comboBox2.SelectedValue + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    NazvanieBox.Text = dr["Naimenovanie"].ToString();
                }
            }
            sqlConnect.Close();
        }


        private void SumButton_Click(object sender, EventArgs e)
        {
            

            Button Sale = new Button();
            Sale.Size = new Size(175, 30);
            Sale.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            Sale.Location = new Point(Ok_Click.Location.X, Ok_Click.Location.Y + Ok_Click.Height + 230);
            Sale.Text = "Продажа";
            Sale.Click += new EventHandler(Sale_Click);


            LabSumm.Location = new Point(Ok_Click.Location.X, Ok_Click.Location.Y + Ok_Click.Height + 200);
            LabSumm.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            LabSumm.Width = 400;
            LabSumm.Height = 27;


            /*Controls.Contains(OstTex);//удаление элемента
            OstTex.Dispose();
            Controls.Contains(OstLab);
            OstLab.Dispose();*/

           

            if (comboBox1.SelectedIndex == 0)
            {

                    LabSumm.Text = "Закупочная стоимость равна " + Cena * (Convert.ToDouble(InBoX.Text)) / Dlina + " рублей";
                    this.Controls.Add(LabSumm);
                    this.Controls.Add(Sale);
                
            }

            if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 0)
            {
                    double I = Convert.ToDouble(InBoX.Text);
                double Pg;
                Pg = CenaPg * I;

                ArtIs = comboBoxDin.SelectedItem.ToString();

                LabSumm.Text = "Закупочная стоимость равна " + Pg + " рублей";
                    this.Controls.Add(LabSumm);
                    this.Controls.Add(Sale);
            } 
            
            if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 1)
            {
                double I = Convert.ToDouble(InBoX.Text);
                double Pg;
                Pg = CenaPg * I;


                LabSumm.Text = "Закупочная стоимость равна " + Pg + " рублей";
                this.Controls.Add(LabSumm);
                this.Controls.Add(Sale);
            }
        }

        private void Sale_Click(object sender, EventArgs e)
        {
            Label LbInf = new Label();
            LbInf.Location = new Point(label5.Location.X, label5.Location.Y + label5.Height + 55);
            LbInf.Font = new Font("Times New Roman", (float)12, FontStyle.Bold);
            LbInf.AutoSize = true;

            
            PlK.Location = new Point(Ok_Click.Location.X, Ok_Click.Location.Y + Ok_Click.Height + 260);
            PlK.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            PlK.Width = 400;
            PlK.Height = 27;

            Setting.Location = new Point(LbInf.Location.X, LbInf.Location.Y + LbInf.Height + 15);
            Setting.Font = new Font("Times New Roman", (float)12, FontStyle.Bold);
            Setting.Width = 30;
            Setting.Height = 27;

            Button DelButton = new Button();
            DelButton.Size = new Size(175, 30);
            DelButton.Location = new Point(label5.Location.X, label5.Location.Y + label5.Height + 140);
            DelButton.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            DelButton.Text = "Вычислить закупочную стоимость";
            DelButton.Click += new EventHandler(DelButton_Click);

            sqlConnect.Open();
            if (comboBox1.SelectedIndex == 0)
            {
                this.Controls.Add(DelButton);
                this.Controls.Add(Setting);
                this.Controls.Add(LbInf);

                double In = Convert.ToDouble(InBoX.Text);
                LbInf.Text = "Введите условие перехода товара в состояние обрезков:";

                SqlCommand cmd1 = sqlConnect.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select Shirina*Dlina from TkaniIsdekia where ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "'";
                cmd1.ExecuteNonQuery();
                DataTable dt4 = new DataTable();
                SqlDataAdapter da4 = new SqlDataAdapter(cmd1);
                da4.Fill(dt4);
                foreach (DataRow dr in dt4.Rows)
                {
                    Ob = Convert.ToDouble(dr[0]);
                }

                cmd1.CommandText = "select ArticulIsdelia from TkaniIsdekia where ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "'";
                cmd1.ExecuteNonQuery();
                dt4 = new DataTable();
                da4 = new SqlDataAdapter(cmd1);
                da4.Fill(dt4);
                foreach (DataRow dr in dt4.Rows)
                {
                    At = dr[0].ToString();
                }

                cmd1.CommandText = "select Shirina from ScladTcani where ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "'";
                cmd1.ExecuteNonQuery();
                dt4 = new DataTable();
                da4 = new SqlDataAdapter(cmd1);
                da4.Fill(dt4);
                foreach (DataRow dr in dt4.Rows)
                {
                    Pl = Convert.ToDouble(dr[0]);
                }

                Ploshad = Pl * In;
                P = Ploshad / Ob;
                Kol = (int)P;
                K = Ploshad % Ob;
                O = Kol * Ob;
                Obrz = Ploshad - O;
                obrez = (int)Obrz;

                cmd1.CommandText = "select Cena from Tkany where Articul = '" + comboBox2.SelectedItem.ToString() + "'";
                cmd1.ExecuteNonQuery();
                dt4 = new DataTable();
                da4 = new SqlDataAdapter(cmd1);
                da4.Fill(dt4);
                foreach (DataRow dr in dt4.Rows)
                {
                    Cn = Convert.ToDouble(dr[0]);
                }

                Cen = O * Cn;


                cmd1.CommandText = "update Isdelie set Kolichestvo = " + Kol + " where Articul = '" + At + "'";
                cmd1.ExecuteNonQuery();
                dt4 = new DataTable();
                da4 = new SqlDataAdapter(cmd1);
                da4.Fill(dt4);
                foreach (DataRow dr in dt4.Rows)
                {
                    Kol = Convert.ToInt32(dr[0]);
                }

                cmd1.CommandText = "select Cena from Tkany where Articul = '" + comboBox2.SelectedItem.ToString() + "'";
                cmd1.ExecuteNonQuery();
                dt4 = new DataTable();
                da4 = new SqlDataAdapter(cmd1);
                da4.Fill(dt4);
                foreach (DataRow dr in dt4.Rows)
                {
                    Cn = Convert.ToDouble(dr[0]);
                }

                CenObr = K * Cn;

                cmd1.CommandText = "insert into ObreskiTkani(ArticulTkani, Ploshad, Cena, PloshadObrezka, CenaObrezka) values (" + comboBox2.SelectedItem.ToString() + ", " + O + ", " + Cen + ", " + K + ", " + CenObr + ")";
                cmd1.ExecuteNonQuery();
                

                if (In <= SumDln)
                {
                    SqlCommand cmd = sqlConnect.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select min(Dlina), max(Rulon) from ScladTcani where ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "' and Dlina = (select min(Dlina) from ScladTcani where ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "')";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        D = Convert.ToDouble(dr[0]);
                        Rl = dr[1].ToString();
                    }

                    while (D <= In)
                    {

                        In = In - D;

                        cmd.CommandText = "delete from ScladTcani where Rulon = '"  + Rl + "' and ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "'";
                        cmd.ExecuteNonQuery();
                        DataTable dt3 = new DataTable();
                        SqlDataAdapter da3 = new SqlDataAdapter(cmd);
                        da3.Fill(dt3);
                        foreach (DataRow dr in dt3.Rows)
                        {
                        }

                        cmd.CommandText = "select min(Dlina), max(Rulon) from ScladTcani where ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "' and Dlina = (select min(Dlina) from ScladTcani where ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "')";
                        cmd.ExecuteNonQuery();
                        DataTable dt1 = new DataTable();
                        SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                        da1.Fill(dt1);
                        foreach (DataRow dr in dt1.Rows)
                        {
                            D = Convert.ToDouble(dr[0]);
                            Rl = dr[1].ToString();
                        }
                    }

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select max(Rulon), min(Dlina) from ScladTcani where ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "' and Dlina = (select min(Dlina) from ScladTcani where ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "')";
                    cmd.ExecuteNonQuery();
                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                    da2.Fill(dt2);
                    foreach (DataRow dr in dt2.Rows)
                    {
                        //Dl = dr[1].ToString();
                        D = Convert.ToDouble(dr[1]);
                        Rl = dr[0].ToString();

                    }

                    D = D - In;

                    MessageBox.Show("D = " + D + ", In=" + In);

                    cmd.CommandText = "update ScladTcani set Dlina = @DL where Rulon = " + Rl + " and ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "'";
                    SqlParameter InParam = new SqlParameter("@DL", D);
                    cmd.Parameters.Add(InParam);
                    cmd.ExecuteNonQuery();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                    }

                    MessageBox.Show("Продано!");
                }
                else
                {
                    MessageBox.Show("На складе не имеется " + In + " метров выбранной ткани!");
                }

            }

            if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 0)
            {
               try
                {


                    int Inp = Convert.ToInt32(InBoX.Text);
                    kll = Inp;
                    //LbInf.Text = "Введите условие перехода товара в состояние остатков:";

                    SqlCommand cmd1 = sqlConnect.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select Shirina*Dlina from Furnitura where Articul = '" + comboBox2.SelectedItem.ToString() + "'";
                    cmd1.ExecuteNonQuery();
                    DataTable dt4 = new DataTable();
                    SqlDataAdapter da4 = new SqlDataAdapter(cmd1);
                    da4.Fill(dt4);
                    foreach (DataRow dr in dt4.Rows)
                    {
                        PlPG = Convert.ToDouble(dr[0]);
                    }

                    PlK.Text = "Площадь используемой фурнитуры равна = " + Inp * PlPG + "";
                    this.Controls.Add(PlK);

                    {
                        cmd1.CommandText = "select ArticulIsdelia from FurnituraIsdelia where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "'";
                        cmd1.ExecuteNonQuery();
                        dt4 = new DataTable();
                        da4 = new SqlDataAdapter(cmd1);
                        da4.Fill(dt4);
                        foreach (DataRow dr in dt4.Rows)
                        {
                            ArIs = dr[0].ToString();
                        }

                        cmd1.CommandText = "select sum(Kolichestvo) from SkladFurnituri where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "'";
                        cmd1.ExecuteNonQuery();
                        dt4 = new DataTable();
                        da4 = new SqlDataAdapter(cmd1);
                        da4.Fill(dt4);
                        foreach (DataRow dr in dt4.Rows)
                        {
                            Kpg = Convert.ToInt32(dr[0]);
                        }

                        SqlCommand cmd = sqlConnect.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select min(Kolichestvo), max(Partia) from SkladFurnituri where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "' and Kolichestvo = (select min(Kolichestvo) from SkladFurnituri where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "')";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        foreach (DataRow dr in dt.Rows)
                        {

                            Kl = Convert.ToInt32(dr[0]);
                            Pr = dr[1].ToString();
                        }

                        while (Kl <= Inp)
                        {

                            Inp = Inp - Kl;

                            cmd.CommandText = "delete from SkladFurnituri where Partia = '"+Pr+"'  and ArticulFurnituri = " + comboBox2.SelectedItem.ToString() + "";
                            cmd.ExecuteNonQuery();
                            DataTable dt3 = new DataTable();
                            SqlDataAdapter da3 = new SqlDataAdapter(cmd);
                            da3.Fill(dt3);
                            foreach (DataRow dr in dt3.Rows)
                            {
                            }

                            cmd.CommandText = "select min(Kolichestvo), max(Partia) from SkladFurnituri where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "' and Kolichestvo = (select min(Kolichestvo) from SkladFurnituri where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "')";
                            cmd.ExecuteNonQuery();
                            DataTable dt1 = new DataTable();
                            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                            da1.Fill(dt1);
                            foreach (DataRow dr in dt1.Rows)
                            {

                                Kl = Convert.ToInt32(dr[0]);
                                Pr = dr[1].ToString();
                            }
                            MessageBox.Show("!");
                        }

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select max(Partia), min(Kolichestvo) from SkladFurnituri where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "' and Kolichestvo = (select min(Kolichestvo) from SkladFurnituri where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "')";
                        cmd.ExecuteNonQuery();
                        DataTable dt2 = new DataTable();
                        SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                        da2.Fill(dt2);
                        foreach (DataRow dr in dt2.Rows)
                        {

                            Kl = Convert.ToInt32(dr[1]);
                            Pr = dr[0].ToString();
                        }

                        Kl = Kl - Inp;

                        MessageBox.Show("Kl = " + Kl + ", In =" + Inp);

                        cmd.CommandText = "update SkladFurnituri set Kolichestvo = @KL where Partia = " + Pr + " and ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "'";
                        SqlParameter InParam = new SqlParameter("@KL", Kl);
                        cmd.Parameters.Add(InParam);
                        cmd.ExecuteNonQuery();
                        da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        foreach (DataRow dr in dt.Rows)
                        {
                        }
                        MessageBox.Show("Продано!");

                    }

                    cmd1.CommandText = "insert into FurnituraIsdelia (ArticulFurnituri, ArticulIsdelia, Kolichestvo) values ('" + comboBox2.SelectedItem.ToString() + "', '" + comboBoxDin.SelectedItem.ToString() + "', " + Inp + ")"; //
                    cmd1.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Данный вид фурнитуры уже используется для выбранного изделия!");
                }
                
            }
            
            if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 1)
            {
                double Inpl = Convert.ToInt32(InBoX.Text);
                
                
            }

            sqlConnect.Close();
        }

        private int ArtTk, Smm, Os;
        private int ArtPg, Smmp, Osp, Smpm;
        private double Set, Ch, Cna, Obr, Cnap, Plos;
        private int Setp, Chp, Ostp;
        private string image;
        private double Osplh;


        private void DelButton_Click(object sender, EventArgs e)
        {
                sqlConnect.Open();

                

                Label InfCena = new Label();
                InfCena.Location = new Point(label5.Location.X, label5.Location.Y + label5.Height + 175);
                InfCena.Font = new Font("Times New Roman", (float)12, FontStyle.Bold);
                InfCena.Width = 365;
                InfCena.Height = 27;

                Label InfPls = new Label();
                InfPls.Location = new Point(label5.Location.X, label5.Location.Y + label5.Height + 195);
                InfPls.Font = new Font("Times New Roman", (float)12, FontStyle.Bold);
                InfPls.Width = 365;
                InfPls.Height = 27;

                DataGridView ObrzTabl = new DataGridView();
                ObrzTabl.Location = new Point(label5.Location.X, label5.Location.Y + label5.Height + 240);
                ObrzTabl.DataSource = obreskiTkaniBindingSource1;
                ObrzTabl.Width = 443;
                ObrzTabl.Height = 208;

                if (comboBox1.SelectedIndex == 0)
                {
                    Set = Convert.ToDouble(Setting.Text);
                    try
                    {
                        SqlCommand cmd = sqlConnect.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select count(*) from ObreskiTkani where ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "'";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        foreach (DataRow dr in dt.Rows)
                        {
                            ArtTk = Convert.ToInt32(dr[0]);
                        }
                        MessageBox.Show("Количество столбцов с артикулом " + comboBox2.SelectedItem.ToString() + "= " + ArtTk);

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select min(PloshadObrezka), max(IdOstatok) from ObreskiTkani where ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "' and PloshadObrezka = (select min(PloshadObrezka) from ObreskiTkani where ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "')";
                        cmd.ExecuteNonQuery();
                        DataTable dt1 = new DataTable();
                        SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                        da1.Fill(dt1);
                        foreach (DataRow dr in dt1.Rows)
                        {
                            Ch = Convert.ToDouble(dr[0]);
                            Os = Convert.ToInt32(dr[1]);
                        }
                        MessageBox.Show("Ch =" + Ch + "Os = " + Os);

                        while (Smm <= ArtTk)
                        {

                            if (Ch <= Set)
                            {
                                MessageBox.Show("Ch =" + Ch + "Os = " + Os);

                                cmd.CommandText = "select PloshadObrezka, CenaObrezka from ObreskiTkani where IdOstatok = '" + Os + "' and ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "'";
                                cmd.ExecuteNonQuery();
                                dt1 = new DataTable();
                                da1 = new SqlDataAdapter(cmd);
                                da1.Fill(dt1);
                                foreach (DataRow dr in dt1.Rows)
                                {
                                    Obr = Convert.ToDouble(dr[0]);
                                    Cna = Convert.ToDouble(dr[1]);
                                }

                                Obr = Obr + Obr;
                                Cna = Cna + Cna;

                                cmd.CommandText = "delete ObreskiTkani where IdOstatok = '" + Os + "' and ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "'";
                                cmd.ExecuteNonQuery();
                                da = new SqlDataAdapter(cmd);
                                da.Fill(dt);
                                foreach (DataRow dr in dt.Rows)
                                {
                                }
                            }
                            Smm = Smm + 1;

                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "select min(PloshadObrezka), Max(IdOstatok) from ObreskiTkani where ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "' and PloshadObrezka = (select min(PloshadObrezka) from ObreskiTkani where ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "')";
                            cmd.ExecuteNonQuery();
                            dt1 = new DataTable();
                            da1 = new SqlDataAdapter(cmd);
                            da1.Fill(dt1);
                            foreach (DataRow dr in dt1.Rows)
                            {
                                Ch = Convert.ToDouble(dr[0]);
                                Os = Convert.ToInt32(dr[1]);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Обрезки такого типа отстуствуют на складе!");
                    }
                InfCena.Text = "Цена списанных обрезков равна = " + Cna + "";
                InfPls.Text = "Сумма их длин равна = " + Obr + "";
                this.Controls.Add(InfPls);
                this.Controls.Add(InfCena);
                this.Controls.Add(ObrzTabl);
            }

            {
                /* if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 0)
                    {
                    Setp = Convert.ToInt32(Setting.Text);
                        SqlCommand cmd = sqlConnect.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select count(*) from OstatkiFurnituri where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "'";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        foreach (DataRow dr in dt.Rows)
                        {
                            ArtPg = Convert.ToInt32(dr[0]);
                        }
                        MessageBox.Show("Количество столбцов с артикулом " + comboBox2.SelectedItem.ToString() + "= " + ArtPg);

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select min(OstatKolichestvo), max(IdOstatok) from OstatkiFurnituri where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "' and OstatKolichestvo = (select min(OstatKolichestvo) from OstatkiFurnituri where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "')";
                    cmd.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                    da1.Fill(dt1);
                    foreach (DataRow dr in dt1.Rows)
                    {
                        Chp = Convert.ToInt32(dr[0]);
                        Osp = Convert.ToInt32(dr[1]);
                    }

                    MessageBox.Show("Chp =" + Chp + "Osp = " + Osp);

                    while (Smmp <= ArtPg)
                    {

                        if (Chp <= Setp)
                        {
                            MessageBox.Show("Chp =" + Chp + "Osp = " + Osp);

                            cmd.CommandText = "select OstatKolichestvo, OstatCena from OstatkiFurnituri where IdOstatok = '" + Osp + "' and ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "'";
                            cmd.ExecuteNonQuery();
                            dt1 = new DataTable();
                            da1 = new SqlDataAdapter(cmd);
                            da1.Fill(dt1);
                            foreach (DataRow dr in dt1.Rows)
                            {
                                Ostp = Convert.ToInt32(dr[0]);
                                Cnap = Convert.ToDouble(dr[1]);
                            }

                            Ostp = Ostp + Ostp;
                            Cnap = Cnap + Cnap;

                            cmd.CommandText = "delete OstatkiFurnituri where IdOstatok = '"+ Osp + "' and ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "'";
                            cmd.ExecuteNonQuery();
                            da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                            foreach (DataRow dr in dt.Rows)
                            {
                            }
                        }
                        Smmp = Smmp + 1;

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select min(OstatKolichestvo), Max(IdOstatok) from OstatkiFurnituri where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "' and OstatKolichestvo = (select min(OstatKolichestvo) from OstatkiFurnituri where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "')";
                        cmd.ExecuteNonQuery();
                        dt1 = new DataTable();
                        da1 = new SqlDataAdapter(cmd);
                        da1.Fill(dt1);
                        foreach (DataRow dr in dt1.Rows)
                        {
                            Chp = Convert.ToInt32(dr[0]);
                            Osp = Convert.ToInt32(dr[1]);
                        }
                    }
                InfCena.Text = "Цена списаной фурнитуры равна = " + Cnap + "";
                InfPls.Text = "Их количество = " + Ostp + " шт.";
                this.Controls.Add(InfPls);
                this.Controls.Add(InfCena);
            }

                if (comboBox1.SelectedIndex == 1 && comboBox3.SelectedIndex == 2)
                {
                Plos = Convert.ToDouble(Setting.Text);

                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select count(*) from OstatkiFurnituri where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                    {
                    ArtPg = Convert.ToInt32(dr[0]);
                    }
                MessageBox.Show("Количество столбцов с артикулом " + comboBox2.SelectedItem.ToString() + "= " + ArtPg);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select min(OstatPloshad), max(IdOstatok) from OstatkiFurnituri where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "' and OstatPloshad = (select min(OstatPloshad) from OstatkiFurnituri where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "')";
                cmd.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                da1.Fill(dt1);
                foreach (DataRow dr in dt1.Rows)
                {
                    Plos = Convert.ToDouble(dr[0]);
                    Osp = Convert.ToInt32(dr[1]);
                }

                while (Smmp <= ArtPg)
                {

                    if (Chp <= Setp)
                    {
                        MessageBox.Show("Chp =" + Chp + "Osp = " + Osp);

                        cmd.CommandText = "select OstatPloshad, OstatCena from OstatkiFurnituri where IdOstatok = '" + Osp + "' and ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "'";
                        cmd.ExecuteNonQuery();
                        dt1 = new DataTable();
                        da1 = new SqlDataAdapter(cmd);
                        da1.Fill(dt1);
                        foreach (DataRow dr in dt1.Rows)
                        {
                            Osplh = Convert.ToDouble(dr[0]);
                            Cnap = Convert.ToDouble(dr[1]);
                        }

                        Osplh = Osplh + Osplh;
                        Cnap = Cnap + Cnap;


                        cmd.CommandText = "delete OstatkiFurnituri where IdOstatok = '" + Osp + "' and ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "'";
                        cmd.ExecuteNonQuery();
                        da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        foreach (DataRow dr in dt.Rows)
                        {
                        }
                    }
                    Smmp = Smmp + 1;

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select min(OstatPloshad), Max(IdOstatok) from OstatkiFurnituri where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "' and OstatPloshad = (select min(OstatPloshad) from OstatkiFurnituri where ArticulFurnituri = '" + comboBox2.SelectedItem.ToString() + "')";
                    cmd.ExecuteNonQuery();
                    dt1 = new DataTable();
                    da1 = new SqlDataAdapter(cmd);
                    da1.Fill(dt1);
                    foreach (DataRow dr in dt1.Rows)
                    {
                        Osplh = Convert.ToInt32(dr[0]);
                        Osp = Convert.ToInt32(dr[1]);
                    }
                }
                InfCena.Text = "Цена списаной фурнитуры равна = " + Cnap + "";
                InfPls.Text = "Сумма её площади = " + Osplh + "";
                this.Controls.Add(InfPls);
                this.Controls.Add(InfCena);
            }
                 */
            }

            SqlCommand cmd8 = sqlConnect.CreateCommand();
                    cmd8.CommandType = CommandType.Text;
                    cmd8.CommandText = "select Isobrashenie from Tkany where Articul = '" + comboBox2.SelectedItem.ToString() + "'";
                    cmd8.ExecuteNonQuery();
                    DataTable dt8 = new DataTable();
                    SqlDataAdapter da8 = new SqlDataAdapter(cmd8);
                    da8.Fill(dt8);
                    foreach (DataRow dr in dt8.Rows)
                    {
                        image = Convert.ToString(dr[0]);
                    }

                    
                    
                    PictureBox Block = new PictureBox();
                    //Image im = Image.FromFile(image);
                    //Block.Image = im;
                    Block.Location = new Point(label5.Location.X, label5.Location.Y + label5.Height + 270);
                    Block.AutoSize = true;
                
            
            sqlConnect.Close();
        }
           


        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void OstatokForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButt_Click(object sender, EventArgs e)
        {
            if (AvtorisForm.name == "Direcktor")
            {
                this.Hide();
                DirektorForm usForm = new DirektorForm();
                usForm.Show();
            }
            if (AvtorisForm.name == "Menedger")
            {
                this.Hide();
                MenedgerForm usForm = new MenedgerForm();
                usForm.Show();
            }
        }

        private void NazvanieBox_TextChanged(object sender, EventArgs e)
        {

        }
    }  
}