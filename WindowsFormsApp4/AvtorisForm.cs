    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Библиотека для работы с БД

namespace WindowsFormsApp4
{
    public partial class AvtorisForm : Form
    {
        public static String name;

        public AvtorisForm()
        {
            InitializeComponent();

        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            this.Hide(); //cкрывает текущее окно
            RegisterForm regForm = new RegisterForm(); 
            regForm.Show();
        }
        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //при нажатии на крестик приложение закрывается
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            

            SqlConnection sqlConnect = new SqlConnection("Data Source=LAPTOP-562FH47J\\SQL2017;Initial Catalog=Fabrica;Integrated Security=True"); //Подключение к серверу БД
            sqlConnect.Open();
            SqlCommand sqlQuery = new SqlCommand("SELECT * FROM [dbo].[Polsovatel]" +
                                                 "WHERE Login = '" + textLogin.Text + "' AND " +
                                                 "Password = '" + textPassword.Text + "'", sqlConnect); // запрос в таблицу "Polsovatel"
            SqlDataReader sqlReader = null;
            sqlReader = sqlQuery.ExecuteReader();
            if (sqlReader.HasRows)
            {
                sqlReader.Read();

                if ((sqlReader.GetValue(0).ToString() == textLogin.Text) &&
                    (sqlReader.GetValue(1).ToString() == textPassword.Text))
                {

                    if (sqlReader.GetValue(2).ToString() == "Kladovshic")
                    {
                        name = "Kladovshic";
                        this.Hide();//скрывает окно
                        KladovshicForm usForm = new KladovshicForm();
                        usForm.Show();
                    }
                    if (sqlReader.GetValue(2).ToString() == "Direcktor")
                    {
                        name = "Direcktor";
                        this.Hide();
                        DirektorForm usForm = new DirektorForm();
                        usForm.Show();
                    }
                    if (sqlReader.GetValue(2).ToString() == "Menedger")
                    {
                        name = "Menedger";
                        this.Hide();
                        MenedgerForm usForm = new MenedgerForm();
                        usForm.Show();
                    }
                    if (sqlReader.GetValue(2).ToString() == "user")
                    {
                        name = "user";
                        this.Hide();
                        ZakazchicForm usForm = new ZakazchicForm();
                        usForm.Show();
                    }                  
                }


            }
            else
            {
                MessageBox.Show("Такого пользователя не существует. Пересоздайте или введи заново.");
            }
        
            
        }   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AvtorisForm_Load(object sender, EventArgs e)
        {

        }

        private void AvtorisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
