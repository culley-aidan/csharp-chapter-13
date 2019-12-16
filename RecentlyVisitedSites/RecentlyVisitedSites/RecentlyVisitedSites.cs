using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecentlyVisitedSites
{
    public partial class RecentlyVisitedSites : Form
    {
        public RecentlyVisitedSites()
        {
            InitializeComponent();
        }

        private void lnkOne_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start(new Uri("https://www.google.com/").ToString());
        private void lnkOne_MouseHover(object sender, EventArgs e)
            => lblInfo.Text = "very epic search engine";
        private void lnkTwo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start(new Uri("https://www.wikipedia.org/").ToString());
        private void lnkTwo_MouseHover(object sender, EventArgs e)
            => lblInfo.Text = "very epic wiki";
        private void lnkThree_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start(new Uri("https://www.microsoft.com/en-us/").ToString());
        private void lnkThree_MouseHover(object sender, EventArgs e)
            => lblInfo.Text = "very big company";
    }
}
