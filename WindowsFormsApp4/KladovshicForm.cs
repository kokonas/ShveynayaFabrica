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
    public partial class KladovshicForm : Form
    {
        public KladovshicForm()
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

        private void DisplayFabric_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_Tkani regForm = new Show_Tkani();
            regForm.Show();
        }

        private void DisplayHardware_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_Furnituri regForm = new Show_Furnituri();
            regForm.Show();
        }

        private void KladovshicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Receipt_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PostuplenieTovarov Pf = new PostuplenieTovarov();
            Pf.Show();
        }
    }
}
