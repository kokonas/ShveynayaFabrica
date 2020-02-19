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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnect = new SqlConnection("Data Source=LAPTOP-562FH47J\\SQL2017;Initial Catalog=Fabrica;Integrated Security=True");
                sqlConnect.Open();
                SqlCommand queryInsert = new SqlCommand("INSERT INTO [dbo].[Polsovatel] (Login, Password, Pol, Naimenovenie)" +
                                                        "VALUES ('" + textLogin.Text + "','" + textPassword.Text + "','user','" + textInitials.Text + "')", sqlConnect);

                if (!string.IsNullOrEmpty(textLogin.Text) && !string.IsNullOrWhiteSpace(textLogin.Text)
                && !string.IsNullOrEmpty(textPassword.Text) && !string.IsNullOrWhiteSpace(textPassword.Text)
                )
                {
                    queryInsert.ExecuteNonQuery();
                    sqlConnect.Close();
                    MessageBox.Show("Вы создали пользователя!");
                    this.Hide(); //cкрывает текущее окно
                    ZakazchicForm regForm = new ZakazchicForm();
                    regForm.Show();
                }
                else
                {
                    MessageBox.Show("Все обязательные поля не заполнены. Пользователь не создан!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пользователь с таким логином существует в системе.", ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Clousing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //при нажатии на крестик приложение закрывается
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide(); //cкрывает текущее окно
            AvtorisForm regForm = new AvtorisForm();
            regForm.Show();
        }
    }
}
