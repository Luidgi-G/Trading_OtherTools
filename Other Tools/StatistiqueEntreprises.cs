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
using Microsoft.Web.WebView2.Core;

namespace Other_Tools
{
    public partial class Statistique_des_entreprises : Form
    {
        public Statistique_des_entreprises()
        {
            InitializeComponent();
        }

        private void Statistique_des_entreprises_Load(object sender, EventArgs e)
       
                {
                    
                    InitWebView();
                }

                async void InitWebView()
                {
                    await webView22.EnsureCoreWebView2Async(null);
                    webView22.CoreWebView2.Navigate("https://rendementbourse.com/screener");
                }

        private void webView22_Click(object sender, EventArgs e)
        {

        }
    }
}
