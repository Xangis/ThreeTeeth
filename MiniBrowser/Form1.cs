using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MiniBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnBack.Enabled = false;
            btnForward.Enabled = false;
            btnStop.Enabled = false;
            webBrowser1.Navigating += webBrowser1_Navigating;
            webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
            webBrowser1.Navigated += webBrowser1_Navigated;
            cbSearchProviders.SelectedIndex = 0;
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("http://threeteeth.com/search.html?version=1.0");
        }

        private void button1_Click( object sender, EventArgs e )
        {
            webBrowser1.Navigate( textBox1.Text );
        }

        private void textBox1_KeyPress( object sender, KeyPressEventArgs e )
        {
            if (e.KeyChar == (char) 13)
            {
                webBrowser1.Navigate(textBox1.Text);
            }
        }

        private void txtSearchText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnSearch_Click(sender, e);
            }
        }

        private void webBrowser1_Navigated( object Sender, EventArgs e )
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void webBrowser1_Navigating( object Sender, WebBrowserNavigatingEventArgs e )
        {
            btnStop.Enabled = true;
        }

        private void webBrowser1_DocumentCompleted( object Sender, EventArgs e )
        {
            btnStop.Enabled = false;
            if( webBrowser1.CanGoBack )
            {
                btnBack.Enabled = true;
            }
            else
            {
                btnBack.Enabled = false;
            }
            if( webBrowser1.CanGoForward )
            {
                btnForward.Enabled = true;
            }
            else
            {
                btnForward.Enabled = false;
            }
            if (!String.IsNullOrEmpty(webBrowser1.DocumentTitle))
            {
                this.Text = "ThreeTeeth Browser: " + webBrowser1.DocumentTitle;
            }
            else
            {
                this.Text = "ThreeTeeth Browser";
            }
        }

        private void button2_Click( object sender, EventArgs e )
        {
            webBrowser1.GoBack();
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void button3_Click( object sender, EventArgs e )
        {
            webBrowser1.GoForward();
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void button4_Click( object sender, EventArgs e )
        {
            webBrowser1.Stop();
        }

        private void button5_Click( object sender, EventArgs e )
        {
            webBrowser1.Refresh();
        }

        private void btnPrint_Click( object sender, EventArgs e )
        {
            webBrowser1.Print();
        }

        private void btnViewSource_Click( object sender, EventArgs e )
        {
            string source = webBrowser1.DocumentText.ToString();
            Source window = new Source( source );
            window.ShowDialog();
        }

        private void btnAbout_Click( object sender, EventArgs e )
        {
            MessageBox.Show( "ThreeTeeth v1.0\nhttp://threeteeth.com\n\nCopyright (c) 2007-2011 Zeta Centauri\nhttp://zetacentauri.com\n\nWriten by Jason Champion.", "About The ThreeTeeth Browser" );
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearchProviders.Text == "Amazon")
            {
                webBrowser1.Navigate("http://www.amazon.com/s?ie=UTF8&tag=zetacentauri-20&index=blended&link_code=qs&field-keywords=" + txtSearchText.Text + "&sourceid=ThreeTeeth-search");
            }
            else if (cbSearchProviders.Text == "Google")
            {
                webBrowser1.Navigate("http://www.google.com");
            }
            else if (cbSearchProviders.Text == "eBay")
            {
                webBrowser1.Navigate("http://rover.ebay.com/rover/1/711-53200-19255-0/1?icep_ff3=9&pub=5574866124&toolid=10001&campid=5336833782&customid=&icep_uq=" + txtSearchText.Text + "&icep_sellerId=&icep_ex_kw=&icep_sortBy=12&icep_catId=&icep_minPrice=&icep_maxPrice=&ipn=psmain&icep_vectorid=229466&kwid=902099&mtid=824&kw=lg");
            }
            //else if (cbSearchProviders.Text == "Xpensiv")
            //{
            //    webBrowser1.Navigate("http://www.xpensiv.com");
            //}
            //else if (cbSearchProviders.Text == "CrawlCode")
            //{
            //    webBrowser1.Navigate("http://www.crawlcode.com");
            //}
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://threeteeth.com/search.html?version=1.0");
        }
    }
}