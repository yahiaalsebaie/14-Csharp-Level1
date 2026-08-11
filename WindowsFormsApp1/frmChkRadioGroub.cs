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

namespace WindowsFormsApp1
{

   
    public partial class frmChkRadioGroup : Form
    {
        int Price = 0;
        int CrustPrice = 0;

        public frmChkRadioGroup()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnchkReceveEmails.Enabled = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString(),"Check Box State");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //SmallPizza
            if (rbSmall.Checked)
            {
                Price = 30;
            }
            UpdateTotalPrice();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gbPizzaSize.Enabled = false;
            gbPizzaCrust.Enabled = false;
            MessageBox.Show("Order Taken", "Booyakasha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void UpdateTotalPrice()
        {
            txtPrice.Text = (Price + CrustPrice).ToString() + "$";
        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void gbPizzaSize_Enter(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            gbPizzaSize.Enabled = true;
            gbPizzaCrust.Enabled = true;
            Price = 0;
            CrustPrice = 0;
            gbPizzaCrust = new GroupBox();
            gbPizzaSize = new GroupBox();
            UpdateTotalPrice();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            //MediumPizza
            if (rbMedium.Checked)
            {
                Price = 35;
            }
            UpdateTotalPrice();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            //LargePizza
            if (rbLarge.Checked)
            {
                Price = 40;
            }
            UpdateTotalPrice();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //ThinCrust
            if (rbThinCrust.Checked)
            {
                CrustPrice = 5;
            }
            UpdateTotalPrice();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            //ThickCrust
            if (rbThickCrust.Checked)
            {
                CrustPrice = 10;
            }
            UpdateTotalPrice();
        }

        private void frmChkRadioGroup_Load(object sender, EventArgs e)
        {

        }

        private void gbPizzaCrust_Enter(object sender, EventArgs e)
        {


        }
    }
}
