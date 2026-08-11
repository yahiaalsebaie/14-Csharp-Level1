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
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void btnShowMessage1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this is first Message");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this is first Message","Welcome");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this is first Message", "Welcome",MessageBoxButtons.OKCancel);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hi this is first Message", "Welcome", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                MessageBox.Show("You Pressed Ok!","Thank You",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }
    }
}
