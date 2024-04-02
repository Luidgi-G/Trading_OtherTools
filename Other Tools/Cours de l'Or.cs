using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Other_Tools
{
    public partial class Cours_de_l_Or : Form
    {
        public Cours_de_l_Or() 
            { 
                InitializeComponent();
            }

        private void OrKg_Click(object sender, EventArgs e)
        {
            {
                InitWebView();
            }
            async void InitWebView()
            {
                await webView21.EnsureCoreWebView2Async(null);
                webView21.CoreWebView2.Navigate("https://or.fr/widget/historical/XAU?height=auto&currency=EUR&weight_unit=kg");
            }
        }

        private void OrGr_Click(object sender, EventArgs e)
        {
            {
                InitWebView();
            }
            async void InitWebView()
            {
                await webView21.EnsureCoreWebView2Async(null);
                webView21.CoreWebView2.Navigate("https://or.fr/widget/historical/XAU?height=auto&currency=EUR&weight_unit=G");
            }
        }

        private void OrKgDirect_Click(object sender, EventArgs e)
        {
            {
                InitWebView();
            }
            async void InitWebView()
            {
                await webView21.EnsureCoreWebView2Async(null);
                webView21.CoreWebView2.Navigate("https://or.fr/widget/live/XAU?currency=EUR&weight_unit=kg");
            }
        }

        private void OrGrDirect_Click(object sender, EventArgs e)
        {
            {
                InitWebView();
            }
            async void InitWebView()
            {
                await webView21.EnsureCoreWebView2Async(null);
                webView21.CoreWebView2.Navigate("https://or.fr/widget/live/XAU?currency=EUR&weight_unit=g");
            }
        }
    }
}
