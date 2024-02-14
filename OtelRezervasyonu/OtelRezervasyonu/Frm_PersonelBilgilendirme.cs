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
    public partial class Frm_PersonelBilgilendirme : Form
    {
        public Frm_PersonelBilgilendirme()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tcnumara;
        private void Frm_PersonelBilgilendirme_Load(object sender, EventArgs e)
        {
            lbltcc.Text = tcnumara;
            SqlCommand komut1 = new SqlCommand("Select PersonelAD From Tbl_personel where personelTC = @p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lbltcc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbladsoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

        }
    }
}
