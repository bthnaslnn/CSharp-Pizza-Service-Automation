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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=GITARIST44;Initial Catalog=pizza;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txtBox1.Text == "admin" && txtBox2.Text == "admin")
            {
                Form2 f2 = new Form2();
                MessageBox.Show("Giriş Başarılı");
                this.Hide();
                f2.Show();
            }
            else
            {
                try
            {
                baglanti.Open();
                string sql = "select * from giris where username = @username and passwd = @passwd ";
                SqlParameter prm1 = new SqlParameter("username", txtBox1.Text.Trim());
                SqlParameter prm2 = new SqlParameter("passwd", txtBox2.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    Form7 f7 = new Form7();
                    MessageBox.Show(" Giriş Başarılı");
                    this.Hide();
                    f7.Show();

                }
                baglanti.Close();
             }
            catch (Exception)
            {

                MessageBox.Show("              Hatalı Giriş!!!\n   Lütfen Tekrar Giriş Yapınız");

            }
        }

        }

        private void btnkayıt_Click_1(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            Hide();
            f9.Show();
        }
    }

       
    }

