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
    public partial class FrmFirmalar : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANSEL-PC\\SQLEXPRESS;Initial Catalog=stok_veritabani;Integrated Security=True");

        public FrmFirmalar()
        {

            InitializeComponent();
        }
        void temizleme() //işlemlerden sonra textboxları temizlemek için
        {
            txtID.Text = "";
            txtfirmaadı.Text = "";
            txttelefon.Text = "";
            txtkayıttarihi.Text = "";
            txtvergidairesi.Text = "";
            txtyetkili.Text = "";
            txtmail.Text = "";
        }

        private void btnkaydetfirma_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)  // bağlantı durumunu kontrol et eğer kapalı ise
            {
                baglanti.Open(); // bağlantıyı aç
                SqlCommand cmd = new SqlCommand();         // bağlantı gerçekleşti
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO firmalar(FirmaAdi,Telefon,KayitTarihi,VergiDairesi,Yetkili,Mail) VALUES( '" + txtfirmaadı.Text + "' , '" + txttelefon.Text + "', '" + txtkayıttarihi.Text + "','" + txtvergidairesi.Text + "',  '" + txtyetkili.Text + "' ,'" + txtmail.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                listeleme();
                temizleme();
                MessageBox.Show("Kayıt İşlemi Tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void listeleme()      //Kayıt işleminden sonra GridControl'e tablonun aktarılması için
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
                gridControlfirma.DataSource = ds.Tables["firmalar"];
                baglanti.Close();
            }
        }


        private void btnsilfirma_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "delete from firmalar where ID=@numara"; // ID bu numarada olanı sil
                    cmd.Parameters.AddWithValue("@numara", txtID.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    listeleme();

                }
            }
        }

        private void btngüncellefirma_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "update firmalar set FirmaAdi=@p1 ,Telefon=@p2,KayitTarihi=@p3,VergiDairesi=@p4,Yetkili=@p5,Mail=@p6 where ID=@numara";
                cmd.Parameters.AddWithValue("@p1", txtfirmaadı.Text);
                cmd.Parameters.AddWithValue("@p2", txttelefon.Text);
                cmd.Parameters.AddWithValue("@p3", txtkayıttarihi.Text);
                cmd.Parameters.AddWithValue("@p4", txtvergidairesi.Text);
                cmd.Parameters.AddWithValue("@p5", txtyetkili.Text);
                cmd.Parameters.AddWithValue("@p6", txtmail.Text);
                cmd.Parameters.AddWithValue("@numara", txtID.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizleme();
                listeleme();
            }
        }



        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            listeleme();
        }

        private void gridViewFirma_FocusedRowObjectChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridViewFirma.GetDataRow(gridViewFirma.FocusedRowHandle);  // tabloda bir satırda güncelleme yapılacağı zaman o satırdaki verileri textboxa getir
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                txtfirmaadı.Text = dr["FirmaAdi"].ToString();
                txttelefon.Text = dr["Telefon"].ToString();
                txtkayıttarihi.Text = dr["KayitTarihi"].ToString();
                txtvergidairesi.Text = dr["VergiDairesi"].ToString();
                txtyetkili.Text = dr["Yetkili"].ToString();
                txtmail.Text = dr["Mail"].ToString();
            }
        }
    }
}
    
    