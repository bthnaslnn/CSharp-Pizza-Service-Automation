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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        void VerileriAl()
        {
            baglanti = new SqlConnection("server=.;Initial Catalog=pizza;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("Select *from alındısiparis", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dgw1.DataSource = tablo;
            baglanti.Close();
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void dgw1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            VerileriAl();
        }

        private void btnsiparisal_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO müsteri (mus_AD,mus_SOYAD,mus_TEL,mus_paytype) values (@mus_AD,@mus_SOYAD,@mus_TEL,@mus_paytype)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@mus_AD", textBox1s.Text);
            komut.Parameters.AddWithValue("@mus_SOYAD", textBox2s.Text);
            komut.Parameters.AddWithValue("@mus_TEL", textBox3s.Text);
            komut.Parameters.AddWithValue("@mus_paytype", comboBox3.SelectedItem);
            string sorgulama = "INSERT INTO urunler (urun_Fiyat,urun_size) values (@urun_Fiyat,@urun_size)";
            komut = new SqlCommand(sorgulama, baglanti);
            komut.Parameters.AddWithValue("urun_Fiyati", textBoxfiyat.Text);
            komut.Parameters.AddWithValue("urun_size", comboBox2.SelectedItem);
            string sorgulamasan = "INSERT INTO cesit (cesit) values (@cesit)";
            komut = new SqlCommand(sorgulamasan, baglanti);
            komut.Parameters.AddWithValue("cesit", comboBox1.SelectedItem);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sipariş alındı");
            textBox1s.Clear();
            textBox2s.Clear();
            textBox3s.Clear();
            comboBox1.Refresh();
            comboBox2.Refresh();
            comboBox3.Refresh();
            VerileriAl();
               
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgw1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1s.Text = dgw1.CurrentRow.Cells[3].Value.ToString();
            textBox2s.Text = dgw1.CurrentRow.Cells[4].Value.ToString();
            textBox3s.Text = dgw1.CurrentRow.Cells[5].Value.ToString();
            textBoxfiyat.Text = dgw1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.SelectedItem = dgw1.CurrentRow.Cells[0].Value.ToString();
            comboBox2.SelectedItem = dgw1.CurrentRow.Cells[2].Value.ToString();
            comboBox3.SelectedItem = dgw1.CurrentRow.Cells[1].Value.ToString();
        }

        private void buttonlistele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM siparisler";
            komut.Connection = baglanti;
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgw1.DataSource = dt;
        }
    }
}
