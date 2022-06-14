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

namespace Pizza_Otomasyonu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=GITARIST44;Initial Catalog=pizza;Integrated Security=True");

        private void btnMenudon_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
            Hide();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM siparisler";
            komut.Connection = baglanti;
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgwsiparis.DataSource = dt;
        }
    }
}
