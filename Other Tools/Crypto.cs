using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Other_Tools
{
    public partial class Crypto : Form
    {
        public Crypto()
        {
            InitializeComponent();
        }

        private void Crypto_Load(object sender, EventArgs e)
        {
            {
                InitWebView();
            }
            async void InitWebView()
            {
                await WebViewTrading.EnsureCoreWebView2Async(null);
                WebViewTrading.CoreWebView2.Navigate("https://fr.tradingview.com/chart/Qit7fxLW/");
            }
        }

        private void OpenCrypto_Click(object sender, EventArgs e)
        {
            var Crypto = new Crypto();
            Crypto.Closed += (s, args) => this.Close();
            Crypto.Show();
        }
    }
}
