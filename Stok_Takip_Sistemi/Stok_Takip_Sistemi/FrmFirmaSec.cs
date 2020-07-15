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

namespace Stok_Takip_Sistemi
{
    public partial class FrmFirmaSec : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANSEL-PC\\SQLEXPRESS;Initial Catalog=stok_veritabani;Integrated Security=True");
        public FrmFirmaSec()
        {

            InitializeComponent();
        }
        void listeleme()      //Form açıldıktan sonra firmalar tablosunun listelenmesi için
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from firmalar";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "firmalar");
                gridControlfirmasec.DataSource = ds.Tables["firmalar"];
                baglanti.Close();
            }
        }

        private void FrmFirmaSec_Load(object sender, EventArgs e)
        {
            listeleme();

        }
    }
}
       
    

