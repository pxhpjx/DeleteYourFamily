using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DeleteYourFamily
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string[] Dirs = Directory.GetDirectories(txtPath.Text, "bin", System.IO.SearchOption.AllDirectories);
            List<string> DirList = new List<string>();
            foreach (string s in Dirs)
            {
                try
                {
                    Directory.Delete(s, true);
                    Directory.Delete(s.Replace("bin", "obj"), true);
                }
                catch { }
            }
        }
    }
}
