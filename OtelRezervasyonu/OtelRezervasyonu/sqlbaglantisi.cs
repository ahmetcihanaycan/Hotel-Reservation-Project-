using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtelRezervasyonu
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-NKAUUHC\\SQLEXPRESS;Initial Catalog=\"Otel Rezervasyon\";Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
