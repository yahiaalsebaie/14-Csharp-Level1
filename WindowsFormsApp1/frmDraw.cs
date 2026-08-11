using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmDraw : Form
    {
        public frmDraw()
        {
            InitializeComponent();
        }

        private void frmDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // 1. Circle الإطار
            using (Pen Pen = new Pen(Color.Silver, 20))
            {
                Pen.StartCap = LineCap.Round;
                Pen.EndCap = LineCap.Round;
                g.DrawEllipse(Pen, 200, 100, 400, 400);
                using (Pen silverPen = new Pen(Color.DarkGreen, 8))
                {
                    silverPen.StartCap = LineCap.Round;
                    silverPen.EndCap = LineCap.Round;
                    g.DrawEllipse(silverPen, 200, 100, 400, 400);
                }
            }
           

            // 2. عقرب الساعات
            using (Pen hourPen = new Pen(Color.Black, 12))
            {
                hourPen.StartCap = LineCap.Round;
                hourPen.EndCap = LineCap.ArrowAnchor;
                g.DrawLine(hourPen, 400, 300, 400, 170);  // من مركز الساعة لأعلى 12
            }

            // 3. نرسم عقرب الثواني
            using (Pen secondPen = new Pen(Color.Red, 8))
            {
                secondPen.StartCap = LineCap.RoundAnchor;
                secondPen.EndCap = LineCap.ArrowAnchor;
                g.DrawLine(secondPen, 400, 300, 530, 400);  // من المركز لليمين السفلي 5
            }

            

        }

    }
}
