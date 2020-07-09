using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Stok_Takip_Sistemi
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
            this.webBrowser2.Navigate("https://www.bbc.com/turkce");
        }
    }
}
