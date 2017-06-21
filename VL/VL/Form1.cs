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
            DR.A = pictureBox1.Width * 0.1f;
            DR.B = 2;
            DR.yColor = Color.FromArgb(254, 226, 13);
             DR.DR = pictureBox1.CreateGraphics();
             DR.F = float.Parse(F.Text);
             DR.MooD = float.Parse(MooD.Text);
             DR.Do = float.Parse(Do.Text);
             DR.Di = float.Parse(Di.Text);
             DR.Ho = float.Parse(Ho.Text);
             DR.Hi = float.Parse(Hi.Text);
             DR.HighT = pictureBox1.Height;
             DR.WighT = pictureBox1.Width;
             DR.CoordinateS();
             DR.ConveX();
        }
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
        }
       
        
    }
}
