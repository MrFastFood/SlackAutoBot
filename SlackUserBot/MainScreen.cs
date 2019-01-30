using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlackUserBot
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void lnkSlackToken_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var label = (sender as Label);
            System.Diagnostics.Process.Start(label.Text);
        }
    }
}
