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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=GITARIST44;Initial Catalog=pizza;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into müsteri(mus_AD,mus_SOYAD,mus_tel,mus_paytype) values ('" + textBoxad.Text.ToString() + "','" + textBoxsoyad.Text.ToString() + "','" + textBoxtel.Text.ToString() + "','" + comboBoxpt.SelectedItem.ToString() +"')", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("      Kayıt Başarılı");
            baglanti.Close();
            textBoxad.Clear();
            textBoxsoyad.Clear();
            textBoxtel.Clear();
            comboBoxpt.Items.RemoveAt(comboBoxpt.SelectedIndex);
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btn17_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand Guncelleme = new SqlCommand("UPDATE müsteri SET  mus_AD =@ad,mus_SOYAD=@soyad,mus_tel=@telefon,mus_paytype=@pt where mus_ID=@id", baglanti);
            Guncelleme.Parameters.AddWithValue("ad", textBoxad);
            Guncelleme.Parameters.AddWithValue("soyad", textBoxsoyad);
            Guncelleme.Parameters.AddWithValue("telefon", textBoxtel);
            Guncelleme.Parameters.AddWithValue("pt", comboBoxpt);
            Guncelleme.Parameters.AddWithValue("id", textBoxid);
            //Guncelleme.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(" Müşteri güncellenmesi tamamlandı. ");

            textBoxad.Clear();
            textBoxsoyad.Clear();
            textBoxtel.Clear();
           
           
        }

        private void btnMenudon_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
            Hide();
        }

        private void labelpt_Click(object sender, EventArgs e)
        {

        }

        private void labelad_Click(object sender, EventArgs e)
        {

        }

        private void btn18_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM müsteri";
            komut.Connection = baglanti;
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgwmusteri.DataSource = dt;
        }

        private void dgwmusteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliAlan = dgwmusteri.SelectedCells[0].RowIndex;

            textBoxad.Text = dgwmusteri.Rows[seciliAlan].Cells[1].Value.ToString();
            textBoxsoyad.Text = dgwmusteri.Rows[seciliAlan].Cells[2].Value.ToString();
            textBoxtel.Text = dgwmusteri.Rows[seciliAlan].Cells[3].Value.ToString();
            comboBoxpt.SelectedItem = dgwmusteri.Rows[seciliAlan].Cells[4].Value.ToString();
            textBoxid.Text = dgwmusteri.Rows[seciliAlan].Cells[0].Value.ToString();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand aktarma = new SqlCommand("insert into silinenler (s_ad,s_soyad,s_tel,s_paytype) values ('" + textBoxad.Text.ToString() + "','" + textBoxsoyad.Text.ToString() + "','" + textBoxtel.Text.ToString() + "','" + comboBoxpt.SelectedItem.ToString() + "')", baglanti);
            aktarma.ExecuteNonQuery();
            //MessageBox.Show("      Kayıt Başarılı");
            baglanti.Close();
            textBoxad.Clear();
            textBoxsoyad.Clear();
            textBoxtel.Clear();
            comboBoxpt.Items.RemoveAt(comboBoxpt.SelectedIndex);
            baglanti.Open();



            SqlCommand SilmeKomudu = new SqlCommand("delete from müsteri where mus_ID= @id", baglanti);
            SilmeKomudu.Parameters.AddWithValue("@id", textBoxid.Text);
            SilmeKomudu.ExecuteNonQuery();
            MessageBox.Show(" Kayıt Başarılı Şekilde Silindi ");
            baglanti.Close();
            textBoxid.Clear();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM silinenler";
            komut.Connection = baglanti;
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgwmusteri.DataSource = dt;
            MessageBox.Show(" Silinmiş Adres Kayıtları ");
        }
    }
}
