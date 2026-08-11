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
    public partial class frmMaskedBox : Form
    {
        public frmMaskedBox()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!maskedTextBox1.MaskFull)
            {
                MessageBox.Show("Please Enter Valid Date", "Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Raw7 LeOmak", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
