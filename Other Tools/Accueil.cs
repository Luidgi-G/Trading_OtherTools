using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Other_Tools
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            MainPanel.Visible = true;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
            MainPanel.Visible = true;

        }

        private void ButtonCrypto_Click(object sender, EventArgs e)
        {
            //MainPanel.Invalidate();
            loadform(new Crypto());

            foreach (var process in Process.GetProcessesByName("msedgewebview2"))
            {
                process.Kill();
            }
        }

        private void ButtonTrading_Click(object sender, EventArgs e)
        {
            loadform(new TradingCrypto());
            foreach (var process in Process.GetProcessesByName("msedgewebview2"))
            {
                process.Kill();
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = false;
            foreach (var process in Process.GetProcessesByName("msedgewebview2"))
            {
                process.Kill();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            loadform(new Clear_System());
            foreach (var process in Process.GetProcessesByName("msedgewebview2"))
            {
                process.Kill();
            }
        }

        private void Or_Click(object sender, EventArgs e)
        {
            loadform(new Cours_de_l_Or());
            foreach (var process in Process.GetProcessesByName("msedgewebview2"))
            {
                process.Kill();
            }
        }
    }
}
