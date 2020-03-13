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
    
    public partial class formMain : Form
    {
        public static string homeUrl = "https://apps.powerapps.com/play/15601e1f-48c2-4b3f-9063-95195c8659cb?tenantId=ee810a5c-034a-47b1-926d-c745ecaf201b&source=portal&screenColor=rgba(0%2C%20176%2C%20240%2C%201)";
        public formMain()
        {
            InitializeComponent();
            InitBrowser();
        }

        public ChromiumWebBrowser browser;

        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser(homeUrl);
            panelBrowser.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

        private void formMain_Resize(object sender, EventArgs e)
        {

        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingForm cf = new ClosingForm();
            if(cf.ShowDialog() != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            browser.Load(homeUrl);
        }
    }
}
