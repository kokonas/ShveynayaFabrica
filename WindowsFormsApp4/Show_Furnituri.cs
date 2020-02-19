using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Show_Furnituri : Form
    {
        public Show_Furnituri()
        {
            InitializeComponent();
        }
        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //при нажатии на крестик приложение закрывается
        }

        private void Show_Furnituri_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricaDataSet1.Furnitura". При необходимости она может быть перемещена или удалена.
            this.furnituraTableAdapter.Fill(this.fabricaDataSet1.Furnitura);

        }

        private void LoginOut_button_Click(object sender, EventArgs e)
        {
            this.Hide(); //cкрывает текущее окно
            KladovshicForm regForm = new KladovshicForm();
            regForm.Show();
        }

        private void Show_Furnituri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
