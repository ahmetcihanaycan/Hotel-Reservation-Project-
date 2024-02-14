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
using System.Data.SqlClient;

namespace OtelRezervasyonu
{
    public partial class Rezervasyon : Form
    {
        public Rezervasyon()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_musteribilgi (MusteriAD,MusteriSoyad,MusteriTC,MusteriTel ,MusteriOdaNo) values (@p1 , @p2 , @p3 , @p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskdtcno.Text);
            komut.Parameters.AddWithValue("@p4", mskdtelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtodano.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Rezervasyonunuz Tamamlanmıştır");
        }

        private void Rezervasyon_Load(object sender, EventArgs e)
        {

        }
    }
}
