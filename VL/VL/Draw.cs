using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace VL
{
    class Draw
    {
        public float F { get; set; }
        public float Do { get; set; }
        public float Di { get; set; }
        public float Ho { get; set; }
        public float Hi { get; set; }


        public float MooD { get; set; }
        public float WighT { get; set; }
        public float HighT { get; set; }
        public Graphics DR;
       

        public void ConcavE_MirrorS()
        {
            
            //PointS
            //1
            PointF P1 = new PointF(680 - (F * 4), 120); PointF P2 = new PointF(700, 120 + (F * (MooD * 2))); PointF P3 = new PointF(680 - (F * 4), ((4 * MooD) * F) + 120);
            //2
            PointF P4 = new PointF(710 - (F * 2), 120); PointF P5 = new PointF(730, 120 + (F * (MooD * 2))); PointF P6 = new PointF(710 - (F * 2), ((4 * MooD) * F) + 120);

            //CurvE1
            PointF[] point1 = { P1, P2, P3 };
            DR.DrawCurve(Pens.Gray, point1);

            //CurvE2
            PointF[] point2 = { P4, P5, P6 };
            DR.DrawCurve(Pens.Gray, point2);

            //LineS
            //1
            DR.DrawLine(Pens.Gray, P1, P4);
            //2
            DR.DrawLine(Pens.Gray, P3, P6);


            //F
          
            string ff = "F";
            Font fo = new Font("Arial", 12);
            SolidBrush fb = new SolidBrush(Color.Black);
            PointF f1 = new PointF(710 - F * MooD , F * 2 * MooD + 120);
            DR.DrawString(ff, fo, fb, f1);

            //C

            string cc = "C";
            Font co = new Font("Arial", 12);
            SolidBrush cb = new SolidBrush(Color.Black);
            PointF cc1 = new PointF(710 - F * (MooD * 2), F * (MooD * 2) + 120);
            DR.DrawString(cc, co, cb, cc1);





        }
        public void ConveX_MirrorS()
        {
            //PointS
            //1
            PointF P1 = new PointF(730 - (F * 4), 120); PointF P2 = new PointF(700, 120 + (F * (MooD * 2))); PointF P3 = new PointF(730 - (F * 4), ((4 * MooD) * F) + 120);
            //2
            PointF P4 = new PointF(770 - (F * 2), 120); PointF P5 = new PointF(730, 120 + (F * (MooD * 2))); PointF P6 = new PointF(770 - (F * 2), ((4 * MooD) * F) + 120);

            //CurvE1
            PointF[] point1 = { P1, P2, P3 };
            DR.DrawCurve(Pens.Gray, point1);

            //CurvE2
            PointF[] point2 = { P4, P5, P6 };
            DR.DrawCurve(Pens.Gray, point2);

            //LineS
            //1
            DR.DrawLine(Pens.Gray, P1, P4);
            //2
            DR.DrawLine(Pens.Gray, P3, P6);


            //F

            string ff = "F";
            Font fo = new Font("Arial", 12);
            SolidBrush fb = new SolidBrush(Color.Black);
            PointF f1 = new PointF(710 - F * MooD, F * 2 * MooD + 120);
            DR.DrawString(ff, fo, fb, f1);

            //C

            string cc = "C";
            Font co = new Font("Arial", 12);
            SolidBrush cb = new SolidBrush(Color.Black);
            PointF cc1 = new PointF(710 - F * (MooD * 2), F * (MooD * 2) + 120);
            DR.DrawString(cc, co, cb, cc1);


        }
        public void ConcavE()
        {
            //PointS
            //1
            PointF P1 = new PointF(705, 120); PointF P2 = new PointF(685, 120 + (F * (MooD * 2))); PointF P3 = new PointF(705, ((4 * MooD) * F) + 120);
            //2
            PointF P4 = new PointF(725, 120); PointF P5 = new PointF(745, 120 + (F * (MooD * 2))); PointF P6 = new PointF(725, ((4 * MooD) * F) + 120);

            //CurvE1
            PointF[] point1 = { P1, P2, P3 };
            DR.DrawCurve(Pens.Gray, point1);

            //CurvE2
            PointF[] point2 = { P4, P5, P6 };
            DR.DrawCurve(Pens.Gray, point2);

            //LineS
            //1
            DR.DrawLine(Pens.Gray, P1, P4);
            //2
            DR.DrawLine(Pens.Gray, P3, P6);


            //F

            string ff = "F";
            Font fo = new Font("Arial", 12);
            SolidBrush fb = new SolidBrush(Color.Black);
            PointF f1 = new PointF(710 - F * MooD, F * 2 * MooD + 120);
            DR.DrawString(ff, fo, fb, f1);

            //C

            string cc = "C";
            Font co = new Font("Arial", 12);
            SolidBrush cb = new SolidBrush(Color.Black);
            PointF cc1 = new PointF(710 - F * (MooD * 2),F * (MooD * 2) + 120);
            DR.DrawString(cc, co, cb, cc1);



        }
        public void ConveX()
        {
            //PointS
            //1
            PointF P1 = new PointF(675 , 120); PointF P2 = new PointF(705, 120 + (F * (MooD * 2))); PointF P3 = new PointF(675, ((4 * MooD) * F) + 120);
            //2
            PointF P4 = new PointF(745 , 120); PointF P5 = new PointF(725, 120 + (F * (MooD * 2))); PointF P6 = new PointF(745, ((4 * MooD) * F) + 120);

            //CurvE1
            PointF[] point1 = { P1, P2, P3 };
            DR.DrawCurve(Pens.Gray, point1);

            //CurvE2
            PointF[] point2 = { P4, P5, P6 };
            DR.DrawCurve(Pens.Gray, point2);

            //LineS
            //1
            DR.DrawLine(Pens.Gray, P1, P4);
            //2
            DR.DrawLine(Pens.Gray, P3, P6);


            //F

            string ff = "F";
            Font fo = new Font("Arial", 12);
            SolidBrush fb = new SolidBrush(Color.Black);
            PointF f1 = new PointF(710 - F * MooD, F * 2 * MooD + 120);
            DR.DrawString(ff, fo, fb, f1);

            //C

            string cc = "C";
            Font co = new Font("Arial", 12);
            SolidBrush cb = new SolidBrush(Color.Black);
            PointF cc1 = new PointF(710 - F * (MooD * 2), F *  (2 * MooD) + 120);
            DR.DrawString(cc, co, cb, cc1);

        }
        public void MieN_LinE()
        {
            // PointS
            //[
            //ColM
            PointF P1 = new PointF( 715 , 120 ); PointF P2 = new PointF( 715, F * ( MooD * 4 ) + 120 );
            DR.DrawLine(Pens.Black, P1, P2);
            //RoW
            PointF P3 = new PointF(0, F * (MooD * 2) + 120); PointF P4 = new PointF(WighT, F * ( MooD * 2) + 120);
            DR.DrawLine(Pens.Black, P3, P4);
            //]
        }
        public void CoordinateS()
        {
           
            float x1 = 0;
            float y1 = 0;
            float x2 = x1;
            float y2 = HighT;
            for (x1 = 0; x1 < WighT; x1 += (MooD-0.2f), x2 += (MooD-0.2f))
            {

                
                DR.DrawLine(Pens.DarkGray, x1, y1, x2, y2);
            }

            float x3 = 0;
            float y3 = 0;
            float x4 = WighT;
            float y4 = y3;
            for (y3 = 0; y3 < HighT; y3 += (MooD ), y4 += (MooD ))
            {
               
                DR.DrawLine(Pens.DarkGray, x3, y3, x4, y4);

            }





        }
        public void RflectioN()
        {
            // PointS
            //BodY
            PointF pBODY1 = new PointF(715 - (Do * MooD), F * (MooD) * 2 + 120); PointF pBODY2 = new PointF(715 - (Do * MooD), F * (MooD) * 2 + 120 - Di * (MooD));
            DR.DrawLine(Pens.Black, pBODY1, pBODY2);
            //Imge
            PointF pIMGE1 = new PointF(715 - (Ho * MooD), F * (MooD) * 2 + 120); PointF pIMGE2 = new PointF(715 - (Ho * MooD), F * (MooD) * 2 + 120 + Hi * (MooD));
            DR.DrawLine(Pens.Black, pIMGE1, pIMGE2);
        }
    }
}
