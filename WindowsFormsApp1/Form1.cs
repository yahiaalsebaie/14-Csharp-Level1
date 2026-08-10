using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void btn_textBox1_ClearClick(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
        private void btn_textBox2_ClearClick(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }

        private void btn_ClearClick(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text;
        }


        private void btn4_textBox1_Enabled_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void btn3_textBox1_Disabled_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.White;
            textBox3.BackColor = Color.LightSeaGreen;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = default;
            textBox3.BackColor = default;
        }

        private void btnFrmColor_Click_1(object sender, EventArgs e)
        {

            Random random = new Random();
            int r = random.Next(0, 255);
            int g = random.Next(0, 255);
            int b = random.Next(0, 255);
            this.BackColor = Color.FromArgb(r, g, b);
            label1.BackColor = Color.FromArgb(r, g, b);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.BackColor = default;
            label1.BackColor = default;
        }

        private void btnChangeFormTitle_Click(object sender, EventArgs e)
        {
            ChangeFormTitle();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.BackColor = this.BackColor;
            this.Close();
        }

        private void ChangeFormTitle()
        {
            string text = textBox4.Text.Trim();
            this.Text = text;
            label1.Text = text;
            textBox4.Clear();
        }
        private void textBox4_DragEnter(object sender, DragEventArgs e)
        {
            ChangeFormTitle();
        }
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ChangeFormTitle();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
