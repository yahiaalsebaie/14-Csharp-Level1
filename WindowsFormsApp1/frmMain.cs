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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnShowPart1_Click_1(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.Show();
        }

        private void btn1ShowDialoged_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMessageBox();
            frm1.Show();
        }

        private void btnCheckBox_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmChkRadioGroup();
            frm1.Show();
        }

        private void btnTextBoxFrm_Click(object sender, EventArgs e)
        {
            Form form = new frmTextBox();
            form.Show();
        }

        private void btnShowImageBox_Click(object sender, EventArgs e)
        {
            Form frm = new frmImageBox();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form frm = new frmBetterCallSaul();
            frm.Show();
        }

        private void btnDraw_frm_Click(object sender, EventArgs e)
        {
            Form frm = new frmDraw();
            frm.Show();
        }

        private void btnShowMaskedBox_frm_Click(object sender, EventArgs e)
        {
            Form form = new frmMaskedBox();
            form.ShowDialog();
        }

        private void btnComboBox_frm_Click(object sender, EventArgs e)
        {
            Form  frm = new frmComboBox();
            frm.ShowDialog();
        }

        private void btnComboBoxPictures_frm_Click(object sender, EventArgs e)
        {
            Form frm = new frmComboBoxPictures();
            frm.Show();
        }

        private void btnLinkLabe_fem_Click(object sender, EventArgs e)
        {
            Form frm = new frmLinkLable();
            frm.Show();
        }

        private void btnCheckedBox_frm_Click(object sender, EventArgs e)
        {
            Form frm = new frmCheckedBox();
            frm.Show();
        }

        private void btnDateTimePicker_frm_Click(object sender, EventArgs e)
        {
            Form frm =  new frmDateTimePicker();
            frm.Show();
        }

        private void btnMonthCalendar_frm_Click(object sender, EventArgs e)
        {
            Form frm = new frmMonthCalendar();
            frm.Show();
        }

        private void btnTimer_frm_Click(object sender, EventArgs e)
        {
            Form frm = new frmTimer();
            frm.Show();
        }

        private void btnNotifyIcon_frm_Click(object sender, EventArgs e)
        {
            Form frm = new frmNotifyIcon();
            frm.Show();
        }

        private void btnTreeView_frm_Click(object sender, EventArgs e)
        {
            Form frm = new frmTreeView();
            frm.Show();
        }

        private void btnProgressBar_frm_Click(object sender, EventArgs e)
        {
            Form frm = new frmProgressBar();
            frm.Show();
        }

        private void btnListView_frm_Click(object sender, EventArgs e)
        {
            Form frm = new frmListView();
            frm.Show();
        }

        private void btnErrorProvider_frm_Click(object sender, EventArgs e)
        {
            Form frm = new frmErrorProvider();
            frm.Show();
        }

        private void btnTrackBar_frm_Click(object sender, EventArgs e)
        {
            Form frm = new frmTrackBar();
            frm.Show();
        }

        private void btnNumericUpDown_frm_Click(object sender, EventArgs e)
        {
            Form frm = new frmNumaricUpDown();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new frmTabControl();
            frm.Show();
        }

        private void btnColorDialog_frm_Click(object sender, EventArgs e)
        {
            Form frm = new frmDialog();
            frm.Show();
        }
    }
}
