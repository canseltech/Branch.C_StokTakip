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
    public partial class FrmFaturalar : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANSEL-PC\\SQLEXPRESS;Initial Catalog=stok_veritabani;Integrated Security=True");
        public FrmFaturalar()
        {
            InitializeComponent();
        }

        //Fatura Bilgileri
        void temizleme() //işlemlerden sonra textboxları temizlemek için
        {
            txtIDfatura.Text = "";
            cmbtipfatura.Text = "";
            txtsira.Text = "";
            txttarihfatura.Text = "";
            msksaatfatura.Text = "";
            cmbcarifirmafatura.Text = "";
            cmbcarimusterifatura.Text = "";
            txtteslimedenfatura.Text = "";
            txtteslimalanfatura.Text = "";

        }

        void listeleme()      //Kayıt işleminden sonra GridControl'e fatura bilgileri tablosunun aktarılması için
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from olusturulanfaturalar";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "olusturulanfaturalar");
                gridControlfaturaolustur.DataSource = ds.Tables["olusturulanfaturalar"];
                baglanti.Close();
            }
        }

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            


            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "SELECT *FROM firmalar";
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr;               // Comboboxta firma adının listelenmesi
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbcarifirmafatura.Items.Add(dr["FirmaAdi"]);
                }
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT *FROM musterilertablosu";
                komut.CommandType = CommandType.Text;

                SqlDataReader dtr;
                dtr = komut.ExecuteReader();   //Comboboxta müşteri no listelenmesi
                while (dtr.Read())
                {
                    cmbcarimusterifatura.Items.Add(dtr["MusteriNo"]);
                }
                baglanti.Close();
                listeleme();
                listele();
            }
        }

        private void cmbtipfatura_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtIDfatura.SelectedText == "")  // ID pasif hale getir
            {
                txtIDfatura.Enabled = false;

            }
            if (cmbtipfatura.SelectedText == "Alış")  // Alış olması durumunda cari müşteri no ve teslim edeni pasif hale getir
            {
                cmbcarimusterifatura.Enabled = false;
                txtteslimedenfatura.Enabled = false;

            }
            else
            {
                cmbcarimusterifatura.Enabled = true;
                txtteslimedenfatura.Enabled = true;

            }

            if (cmbtipfatura.SelectedText == "Satış")  //Satış olması durumunda cari firma ve teslim alanı pasif hale getir
            {
                cmbcarifirmafatura.Enabled = false;
                txtteslimalanfatura.Enabled = false;

            }
            else
            {
                cmbcarifirmafatura.Enabled = true;
                txtteslimalanfatura.Enabled = true;

            }

        }

        private void btnFaturaOlustur_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)  // bağlantı durumunu kontrol et eğer kapalı ise
            {
                baglanti.Open(); // bağlantıyı aç
                SqlCommand cmd = new SqlCommand();         // bağlantı gerçekleşti
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO olusturulanfaturalar(Tip,Sira,Tarih,Saat,CariFirma,CariMusteri,TeslimEden,TeslimAlan) VALUES( '" + cmbtipfatura.Text + "' , '" + txtsira.Text + "', '" + txttarihfatura.Text + "','" + msksaatfatura.Text + "',  '" + cmbcarifirmafatura.Text + "' ,'" + cmbcarimusterifatura.Text + "','" + txtteslimedenfatura.Text + "','" + txtteslimalanfatura.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                listeleme();
                MessageBox.Show("Fatura Oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFaturaIptal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("İptal etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "delete from olusturulanfaturalar where ID=@numara3"; // ID bu numarada olanı sil
                    cmd.Parameters.AddWithValue("@numara3", txtIDfatura.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Fatura İptal Edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    listeleme();

                }
            }
        }

        private void btnFaturaBilgiGuncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "update olusturulanfaturalar set Tip=@f1 ,Sira=@f2,Tarih=@f3,Saat=@f4,CariFirma=@f5,CariMusteri=@f6,TeslimEden=@f7,TeslimAlan=@f8 where ID=@numara3";
                cmd.Parameters.AddWithValue("@f1", cmbtipfatura.Text);
                cmd.Parameters.AddWithValue("@f2", txtsira.Text);
                cmd.Parameters.AddWithValue("@f3", txttarihfatura.Text);
                cmd.Parameters.AddWithValue("@f4", msksaatfatura.Text);
                cmd.Parameters.AddWithValue("@f5", cmbcarifirmafatura.Text);
                cmd.Parameters.AddWithValue("@f6", cmbcarimusterifatura.Text);
                cmd.Parameters.AddWithValue("@f7", txtteslimedenfatura.Text);
                cmd.Parameters.AddWithValue("@f8", txtteslimalanfatura.Text);
                cmd.Parameters.AddWithValue("@numara3", txtIDfatura.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                MessageBox.Show("Fatura Bilgisi Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listeleme();
            }
        }

        private void btnFaturaTemizle_Click(object sender, EventArgs e)
        {
            temizleme();
        }





       

        //Fatura Detayları

        void temizle() //işlemlerden sonra textboxları temizlemek için
        {
            txtPIDfatura.Text = "";
            txtadetfatura.Text = "";
            txturunadıfatura.Text = "";
            txtalisfiyatfatura.Text = "";
            txtsatisfiyatfatura.Text = "";
        }
        void listele()      //Ürün ekleme işleminden sonra GridControl'e faturadetay tablosunun aktarılması için
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from faturadetay";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "faturadetay");
                gridControlfaturadetay.DataSource = ds.Tables["faturadetay"];
                baglanti.Close();
            }
        }

        private void txtPIDfatura_TextChanged(object sender, EventArgs e)
        {
            int sayi1;
            double sayi2, sayi3, sonuc;
            if (cmbalissatis.SelectedText == "Satış") // Satış olması durumunda satış fiyatına göre toplam tutarı hesapla
            {
                sayi1 = Convert.ToInt32(txtadetfatura.Text);
                sayi2 = Convert.ToDouble(txtsatisfiyatfatura.Text);
                sonuc = sayi1 * sayi2;
                lblcntrlTutar.Text = sonuc.ToString();
            }
           
            else if(cmbalissatis.SelectedText == "Alış") // Alış olması durumunda alış fiyatına göre toplam tutarı hesapla
            {
                sayi1 = Convert.ToInt32(txtadetfatura.Text);
                sayi3 = Convert.ToDouble(txtalisfiyatfatura.Text);
                sonuc = sayi1 * sayi3;
                lblcntrlTutar.Text = sonuc.ToString();
            }

            if (txtPIDfatura.Text == "") foreach (Control item in Controls) if (item is TextBox) item.Text = ""; //PID silindiğinde textboxları temizle
            baglanti.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = ("SELECT *FROM urunlertablosu where PID like '" + txtPIDfatura.Text + "'");   //PID numarası girildiğinde ürün adı, alış fiyatı, satış fiyatı bilgilerini urunlertablosundan getir
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txturunadıfatura.Text = read["UrunAdi"].ToString();
                txtalisfiyatfatura.Text = read["BirimAlisFiyati"].ToString();
                txtsatisfiyatfatura.Text = read["BirimSatisFiyati"].ToString();
            }
            baglanti.Close();
            listele();
        }

        private void btnuruneklefatura_Click(object sender, EventArgs e)
        {
        {
                int sayi1;
                double sayi2, sonuc;
                sayi1 = Convert.ToInt32(txtadetfatura.Text);
                sayi2 = Convert.ToDouble(txtsatisfiyatfatura.Text);
                sonuc = sayi1 * sayi2;
                lblcntrlTutar.Text = sonuc.ToString();
            }
            if (baglanti.State == ConnectionState.Closed)  // bağlantı durumunu kontrol et eğer kapalı ise
            {
                baglanti.Open(); // bağlantıyı aç
                SqlCommand cmd = new SqlCommand();         // bağlantı gerçekleşti
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO faturadetay(PID,Adet,UrunAdi,BirimAlisFiyati,BirimSatisFiyati,ToplamTutar) VALUES('" + txtPIDfatura.Text + "','" + Convert.ToInt32(txtadetfatura.Text) + "', '" + txturunadıfatura.Text + "','" + Convert.ToDouble(txtalisfiyatfatura.Text) + "',  '" + Convert.ToDouble(txtsatisfiyatfatura.Text) + "' ,'" + Convert.ToString(lblcntrlTutar.Text) + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                listele();
                MessageBox.Show("Ürün Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnurunsilfatura_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("İptal etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "delete from faturadetay where FaturaID=@numara4"; // ID bu numarada olanı sil
                    cmd.Parameters.AddWithValue("@numara4", txtfaturadetayID.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Ürün İptal Edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    listele();

                }
            }
        }

        private void btnuruntemizlefatura_Click(object sender, EventArgs e)
        {
            temizle();
        }



        private void gridViewfaturaolustur_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridViewfaturaolustur.GetDataRow(gridViewfaturaolustur.FocusedRowHandle); // Fatura Bilgilerinde güncelleme işlemi yapılacağı zaman tablodaki verileri getir
            if (dr != null)
            {
                txtIDfatura.Text = dr[0].ToString();
                cmbtipfatura.Text = dr[1].ToString();
                txtsira.Text = dr[2].ToString();
                txttarihfatura.Text = dr[3].ToString();
                msksaatfatura.Text = dr[4].ToString();
                cmbcarifirmafatura.Text = dr[5].ToString();
                cmbcarimusterifatura.Text = dr[6].ToString();
                txtteslimedenfatura.Text = dr[7].ToString();
                txtteslimalanfatura.Text = dr[8].ToString();
            }
        }

        private void cmbalissatis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtfaturadetayID.SelectedText == "")  // ID pasif hale getir
            {
                txtfaturadetayID.Enabled = false;

            }
        }
    }
    }

    











































