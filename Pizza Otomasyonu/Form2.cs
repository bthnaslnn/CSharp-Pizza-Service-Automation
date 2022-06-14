using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Otomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.Show();
            Hide();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
            Hide();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.Show();
            Hide();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Form f5 = new Form5();
            f5.Show();
            Hide();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Form f6 = new Form6();
            f6.Show();
            Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
