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

        public float A { get; set; }
        public int B { get; set; }
        
        public float MooD { get; set; }
        public float WighT { get; set; }
        public float HighT { get; set; }
        public Graphics DR { get; set; }

        public void ConcavE_MirrorS()
        {
            //PointS
            //1
            PointF P1 = new PointF((470 + A) - (F * 4), 120); PointF P2 = new PointF((490 + A), 120 + (F * (MooD * 2))); PointF P3 = new PointF((470 + A) - (F * 4), ((4 * MooD) * F) + 120);
            //2
            PointF P4 = new PointF((500 + A) - (F * 2), 120); PointF P5 = new PointF((520+A), 120 + (F * (MooD * 2))); PointF P6 = new PointF((500 + A) - (F * 2), ((4 * MooD) * F) + 120);
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
            PointF f1 = new PointF((500 +A) - F * MooD , F * 2 * MooD + 120);
            DR.DrawString(ff, fo, fb, f1);
            //C
            string cc = "C";
            Font co = new Font("Arial", 12);
            SolidBrush cb = new SolidBrush(Color.Black);
            PointF cc1 = new PointF((500 +A) - F * (MooD * 2), F * (MooD * 2) + 120);
            DR.DrawString(cc, co, cb, cc1);
            ConcavE_MiroorS_R(); MieN_LinE();
        }
        public void ConcavE_MiroorS_R()
        {
            //PointS
            PointF pBM1 = new PointF((505 +A) - (Do * MooD), F * (MooD) * 2 + 120 - Di * (MooD)); PointF pBM2 = new PointF((505 +A), F * (MooD) * 2 + 120 - Di * (MooD));
            PointF pMF1 = new PointF((505 +A) - F * MooD, F * 2 * MooD + 120);
            PointF pFI1 = new PointF((505 +A) - (Ho * MooD), F * (MooD) * 2 + 120 + Hi * (MooD));
            PointF pBM3 = new PointF((505 +A), F * (MooD) * 2 + 120 + Hi * (MooD)); PointF pBM4 = new PointF((505 +A), F * 2 * MooD + 100);
            PointF pMI1 = new PointF(0, F * (MooD) * 2 + 120 + Hi * (MooD)); PointF pMI2 = new PointF((505 +A) + (Ho * MooD), F * (MooD) * 2 + 120 - Hi * (MooD));
            Point pZ1 = new Point(0, 0); PointF pZ2 = new PointF(0, F * 2 * MooD + 100);
            if (Do > F)
            {
                ///..M
                //first line[
                // from bady to mirror
                DR.DrawLine(Pens.Black, pBM1, pBM2);
                // from mirror to F//using pBM2
                DR.DrawLine(Pens.Black, pMF1, pBM2);
                // from F to imge // using pMF1
                DR.DrawLine(Pens.Black, pFI1, pMF1);
                // from imge to endless// using pFI1 
                /* float p1 = (505 +A) - (Ho * MooD); float p2 = F * (MooD) * 2 + 120 + Hi * (MooD);
                 float p3 = WighT; float p4 = (p3 - p1) * p2;
                 PointF pIE1 = new PointF((-1*p3),p4);
                 DR.DrawLine(Pens.Blue,pIE1,pFI1);
                 //]*/
                // [
                // from bady to mirror // using pBM1
                DR.DrawLine(Pens.Black, pBM3, pBM1);
                // form mirror to imge // using pBM3
                DR.DrawLine(Pens.Black, pBM3, pMI1);
                // ]
                RflectioN_D();
            }
            else
            {
                // from bady to mirror
                DR.DrawLine(Pens.Black, pBM1, pBM2);
                // from mirror to imge // using pBM2
                DR.DrawLine(Pens.Black,pMI2, pBM2);
                // from 0 to mirror 
                // using pBM2
                DR.DrawLine(Pens.Black, pZ1, pBM2);
                // from body to mirror // using pBM1
                DR.DrawLine(Pens.Black, pBM1, pBM4);
                // from mirror to imge // using pMI2
                DR.DrawLine(Pens.Black, pMI2, pBM4);
                // from 0 to mirror // using pBM4
                DR.DrawLine(Pens.Black, pBM4, pZ2);
                RflectioN_U();
            }
        }
        public void ConveX_MirrorS()
        {
            //PointS
            //1
            PointF P1 = new PointF((520 +A) - (F * 4), 120); PointF P2 = new PointF((490 +A), 120 + (F * (MooD * 2))); PointF P3 = new PointF((520 +A) - (F * 4), ((4 * MooD) * F) + 120);
            //2
            PointF P4 = new PointF((560 +A) - (F * 2), 120); PointF P5 = new PointF((520 +A), 120 + (F * (MooD * 2))); PointF P6 = new PointF((560 +A) - (F * 2), ((4 * MooD) * F) + 120);
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
            PointF f1 = new PointF((500 +A) - F * MooD, F * 2 * MooD + 120);
            DR.DrawString(ff, fo, fb, f1);
            //C
            string cc = "C";
            Font co = new Font("Arial", 12);
            SolidBrush cb = new SolidBrush(Color.Black);
            PointF cc1 = new PointF((500 +A) - F * (MooD * 2), F * (MooD * 2) + 120);
            DR.DrawString(cc, co, cb, cc1);
            ConveX_MirrorS_R(); MieN_LinE();
        }
        public void ConveX_MirrorS_R()
        {
            PointF pBM1 = new PointF((505 +A) - (Do * MooD), F * (MooD) * 2 + 120 - Di * (MooD)); PointF pBM2 = new PointF((505 +A), F * (MooD) * 2 + 120 - Di * (MooD));
            Point pZ1 = new Point(0, 0); PointF pZ2 = new PointF(0, F * 2 * MooD + 100);
            PointF pMI2 = new PointF((505 +A) + (Ho * MooD), F * (MooD) * 2 + 120 - Hi * (MooD));
            PointF pBM4 = new PointF((505 +A), F * 2 * MooD + 100);
            // from bady to mirror
            DR.DrawLine(Pens.Black, pBM1, pBM2);
            // from mirror to imge // using pBM2
            DR.DrawLine(Pens.Black, pMI2, pBM2);
            // from 0 to mirror 
            // using pBM2
            DR.DrawLine(Pens.Black, pZ1, pBM2);
            // from body to mirror // using pBM1
            DR.DrawLine(Pens.Black, pBM1, pBM4);
            // from mirror to imge // using pMI2
            DR.DrawLine(Pens.Black, pMI2, pBM4);
            // from 0 to mirror // using pBM4
            DR.DrawLine(Pens.Black, pBM4, pZ2);

        }
        public void ConcavE()
        {
            //PointS
            //1
            PointF P1 = new PointF(495 + A, 120); PointF P2 = new PointF(475 + A, 120 + (F * (MooD * 2))); PointF P3 = new PointF(495 + A, ((4 * MooD) * F) + 120);
            //2
            PointF P4 = new PointF(515 + A, 120); PointF P5 = new PointF(535 + A, 120 + (F * (MooD * 2))); PointF P6 = new PointF(515 + A, ((4 * MooD) * F) + 120);
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
            PointF f1 = new PointF((500+A) - F * MooD, F * 2 * MooD + 120); PointF f2 = new PointF((500 + A) + F * MooD, F * 2 * MooD + 120);
            DR.DrawString(ff, fo, fb, f1); DR.DrawString(ff, fo, fb, f2);
            //C
            string cc = "2F";
            Font co = new Font("Arial", 12);
            SolidBrush cb = new SolidBrush(Color.Black);
            PointF cc1 = new PointF((500 + A) - F * (MooD * 2), F * (MooD * 2) + 120); PointF cc2 = new PointF((500 + A) + F * (MooD * 2), F * (MooD * 2) + 120);
            DR.DrawString(cc, co, cb, cc1); DR.DrawString(cc, co, cb, cc2);
            ConcavE_R(); MieN_LinE();
        }
        public void ConcavE_R()
        {
            //PointS
            PointF pBM1 = new PointF((505 + A) - (Do * MooD), F * (MooD) * 2 + 120 - Di * (MooD)); PointF pBM2 = new PointF((505 + A), F * (MooD) * 2 + 120 - Di * (MooD)); PointF pBM3 = new PointF(505 + A, ((F * 2 * MooD) + 120) + Hi * MooD);
            PointF pMF1 = new PointF((500 + A) + F * MooD, F * 2 * MooD + 120);
            PointF pFI1 = new PointF((505 + A) + (MooD * Ho), ((F * 2 * MooD) + 120) + Hi * MooD);
            PointF pMI1 = new PointF((WighT * 0.9f), ((F * 2 * MooD) + 120) + Hi * MooD);PointF pMI2 = new PointF((WighT * 0.9f), ((F * 2 * MooD) + 80) - Hi * MooD); PointF pMI3 = new PointF(505+A, ((F * 2 * MooD) + 80) - Hi * MooD);
            PointF pIMGE2 = new PointF((505 + A) - (Ho * MooD), F * (MooD) * 2 + 120 - Hi * (MooD));
            if (Do > F)
            {

                // from body to glass
                DR.DrawLine(Pens.Red, pBM1, pBM2);
                //from mirror tp 2*F// using pBM2
                DR.DrawLine(Pens.Red, pBM2, pMF1);
                //from to F to imge // using pMF1
                DR.DrawLine(Pens.Red, pMF1, pFI1);
                //from body to mirror// using pBM1
                DR.DrawLine(Pens.Red, pBM1, pBM3);
                //from mirror to imge //using pBM3
                DR.DrawLine(Pens.Red, pBM3, pMI1);
             
                RflectioN_D();
            }
            else if (Do<F)
            {
                // from body to glass 
                DR.DrawLine(Pens.Red, pBM1, pBM2);
                //from glass to 2*F// using pBM2
                DR.DrawLine(Pens.Red, pBM2, pMF1);
                //from body to glass // using pBM1
                DR.DrawLine(Pens.Red, pBM1, pMI3);
                //from glass to end // using pMI3
                DR.DrawLine(Pens.Red, pMI3, pMI2);
                //from glass to imge // using pBM2
                DR.DrawLine(Pens.Red, pBM2, pIMGE2);
                //from glass to imge // using pMI3
                DR.DrawLine(Pens.Red, pMI3, pIMGE2);

                RflectioN_U();

            }
        }
        public void ConveX()
        {
            //PointS
            //1
            PointF P1 = new PointF((465 +A) , 120); PointF P2 = new PointF((495 +A), 120 + (F * (MooD * 2))); PointF P3 = new PointF((465 +A), ((4 * MooD) * F) + 120);
            //2
            PointF P4 = new PointF((535 +A) , 120); PointF P5 = new PointF((515 +A), 120 + (F * (MooD * 2))); PointF P6 = new PointF((535 +A), ((4 * MooD) * F) + 120);
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
            PointF f1 = new PointF((500 +A) - F * MooD, F * 2 * MooD + 120); PointF f2 = new PointF((500 + A) + F * MooD, F * 2 * MooD + 120);
            DR.DrawString(ff, fo, fb, f1); DR.DrawString(ff, fo, fb, f2);
            //C
            string cc = "2F";
            Font co = new Font("Arial", 12);
            SolidBrush cb = new SolidBrush(Color.Black);
            PointF cc1 = new PointF((500 +A) - F * (MooD * 2), F *  (2 * MooD) + 120); PointF cc2 = new PointF((500 + A) + F * (MooD * 2), F * (2 * MooD) + 120);
            DR.DrawString(cc, co, cb, cc2); DR.DrawString(cc, co, cb, cc1);
            MieN_LinE();

        }
        public void ConveX_R()
        {

        }
        public void MieN_LinE()
        {
            // PointS
            //[
            //ColM
            PointF P1 = new PointF( (505 +A) , 120 ); PointF P2 = new PointF( (505 +A), F * ( MooD * 4 ) + 120 );
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
        public void RflectioN_D()
        {
            //BodY
            PointF pBODY1 = new PointF((505 + A) - (Do * MooD), F * (MooD) * 2 + 120); PointF pBODY2 = new PointF((505 + A) - (Do * MooD), F * (MooD) * 2 + 120 - Di * (MooD));
            DR.DrawLine(Pens.Black, pBODY1, pBODY2);
            if (B == 1)

            {//Imge
                PointF pIMGE1 = new PointF((505 + A) - (Ho * MooD), F * (MooD) * 2 + 120); PointF pIMGE2 = new PointF((505 + A) - (Ho * MooD), F * (MooD) * 2 + 120 + Hi * (MooD));
                DR.DrawLine(Pens.Black, pIMGE1, pIMGE2);

            }
            else if (B == 2)
            {//Imge
                PointF pIMGE1 = new PointF((505 + A) + (Ho * MooD), F * (MooD) * 2 + 120); PointF pIMGE2 = new PointF((505 + A) + (Ho * MooD), F * (MooD) * 2 + 120 + Hi * (MooD));
                DR.DrawLine(Pens.Black, pIMGE1, pIMGE2);
            }
            else { return; }
            
           

        }
        public void RflectioN_U()
        {
            // PointS
            //BodY
            PointF pBODY1 = new PointF((505 +A) - (Do * MooD), F * (MooD) * 2 + 120); PointF pBODY2 = new PointF((505 +A) - (Do * MooD), F * (MooD) * 2 + 120 - Di * (MooD));
            DR.DrawLine(Pens.Black, pBODY1, pBODY2);
            //Imge
            if (B == 1)
            {
                PointF pIMGE1 = new PointF((505 + A) + (Ho * MooD), F * (MooD) * 2 + 120); PointF pIMGE2 = new PointF((505 + A) + (Ho * MooD), F * (MooD) * 2 + 120 - Hi * (MooD));
                DR.DrawLine(Pens.Black, pIMGE1, pIMGE2);
            }
            else if (B == 2)
            {
                PointF pIMGE1 = new PointF((505 + A) - (Ho * MooD), F * (MooD) * 2 + 120); PointF pIMGE2 = new PointF((505 + A) - (Ho * MooD), F * (MooD) * 2 + 120 - Hi * (MooD));
                DR.DrawLine(Pens.Black, pIMGE1, pIMGE2);
            }
            
        }
    }
}
