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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=GITARIST44;Initial Catalog=pizza;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnkayıtol_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into giris (username,passwd) values ('" + textBox1k.Text.ToString() + "','" + textBox2k.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarılı");
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
            
        }
    }
}
