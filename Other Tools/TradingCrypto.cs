using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Controls;
using Microsoft.Web.WebView2.Core;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Schema;

namespace Other_Tools
{
    public partial class TradingCrypto : Form
    {
        public TradingCrypto()
        {
            InitializeComponent();
        }

        private void Calculer_Click(object sender, EventArgs e)

        {

            String StringDividende = DividendeBox.Text.Trim();
            String StringVotreInvestissement = VotreInvestissementBox.Text.Trim();

            if (!string.IsNullOrEmpty(StringDividende) && !string.IsNullOrEmpty(StringVotreInvestissement))
            {
            Double DoubleDividende = 0.0;
            Double DoubleVotreInvestissement = 0.0;

            if (Double.TryParse(StringDividende, out DoubleDividende) && Double.TryParse(StringVotreInvestissement, out DoubleVotreInvestissement))
            {
             Double DoubleResult = (DoubleVotreInvestissement * DoubleDividende) / 100;
             Résultat.Text = DoubleResult.ToString("#,000.000");
             }
               else
              {
                  MessageBox.Show("Veuiller entrée une valeur !");                
              }

             }
        }
        private void StatistiqueEntreprises_Click(object sender, EventArgs e)
        {
            var StatistiqueEntreprises = new Statistique_des_entreprises();
            StatistiqueEntreprises.Closed += (s, args) => this.Close();
            StatistiqueEntreprises.Show();
        } 

        private void TradingCrypto_Load(object sender, EventArgs e)
        {
            {
                InitWebView();
            }
            async void InitWebView()
            {
                await webView22.EnsureCoreWebView2Async(null);
                webView22.CoreWebView2.Navigate("https://rendementbourse.com/screener");
            }
        }
    }
}
