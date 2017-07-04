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
    public partial class AboutBox : Form
    {
        MainWindow mainWindow;
        public AboutBox(MainWindow main)
        {
            InitializeComponent();
            mainWindow = main;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainWindow.Browser.Navigate("http://threeteeth.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainWindow.Browser.Navigate("http://zetacentauri.com");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
