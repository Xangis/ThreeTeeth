using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThreeTeeth
{
    public partial class Source : Form
    {
        public Source(string source)
        {
            InitializeComponent();
            txtSource.Text = source.Replace("\n", "\r\n");
            txtSource.SelectionStart = 0;
            txtSource.SelectionLength = 0;
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            Close();
        }
    }
}
