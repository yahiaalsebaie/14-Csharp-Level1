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
    public partial class frmCheckedBox : Form
    {
        public frmCheckedBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//Add Items
            for (int i = 1; i <= 5; i++)
            {
                checkedListBox1.Items.Add("Item " + i);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {//Show Selected Items
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                MessageBox.Show(checkedListBox1.CheckedItems[i].ToString(),"Selected Item(s)",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("No Checked Items", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//Check All Items
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i,true);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {//Uncheck All Items

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {//Remove Third Item
            if (checkedListBox1.Items.Count < 3)
            {
                MessageBox.Show("There Is No Third Item To Remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                checkedListBox1.Items.RemoveAt(2);
        }
    }
}
