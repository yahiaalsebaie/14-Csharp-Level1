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
    public partial class frmDialog : Form
    {
        public frmDialog()
        {
            InitializeComponent();
        }

        private void btnChangeBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
            }
        }

        private void btnChangeForeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowApply = true;
            fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = true;


            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;

            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            textBox1.Font = fontDialog1.Font;
            textBox1.ForeColor = fontDialog1.Color;
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        { // وظيفتها الأساسية ترجع اسم الملف فقط
            //saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.InitialDirectory = @"Desktop";

            saveFileDialog1.Title = "Save As";

            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "txt Files (*.txt)|*.txt|Mp3 (*.mp3)|*.mp3|All Files(*.*)|*.*";
            saveFileDialog1.FilterIndex = 0;

            

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName);
            }
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"Desktop";
            openFileDialog1.Title = "Open File";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt Files (*.txt)|*.txt|Mp3 (*.mp3)|*.mp3|Png (*.png)|*.png|All Files(*.*)|*.*";
            openFileDialog1.FilterIndex = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }

        }

        private void btnOpenFileDialogMultiSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            // أضيفهم أو لأ براحتي
            openFileDialog1.InitialDirectory = @"Desktop";
            openFileDialog1.Title = "Open File";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt Files (*.txt)|*.txt|Mp3 (*.mp3)|*.mp3|Png (*.png)|*.png|All Files(*.*)|*.*";
            openFileDialog1.FilterIndex = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in openFileDialog1.FileNames) //var == string
                {
                    MessageBox.Show(file);
                }
            }
        }

        private void btnFolderBrowserDialog_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }

        }

        private void frmDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
