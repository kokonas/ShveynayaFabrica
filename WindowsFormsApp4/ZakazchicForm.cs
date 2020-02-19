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
    public partial class ZakazchicForm : Form
    {
        public ZakazchicForm()
        {
            InitializeComponent();
        }
        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //при нажатии на крестик приложение закрывается
        }

        private void LoginOut_button_Click(object sender, EventArgs e)
        {
            this.Hide(); //cкрывает текущее окно
            AvtorisForm regForm = new AvtorisForm();
            regForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            IsdelieVipusk Isv = new IsdelieVipusk();
            Isv.Show();
        }

        private void ZakazchicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
