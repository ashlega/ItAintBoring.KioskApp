using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CefSharp;
using CefSharp.WinForms;

namespace WinFormCanvasApp
{
    
    public partial class ClosingForm : Form
    {
        public ClosingForm()
        {
            InitializeComponent();
            
        }

        public ChromiumWebBrowser browser;

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(tbKeyPhrase.Text != "TAXI")
            {
                MessageBox.Show("Incorrect key phrase!");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
