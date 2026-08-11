using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;


            for (int i = 1; i <= 10; i++)
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    Thread.Sleep(500);
                    /*
                     ممكن مستقبلًا نستخدم 
                    async/await
                    بدال Thread.Sleep()
                    علشان البرنامج ما يعلقش 
                    (UI thread بيقف مؤقتًا).
                     */
                    progressBar1.Value += 10; // i < 10 الرقم هنا مربوط بعدد اللفات 

                    label1.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100) + "%";
                    /*label1.Text = ((progressBar1.Value / progressBar1.Maximum) * 100).ToString();*/

                    progressBar1.Refresh(); // عشان استخدمت ثريد سليب؛
                    label1.Refresh(); // استخدمت ريفريش عشان يظهرلي نتيجة على الشاشة
                }
                else button2.Enabled = false; // Disable start btn
            }
        }


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            label1.Text = "0%";
            button2.Enabled = true;
        }
    }
}
