using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyonu
{
    public partial class Frm_MusteriGiris : Form
    {
        public Frm_MusteriGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_musteribilgi where MusteriTc=@p1 and MusteriOdaNo=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@p2", txtodanumarasi.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Frm_MusteriBilgilendirme fr = new Frm_MusteriBilgilendirme();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & oda numarası");

            }
            bgl.baglanti().Close();
        }

        private void Frm_MusteriGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
