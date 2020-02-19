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
    public partial class Setting_TkaniForm : Form
    {
        public static SqlConnection sqlConnect = new SqlConnection("Data Source=LAPTOP-562FH47J\\SQL2017;Initial Catalog=Fabrica;Integrated Security=True");
        public Setting_TkaniForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnect.Open();
            comboBox2.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
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
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Articul, Naimenovanie, Tip from Furnitura where Tip = 'Пуговица круглая' or Tip='пуговица'";
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

        private double Set, Ch, Cen, Dl, Cena;
        private int Sum, Art;
        private double Sm;
        private string Rl;
        private int I = 0;

        private void SettingButt_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            Set = Convert.ToDouble(SettBox.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select count(*) from ScladTcani where ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Art = Convert.ToInt32(dr[0]);
                }

                MessageBox.Show("Количество столбцов с артикулом " + comboBox2.SelectedItem.ToString() + "= " + Art);

                while (Sum <= Art)
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select min(Dlina*Shirina), min(Dlina) from ScladTcani where ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                    da1.Fill(dt1);
                    foreach (DataRow dr in dt1.Rows)
                    {
                        Ch = Convert.ToDouble(dr[0]);
                        Dl = Convert.ToDouble(dr[1]);
                    }

                    cmd.CommandText = "select Cena from Tkany, ScladTcani where Articul = '" + comboBox2.SelectedItem.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        Cen = Convert.ToDouble(dr[0]);
                    }
                    Cena = Cen * Ch;

                    if (Ch <= Set)
                    {
                        cmd.CommandText = "insert into ObreskiTkani(ArticulTkani, Ploshad, Cena) values (" + comboBox2.SelectedItem.ToString() + ", " + Ch + ", " + Cena + ")";
                        cmd.ExecuteNonQuery();
                        dt = new DataTable();
                        da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        foreach (DataRow dr in dt.Rows)
                        {
                        }

                        cmd.CommandText = "delete ScladTcani where Dlina = '" + Dl + "' and ArticulTkani = '" + comboBox2.SelectedItem.ToString() + "'";
                        cmd.ExecuteNonQuery();
                        da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        foreach (DataRow dr in dt.Rows)
                        {
                        }
                        //MessageBox.Show("Зашло!");
                    }
                    Sum = Sum + 1;
                }
                MessageBox.Show("Не зашло! Sum = "+ Sum);
            }
            sqlConnect.Close();
        }


    }
}

