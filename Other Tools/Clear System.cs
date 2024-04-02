using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shell;

namespace Other_Tools
{
    public partial class Clear_System : Form
    {
        public Clear_System()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Refresh();
            listView1.Items.Clear();

            string userName = Environment.UserName;
            string[] files = Directory.GetFiles(@"C:\\Users\\"+userName+"\\AppData\\Local\\Temp", "*.*", SearchOption.AllDirectories);
            foreach (string f in files)
            {
             Console.WriteLine($"{files} is deleted.");
             string entry = Path.GetFullPath(f);
             listView1.Items.Add(entry.Substring(entry.LastIndexOf(@"\")));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userName = Environment.UserName;
            System.Diagnostics.Process.Start("CMD.exe", "/k rd \"C:\\Users\\"+userName+"\\AppData\\Local\\Temp\" /s/q & exit");
            MessageBox.Show("Nettoyage terminé");
        }
    }
}
