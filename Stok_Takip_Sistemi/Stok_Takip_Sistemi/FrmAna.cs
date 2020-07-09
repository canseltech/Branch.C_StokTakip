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
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }

        private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAnasayfa frAna = new FrmAnasayfa();
            frAna.MdiParent = this;
            frAna.Show();
        }

        private void btnHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmHareketler frH = new FrmHareketler();
            frH.MdiParent = this;
            frH.Show();
        }

        private void btnSatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSatis frS = new FrmSatis();
            frS.MdiParent = this;
            frS.Show();
        }

        private void btnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFaturalar frF = new FrmFaturalar();
            frF.MdiParent = this;
            frF.Show();
        }

        private void btnÜrünler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunler frU = new FrmUrunler();
            frU.MdiParent = this;
            frU.Show();
        }

        private void btnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStoklar frStok = new FrmStoklar();
            frStok.MdiParent = this;
            frStok.Show();
        }

        private void btnMüşteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMüşteriler frM = new FrmMüşteriler();
            frM.MdiParent = this;
            frM.Show();
        }

        private void btnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFirmalar frFirma = new FrmFirmalar();
            frFirma.MdiParent = this;
            frFirma.Show();
        }

        private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmRehber frR = new FrmRehber();
            frR.MdiParent = this;
            frR.Show();
        }

        private void btnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasa frK = new FrmKasa();
            frK.MdiParent = this;
            frK.Show();
        }

        private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGiderler frG = new FrmGiderler();
            frG.MdiParent = this;
            frG.Show();
        }

        private void btnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmRaporlar frRapor = new FrmRaporlar();
            frRapor.MdiParent = this;
            frRapor.Show();
        }

        private void btnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
