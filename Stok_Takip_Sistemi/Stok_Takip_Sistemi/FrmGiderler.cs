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
    public partial class FrmGiderler : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANSEL-PC\\SQLEXPRESS;Initial Catalog=stok_veritabani;Integrated Security=True");
        public FrmGiderler()
        {
            InitializeComponent();
        }
        void temizleme() //işlemlerden sonra textboxları temizlemek için
        {
            txtIDgider.Text = "";
            cmbaygider.Text = "";
            cmbyılgider.Text = "";
            txtelektrikgider.Text = "";
            txtsugider.Text = "";
            txtdoğalgazgider.Text = "";
            txtinternetgider.Text = "";
            txtmaaşgider.Text = "";
            txtekstragider.Text = "";
            rtxnotgider.Text = "";
        }


           
        void listeleme()      //Kayıt işleminden sonra GridControl'e tablonun aktarılması için
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from giderler";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "giderler");
                gridControlgider.DataSource = ds.Tables["giderler"];
                baglanti.Close();
            }
        }


        private void btnkaydetgider_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)  // bağlantı durumunu kontrol et eğer kapalı ise
            {
                baglanti.Open(); // bağlantıyı aç
                SqlCommand cmd = new SqlCommand();         // bağlantı gerçekleşti
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO giderler(Ay,Yil,Elektrik,Su,Dogalgaz,Internet,Maaslar,Ekstra,Notlar) VALUES( '" + cmbaygider.Text + "' , '" + cmbyılgider.Text + "', '" + txtelektrikgider.Text + "','" + txtsugider.Text + "',  '" + txtdoğalgazgider.Text + "' ,'" + txtinternetgider.Text + "','" + txtmaaşgider.Text + "','" + txtekstragider.Text + "','" + rtxnotgider.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                listeleme();
                MessageBox.Show("Kayıt İşlemi Tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsilgider_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "delete from giderler where ID=@numara2"; // ID bu numarada olanı sil
                    cmd.Parameters.AddWithValue("@numara2", txtIDgider.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    listeleme();

                }
            }
        }

        private void btngüncellegider_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "update giderler set Ay=@g1 ,Yil=@g2,Elektrik=@g3,Su=@g4,Dogalgaz=@g5,Internet=@g6,Maaslar=@g7,Ekstra=@g8,Notlar=@g9 where ID=@numara2";
                cmd.Parameters.AddWithValue("@g1", cmbaygider.Text);
                cmd.Parameters.AddWithValue("@g2", cmbyılgider.Text);
                cmd.Parameters.AddWithValue("@g3", txtelektrikgider.Text);
                cmd.Parameters.AddWithValue("@g4", txtsugider.Text);
                cmd.Parameters.AddWithValue("@g5", txtdoğalgazgider.Text);
                cmd.Parameters.AddWithValue("@g6", txtinternetgider.Text);
                cmd.Parameters.AddWithValue("@g7", txtmaaşgider.Text);
                cmd.Parameters.AddWithValue("@g8", txtekstragider.Text);
                cmd.Parameters.AddWithValue("@g9", rtxnotgider.Text);
                cmd.Parameters.AddWithValue("@numara2", txtIDgider.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listeleme();
            }
        }

        private void gridViewgider_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridViewgider.GetDataRow(gridViewgider.FocusedRowHandle);  // tabloda bir satırda güncelleme yapılacağı zaman o satırdaki verileri textboxa getir
            if (dr != null)
            {
                txtIDgider.Text = dr["ID"].ToString();
                cmbaygider.Text = dr["Ay"].ToString();
                cmbyılgider.Text = dr["Yil"].ToString();
                txtelektrikgider.Text = dr["Elektrik"].ToString();
                txtsugider.Text = dr["Su"].ToString();
                txtdoğalgazgider.Text = dr["Dogalgaz"].ToString();
                txtinternetgider.Text = dr["Internet"].ToString();
                txtmaaşgider.Text = dr["Maaslar"].ToString();
                txtekstragider.Text = dr["Ekstra"].ToString();
                rtxnotgider.Text = dr["Notlar"].ToString();
            }
        }

        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            listeleme();
        }

        private void btntemizlegider_Click(object sender, EventArgs e)
        {
            temizleme();
        }
    }
    }
    
    
    
    

        
    


