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
             DR.DR = pictureBox1.CreateGraphics();
             DR.F = float.Parse(F.Text);
             DR.MooD = float.Parse(MooD.Text);
             DR.HighT = pictureBox1.Height;
             DR.WighT = pictureBox1.Width;


            DR.ConveX();
             DR.MieN_LinE();

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
        }
        
    }
}
