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
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;




namespace Pizza_Otomasyonu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=GITARIST44;Initial Catalog=pizza;Integrated Security=True");

        private void btn8_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
            Hide();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM satiskaydi";
            komut.Connection = baglanti;
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            System.Data.DataTable dt = new System.Data.DataTable();
            adap.Fill(dt);
            dgwsatış.DataSource = dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            app.Visible = true;
            Workbook kitap = app.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sayfa = (Worksheet)kitap.Worksheets[1];
            for (int i = 0; i < dgwsatış.Columns.Count; i++)
            {
                Range alan = (Range)sayfa.Cells[1, 1];
                alan.Cells[1, i + 1] = dgwsatış.Columns[i].HeaderText;

            }
            for (int i = 0; i < dgwsatış.Columns.Count; i++)
            {
                for (int j = 0; j < dgwsatış.Rows.Count; j++)
                {
                    Range alan2 = (Range)sayfa.Cells[j + 1, i + 1];
                    alan2.Cells[2, 1] = dgwsatış[i, j].Value;
                }
            }
        }
    }
}
