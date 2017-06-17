using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace VL
{
    public partial class Form1 : MetroForm
    {
        Draw DR = new Draw();
        Graphics RE;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
             pictureBox1.Refresh();
             DR.DR = pictureBox1.CreateGraphics();
             DR.F = float.Parse(F.Text);
             DR.MooD = float.Parse(MooD.Text);
             DR.HighT = pictureBox1.Height;
             DR.WighT = pictureBox1.Width;
             DR.CoordinateS();
             DR.ConveX();
             RflectioN();
             DR.MieN_LinE(); 

        }


        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
        }
        public void RflectioN()
        {
            RE = pictureBox1.CreateGraphics();
            float DI = float.Parse(Di.Text); float DO = float.Parse(Do.Text);
            float HI = float.Parse(Hi.Text); float HO = float.Parse(Ho.Text);
            float Mood = float.Parse(MooD.Text); float f = float.Parse(F.Text);
            // PointS
            //BodY
            PointF pBODY1 = new PointF(715 - (DO * Mood), f * (Mood) * 2 + 120); PointF pBODY2 = new PointF(715 - (DO * Mood), f * (Mood) * 2 + 120-DI * (Mood) );
            RE.DrawLine(Pens.Black,pBODY1,pBODY2);
            //Imge
            PointF pIMGE1 = new PointF(715-(HO * Mood), f * (Mood) * 2 + 120); PointF pIMGE2 = new PointF(715 - (HO * Mood), f * (Mood) * 2 + 120 + HI * (Mood));
            RE.DrawLine(Pens.Black, pIMGE1, pIMGE2);
        }
        
    }
}
