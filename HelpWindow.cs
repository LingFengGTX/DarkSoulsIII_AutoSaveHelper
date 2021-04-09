using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DARK_SOUL_III_AutoSave
{
    public partial class HelpWindow : Form
    {
        public HelpWindow(string helpIndex)
        {
            InitializeComponent();
            HtmlViewer.Navigate(".\\Help\\"+helpIndex+".html");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
