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
using System.Security.Cryptography;

namespace OtelRezervasyonu
{
    public partial class Hoşgeldiniz : Form
    {
        public Hoşgeldiniz()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rezervasyon rz = new Rezervasyon();
            rz.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_MusteriGiris fr = new Frm_MusteriGiris();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_PersonelGiris fr = new Frm_PersonelGiris();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {          
            Frm_OtelBilgi fr = new Frm_OtelBilgi();
            fr.Show();
            this.Hide();
        }

        private void Hoşgeldiniz_Load(object sender, EventArgs e)
        {

        }
    }
}
