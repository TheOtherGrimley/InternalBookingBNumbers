using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookings2.Forms
{
    public partial class BusTrack : Form
    {
        public BusTrack()
        {
            InitializeComponent();
        }

        private void BusTrack_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            pictureBox1.Visible = true;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.Url.ToString() == "http://login.3dtracking.net/Account/LogOn?ReturnUrl=/")
            {
                SendKeys.Send("{" + Keys.Tab.ToString() + "}");
                SendKeys.Send("BCSapp");
                SendKeys.Send("{" + Keys.Tab.ToString() + "}");
                SendKeys.Send("Bcs233");
                SendKeys.Send("{ENTER}");
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if(webBrowser1.Url.ToString() == "http://phoenix3.3dtracking.net/live/")
            {
                pictureBox1.Visible = false;
            }
        }
    }
}
