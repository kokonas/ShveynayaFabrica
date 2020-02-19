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
using System.Drawing.Printing;

namespace WindowsFormsApp4
{
    public partial class Show_Isdelia : Form
    {
        int pageSize = 10; // размер страницы
        int pageNumber = 0; // текущая страница
        string connectionString = @"Data Source=LAPTOP-562FH47J\SQL2017;Initial Catalog=Fabrica;Integrated Security=True";
        SqlDataAdapter adapter;
        DataSet ds;
        public Show_Isdelia()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter = new SqlDataAdapter(GetSql(), connection);

                ds = new DataSet();
                adapter.Fill(ds, "Isdelie");
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns["Articul"].ReadOnly = true;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (pageNumber == 0) return;
            pageNumber--;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter = new SqlDataAdapter(GetSql(), connection);

                ds.Tables["Isdelie"].Rows.Clear();

                adapter.Fill(ds, "Isdelie");
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (ds.Tables["Isdelie"].Rows.Count < pageSize) return;

            pageNumber++;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter = new SqlDataAdapter(GetSql(), connection);

                ds.Tables["Isdelie"].Rows.Clear();

                adapter.Fill(ds, "Isdelie");
            }
        }
        private string GetSql()
        {
            return "SELECT * FROM Isdelie ORDER BY Articul OFFSET ((" + pageNumber + ") * " + pageSize + ") " +
                "ROWS FETCH NEXT " + pageSize + "ROWS ONLY";
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
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

        private void Show_Isdelia_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            e.Graphics.DrawImage(objBmp, 100, 120);
        }


        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        } 

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Show_Isdelia_Load(object sender, EventArgs e)
        {     
        }
    }
}
