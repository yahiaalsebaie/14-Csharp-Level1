using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class frmImageBox : Form
    {
        public frmImageBox()
        {
            InitializeComponent();
        }

        private void frmImageBox_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pbBreakingBad.Image = Resources.Breaking_Bad_S1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pbBreakingBad.Image = Resources.Breaking_Bad_S2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pbBreakingBad.Image = Resources.Breaking_Bad_S4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pbBreakingBad.Image = Resources.Breaking_Bad_S3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pbBreakingBad.Image = Resources.Breaking_Bad_S5;
        }

        private void pbBreakingBad_Click(object sender, EventArgs e)
        {
            pbBreakingBad.Image = Image.FromFile(@"F:\Icons\Breaking Bad - Folders\ICO\Breaking Bad _ Main.ico");
        }

    }
}
