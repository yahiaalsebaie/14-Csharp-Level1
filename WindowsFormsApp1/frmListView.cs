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
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmListView_Load(object sender, EventArgs e)
        { //في وضع Details View، الـ ListView ما بيعرضش الـ SubItems إلا لما تعرّف الأعمدة بنفسك
            listView1.Columns.Clear(); // لتنظيف الأعمدة لو موجودة قبل كده
            listView1.Columns.Add("ID", 200);     // أول عمود للرقم
            listView1.Columns.Add("Name",400);   // تاني عمود للاسم

            listView1.View = View.Details; // تأكد مرة تانية إن العرض مضبوط
        }




        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text)) return;  

            ListViewItem item = new ListViewItem(txtID.Text.Trim());
            if (rbMale.Checked) item.ImageIndex = 1;
            else item.ImageIndex = 0;

            item.SubItems.Add(txtName.Text.Trim());
            listView1.Items.Add(item);

            /*txtID.Text = "";
            txtName.Text = "";*/
            txtID.Clear();
            txtName.Clear();
            txtID.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.RemoveAt(listView1.Items.Count - 1);
               // listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void btFillRandom_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());

                if(i%2 == 0) item.ImageIndex = 1;
                else item.ImageIndex = 0;

                item.SubItems.Add("Person"+i);
                listView1.Items.Add(item);
            }
        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;

        }

        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }
    }
}
