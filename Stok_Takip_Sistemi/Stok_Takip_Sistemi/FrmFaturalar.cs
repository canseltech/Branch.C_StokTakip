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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            FrmFirmaSec frSec = new FrmFirmaSec();
            frSec.Show();
        }

        private void btnCariMüşteriSec_Click(object sender, EventArgs e)
        {
            FrmMüşteriSec frMüsteri = new FrmMüşteriSec();
            frMüsteri.Show();
        }
    }
}
