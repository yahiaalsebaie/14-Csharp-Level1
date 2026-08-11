using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class frmBetterCallSaul : Form
    {
        public frmBetterCallSaul()
        {
            InitializeComponent();
        }

        private void pbBetterCallSaul_Click(object sender, EventArgs e)
        {
            pbBetterCallSaul.Image = Image.FromFile(@"F:\Icons\Better Call Saul\better_call_saul_folder_icon_by_eanzito_dajdclq\Better Call Saul Folder Icon\Better Call Saul (1).png");
            lblSeason.Text = "Better Call Saul";
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void rbS1_CheckedChanged(object sender, EventArgs e)
        {
           // My Solution
                pbBetterCallSaul.Image = Resources.Better_Call_Saul_S1;
                lblSeason.Text = rbS1.Text;
           
        }

        private void rbS2_CheckedChanged(object sender, EventArgs e)
        {
          // Mr. Solution
                pbBetterCallSaul.Image = Resources.Better_Call_Saul_S2;
                lblSeason.Text = ((RadioButton)sender).Tag.ToString();
           // Make Tag Value = "rbS2" txt.
        }

        private void rbS3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbS3.Checked)
            {
                pbBetterCallSaul.Image = Resources.Better_Call_Saul_S3;
                /*lblSeason.Text = rbS3.Text;*/
                lblSeason.Text = ((RadioButton)sender).Tag.ToString();
            }
        }

        private void rbS4_CheckedChanged(object sender, EventArgs e)
        {
           
                pbBetterCallSaul.Image = Resources.Better_Call_Saul_S4;
                lblSeason.Text = rbS4.Text;
           
        }

        private void rbS5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbS5.Checked)
            {
                pbBetterCallSaul.Image = Resources.Better_Call_Saul_S5;
                lblSeason.Text = rbS5.Text;
            }
        }


    }
}
