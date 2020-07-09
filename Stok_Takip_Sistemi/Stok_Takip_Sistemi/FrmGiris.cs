using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip_Sistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        string kullaniciadi = "ulucinal";
        string parola = "yönetici";

        private void button1_Click(object sender, EventArgs e)
        {
           if(txtKullaniciAdi.Text == kullaniciadi && txt_parola.Text == parola)
            {
                FrmAna fr = new FrmAna();
                fr.Show();
                this.Hide();
            }

        }
    }
}
