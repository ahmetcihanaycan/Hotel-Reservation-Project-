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
namespace OtelRezervasyonu
{
    public partial class Frm_PersonelGiris : Form
    {
        public Frm_PersonelGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_personel where personelTC=@p1 and PersonelSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskdtcno.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Frm_PersonelBilgilendirme fr = new Frm_PersonelBilgilendirme();
                fr.tcnumara =mskdtcno.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Sifre & TC"); 
            }
            bgl.baglanti().Close();
        }

        private void Frm_PersonelGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
