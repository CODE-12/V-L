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
        Draw DR = new Draw(); Equations EQ = new Equations();
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
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Di_M.Text == "?")
                {
                    EQ.Do = float.Parse(Do_M.Text);
                    EQ.Ho = float.Parse(Ho_M.Text); EQ.Hi = float.Parse(Hi_M.Text);
                    EQ.Missing_Di_M();
                    T_M.Text = EQ.Tips; R_M.Text = EQ.Res_S;
                }
                else if (Do_M.Text == "?")
                {
                    EQ.Di = float.Parse(Di_M.Text);
                    EQ.Ho = float.Parse(Ho_M.Text); EQ.Hi = float.Parse(Hi_M.Text);
                    EQ.Missing_Do_M();
                    T_M.Text = EQ.Tips; R_M.Text = EQ.Res_S;
                }
                else if (Hi_M.Text == "?")
                {
                    EQ.Do = float.Parse(Do_M.Text);
                    EQ.Ho = float.Parse(Ho_M.Text); EQ.Di = float.Parse(Di_M.Text);
                    EQ.Missing_Hi_M();
                    T_M.Text = EQ.Tips; R_M.Text = EQ.Res_S;
                }
                else if (Ho_M.Text == "?")
                {
                    EQ.Do = float.Parse(Do_M.Text);
                    EQ.Di = float.Parse(Di_M.Text); EQ.Hi = float.Parse(Hi_M.Text);
                    EQ.Missing_Ho_M();
                    T_M.Text = EQ.Tips; R_M.Text = EQ.Res_S;
                }
            }
            catch { return; }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (F_F.Text=="?")
                {
                    EQ.Di = float.Parse(Di_F.Text); EQ.Do = float.Parse(Do_F.Text);
                    EQ.Missing_F_F();
                    R_F.Text = EQ.Res_S;T_F.Text = EQ.Tips;
                }
               else if (Di_F.Text == "?")
               {
                    EQ.F = float.Parse(F_F.Text); EQ.Do = float.Parse(Do_F.Text);
                    EQ.Missing_Di_F();
                    R_F.Text = EQ.Res_S; T_F.Text = EQ.Tips;
               }
               else if (Do_F.Text == "?")
               {
                    EQ.Di = float.Parse(Di_F.Text); EQ.F = float.Parse(F_F.Text);
                    EQ.Missing_Do_F();
                    R_F.Text = EQ.Res_S; T_F.Text = EQ.Tips;
               }
            }
            catch{ return; }
        }
    }
}
