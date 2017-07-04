using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThreeTeeth
{
    public partial class AddBookmark : Form
    {
        public AddBookmark(String name, String url)
        {
            InitializeComponent();
            txtURLTitle.Text = name;
            txtURL.Text = url;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public String GetURL()
        {
            return txtURL.Text;
        }

        public String GetURLTitle()
        {
            return txtURLTitle.Text;
        }
    }
}
