using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmNotifyIcon : Form
    {
        public frmNotifyIcon()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Double Clicked");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            notifyIcon1.BalloonTipTitle = "This is a Title ";
            notifyIcon1.BalloonTipText = "This is a text ";
            notifyIcon1.ShowBalloonTip(1000); // By Default 10s Min to 30s Max



        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            MessageBox.Show("Closed");
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            MessageBox.Show("You Clicked the notify");
        }

        private void notifyIcon1_BalloonTipShown(object sender, EventArgs e)
        {
            MessageBox.Show("Show With Notify");

        }
    }
}
