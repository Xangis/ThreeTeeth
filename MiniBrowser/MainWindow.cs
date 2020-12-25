using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ThreeTeeth
{
    public partial class MainWindow : Form
    {
        List<KeyValuePair<String, String>> bookmarks;

        public WebBrowser Browser
        {
            get
            {
                return webBrowser1; 
            }
        }

        public MainWindow(String url)
        {
            InitializeComponent();
            btnBack.Enabled = false;
            btnForward.Enabled = false;
            btnStop.Enabled = false;
            webBrowser1.Navigating += webBrowser1_Navigating;
            webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
            webBrowser1.Navigated += webBrowser1_Navigated;
            //cbSearchProviders.SelectedIndex = 0;
            webBrowser1.ScriptErrorsSuppressed = true;
            LoadBookmarks();
            //if (bookmarks.Count < 1)
            //{
            //    String amazonLink = "http://www.amazon.com/?_encoding=UTF8&tag=zetacentauri-20&linkCode=ur2&camp=1789&creative=9325";
            //    InsertBookmark("Amazon.com", amazonLink);
            //}
            cbBookmarks.SelectedIndexChanged += new EventHandler(cbBookmarks_SelectedIndexChanged);
            //MessageBox.Show("Browser version: " + webBrowser1.Version.ToString());
            webBrowser1.Navigate(url);
        }

        void cbBookmarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string title = (string)cbBookmarks.Items[cbBookmarks.SelectedIndex];
            int index = cbBookmarks.SelectedIndex;
            txtUrlBar.Text = bookmarks[index].Value;
            btnGo_Click(sender, e);
        }

        void SaveBookmarks()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (StreamReader sr = new StreamReader(ms))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ms, bookmarks);
                    ms.Position = 0;
                    byte[] buffer = new byte[(int)ms.Length];
                    ms.Read(buffer, 0, buffer.Length);
                    Properties.Settings.Default.Bookmarks = Convert.ToBase64String(buffer);
                    Properties.Settings.Default.Save();
                }
            }
            //MessageBox.Show(bookmarks.Count.ToString() + " bookmarks saved.");
        }

        void LoadBookmarks()
        {
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(Properties.Settings.Default.Bookmarks)))
            {
                bookmarks = new List<KeyValuePair<String, String>>();
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    List<KeyValuePair<String, String>> marks = (List<KeyValuePair<String, String>>)bf.Deserialize(ms);
                    bookmarks = marks;
                }
                catch (Exception)
                {
                }
                cbBookmarks.Items.Clear();
                foreach( KeyValuePair<String, String> bookmark in bookmarks )
                {
                    cbBookmarks.Items.Add(bookmark.Key);
                }
            }
            //MessageBox.Show(bookmarks.Count.ToString() + " bookmarks loaded.");
        }

        void InsertBookmark(string name, string url)
        {
            bookmarks.Add(new KeyValuePair<string, string>(name, url));
            cbBookmarks.Items.Add(name);
            SaveBookmarks();
        }

        private void btnGo_Click( object sender, EventArgs e )
        {
            webBrowser1.Navigate( txtUrlBar.Text );
        }

        private void txtUrlBar_KeyPress( object sender, KeyPressEventArgs e )
        {
            if (e.KeyChar == (char) 13)
            {
                webBrowser1.Navigate(txtUrlBar.Text);
            }
        }

        //private void txtSearchText_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)13)
        //    {
        //        this.btnSearch_Click(sender, e);
        //    }
        //}

        private void webBrowser1_Navigated( object Sender, EventArgs e )
        {
            txtUrlBar.Text = webBrowser1.Url.ToString();
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
            txtUrlBar.Text = webBrowser1.Url.ToString();
        }

        private void button3_Click( object sender, EventArgs e )
        {
            webBrowser1.GoForward();
            txtUrlBar.Text = webBrowser1.Url.ToString();
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
            AboutBox aboutBox = new AboutBox(this);
            aboutBox.ShowDialog();
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    if (cbSearchProviders.Text == "Amazon")
        //    {
        //        webBrowser1.Navigate("http://www.amazon.com/s?ie=UTF8&tag=zetacentauri-20&index=blended&link_code=qs&field-keywords=" + txtSearchText.Text + "&sourceid=ThreeTeeth-search");
        //    }
        //    else if (cbSearchProviders.Text == "Google")
        //    {
        //        webBrowser1.Navigate("http://www.google.com");
        //    }
        //    else if (cbSearchProviders.Text == "eBay")
        //    {
        //        webBrowser1.Navigate("http://rover.ebay.com/rover/1/711-53200-19255-0/1?icep_ff3=9&pub=5574866124&toolid=10001&campid=5336833782&customid=&icep_uq=" + txtSearchText.Text + "&icep_sellerId=&icep_ex_kw=&icep_sortBy=12&icep_catId=&icep_minPrice=&icep_maxPrice=&ipn=psmain&icep_vectorid=229466&kwid=902099&mtid=824&kw=lg");
        //    }
        //    //else if (cbSearchProviders.Text == "Xpensiv")
        //    //{
        //    //    webBrowser1.Navigate("http://www.xpensiv.com");
        //    //}
        //    //else if (cbSearchProviders.Text == "CrawlCode")
        //    //{
        //    //    webBrowser1.Navigate("http://www.crawlcode.com");
        //    //}
        //}

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https:/wbsrch.com");
        }

        /// <summary>
        /// Opens a HTML file for display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                webBrowser1.Navigate(dlg.FileName);
            }
        }

        private void btnBookmark_Click(object sender, EventArgs e)
        {
            AddBookmark dlg = new AddBookmark(webBrowser1.DocumentTitle.ToString(), webBrowser1.Url.ToString());
            dlg.ShowDialog();
            if (dlg.DialogResult == DialogResult.OK)
            {
                InsertBookmark(dlg.GetURLTitle(), dlg.GetURL());
            }            
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            panel1.Width = this.Width - 25;
            txtUrlBar.Width = this.Width - 72;
            btnGo.Location = new Point(this.Width - 62, btnGo.Location.Y);
        }
    }
}