using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Test;

namespace WindowsFormsApp4
{
    public partial class MenedgerForm : Form
    {
        public MenedgerForm()
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

        private void Display_button_Click(object sender, EventArgs e)
        {
            this.Hide(); //cкрывает текущее окно
            Show_Isdelia regForm = new Show_Isdelia();
            regForm.Show();
        }

        private void Formation_Tailings_button_Click(object sender, EventArgs e)
        {
            this.Hide(); //cкрывает текущее окно
            OstatokForm regForm = new OstatokForm();
            regForm.Show();
        }

        private void MenedgerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Formation_Offs_button_Click(object sender, EventArgs e)
        {
            
        }

        private void Accounting_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            IsdelieVipusk IsForm = new IsdelieVipusk();
            IsForm.Show();
        }
    }
}
