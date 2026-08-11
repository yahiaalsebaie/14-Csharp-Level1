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
    public partial class frmComboBoxPictures : Form
    {
        public frmComboBoxPictures()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmComboBoxPictures_Load(object sender, EventArgs e)
        {
            cmbPictures.SelectedIndex = 0;
        }

        private void cmbPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPictures.SelectedItem.ToString().ToLower())
            {
                case "boy":
                    pictureBox1.Image = Resources.Boy;
                    lblTiltle.Text = "Boy";
                    break;
                case "girl":
                    pictureBox1.Image = Resources.Girl;
                    lblTiltle.Text = "Girl";
                    break;
                case "pen":
                    pictureBox1.Image = Resources.Pen;
                    lblTiltle.Text = "Pen";
                    break;
                case "book":
                    pictureBox1.Image = Resources.Book;
                    lblTiltle.Text = "Book";
                    break;
                default:
                    break;
            }

        }
    }
}
