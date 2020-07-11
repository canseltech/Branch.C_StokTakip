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

        FrmAnasayfa frA;
        FrmSatis frS;
        FrmHareketler frH;
        FrmFaturalar frF;
        FrmUrunler frU;
        FrmStoklar frSt;
        FrmMüşteriler frM;
        FrmFirmalar frFi;
        FrmRehber frR;
        FrmKasa frK;
        FrmGiderler frG;
        FrmRaporlar frRa;

        private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frA == null || frA.IsDisposed) //frA == null : anasayfada tıkladığımız sekmenin bir daha bir daha tekrar açılmaması için 
            {                                  //frA.IsDisposed : sekmenin mouse tekerleği ile kapandığında bir daha açılmaması sorununu çözmek için
                frA = new FrmAnasayfa();
                frA.MdiParent = this;
                frA.Show();
            }

        }

        private void btnHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frH == null || frH.IsDisposed)
            {
                frH = new FrmHareketler();
                frH.MdiParent = this;
                frH.Show();
            }

        }

        private void btnSatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frS == null || frS.IsDisposed)
            {
                frS = new FrmSatis();
                frS.MdiParent = this;
                frS.Show();
            }

        }

        private void btnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frF == null || frF.IsDisposed)
            {
                frF = new FrmFaturalar();
                frF.MdiParent = this;
                frF.Show();
            }

        }

        private void btnÜrünler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frU == null || frU.IsDisposed)
            {
                frU = new FrmUrunler();
                frU.MdiParent = this;
                frU.Show();
            }

        }

        private void btnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frSt == null || frSt.IsDisposed)
            {
                frSt = new FrmStoklar();
                frSt.MdiParent = this;
                frSt.Show();
            }

        }

        private void btnMüşteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frM == null || frM.IsDisposed)
            {
                frM = new FrmMüşteriler();
                frM.MdiParent = this;
                frM.Show();
            }

        }

        private void btnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frFi == null || frFi.IsDisposed)
            {
                frFi = new FrmFirmalar();
                frFi.MdiParent = this;
                frFi.Show();
            }

        }

        private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frR == null || frR.IsDisposed)
            {
                frR = new FrmRehber();
                frR.MdiParent = this;
                frR.Show();
            }

        }

        private void btnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frK == null || frK.IsDisposed)
            {
                frK = new FrmKasa();
                frK.MdiParent = this;
                frK.Show();
            }

        }

        private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frG == null || frG.IsDisposed)
            {
                frG = new FrmGiderler();
                frG.MdiParent = this;
                frG.Show();
            }

        }

        private void btnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frRa == null || frRa.IsDisposed)
            {
                frRa = new FrmRaporlar();
                frRa.MdiParent = this;
                frRa.Show();
            }

        }

        private void btnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


    }
}