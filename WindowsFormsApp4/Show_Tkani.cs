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
    public partial class Show_Tkani : Form
    {
        public Show_Tkani()
        {
            InitializeComponent();
        }
        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //при нажатии на крестик приложение закрывается
        }

        private void Kladovshic_show_Tkani_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricaDataSet.Tkany". При необходимости она может быть перемещена или удалена.
            this.tkanyTableAdapter.Fill(this.fabricaDataSet.Tkany);

        }

        private void LoginOut_button_Click(object sender, EventArgs e)
        {
            //AvtorisForm ath = new AvtorisForm();
                    if (AvtorisForm.name == "Kladovshic")
                    {
                        this.Hide();//скрывает окно
                        KladovshicForm usForm = new KladovshicForm();
                        usForm.Show();
                    }
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
                    if (AvtorisForm.name == "user")
                    {
                        this.Hide();
                        ZakazchicForm usForm = new ZakazchicForm();
                        usForm.Show();
                    }
                }

        private void Show_Tkani_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }          
}
    

