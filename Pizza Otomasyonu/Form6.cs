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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=GITARIST44;Initial Catalog=pizza;Integrated Security=True");

        private void btn22_Click(object sender, EventArgs e)
        {

        }

        private void btnMenudon_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
            Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from urungosterim", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwürün.DataSource = ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn19_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM urunler";
            komut.Connection = baglanti;
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgwürün.DataSource = dt;

        }
    }
}
