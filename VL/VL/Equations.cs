using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VL
{
    class Equations
    {
        public float Di { get; set; }
        public float Do { get; set; }
        public float Hi { get; set; }
        public float Ho { get; set; }
        public float F { get; set; }
        public double Res { get; set; }
        public string Tips { get; set; }
        // M = Hi / Ho = -Di / DO 
        //[
        public void Missing_Di_M()
        {
            // M = Hi / Ho = -Di / DO // Di = (Hi * Do) / - Ho
            Res = (Hi * Do) / -Ho;
            Tips = @" M = Hi / Ho = -Di / DO /" + "/n" + "Di = (Hi * Do) / - Ho " + "/n" + "Di =" + "(" + Hi + "+" + "X" + Do + ")" + "/" + "-" + Ho; 
            
        }
        public void Missing_Do_M()
        {
            // M = Hi / Ho = -Di / DO // Do = (Ho * (-1 * Di)) /  Hi
            Res = (Ho * (-1 * Di)) / Hi;
            Tips = @" M = Hi / Ho = -Di / DO /" + "/n" + "Do = (Ho * -Di) / Hi " + "/n" + "Do =" + "(" + Ho + "+" + "X" + -Di + ")" + "/"  + Hi;
        }
        public void Missing_Hi_M()
        {
            // M = Hi / Ho = -Di / DO // Hi = (Ho * -Di) / Do
            Res = (Ho * -Di) / Do;
            Tips = @" M = Hi / Ho = -Di / DO /" + "/n" + "Hi = (Ho * -Di) /  do " + "/n" + "Hi =" + "(" + Ho + "+" + "X" + -Di + ")" + "/"  + Hi;
        }
        public void Missing_Ho_M()
        {
            // M = Hi / Ho = -Di / DO // Ho = (Hi * Do) / -Di
            Res = (Hi * Do) / -Di;
            Tips = @" M = Hi / Ho = -Di / DO /" + "/n" + "Ho = (Hi * Do) / - Di " + "/n" + "Ho =" + "(" + Hi + "+" + "X" + Do + ")" + "/" + "-" + Di;
        }
        //]
        // 1/f = 1/di + 1/do
        //[
        public void Missing_Di_F()
        {
            // 1/f = 1/di + 1/do // 1/di = 1/Do - 1/F 
            Res = 1 / Do - 1 / F; Res += Math.Pow(Res, -1);
            Tips = " 1/f = 1/di + 1/do " + "/n" + " 1/di = 1/do - 1/f " + "/n" +"1 / di =" + 1 / Do + "-" + 1 / F;

        }
        public void Missing_Do_F()
        {
            // 1/f = 1/di + 1/do // 1/do = 1/Di - 1/F 
            Res = 1 / Di - 1 / F; Res += Math.Pow(Res, -1);
            Tips = " 1/f = 1/di + 1/do " + "/n" + " 1/do = 1/di - 1/f " + "/n" + "1 / do ="+1 /Di+ "-" +1 / F;

        }
        public void Missing_F_F()
        {
            // 1/f = 1/di + 1/do // 1/di = 1/Do - 1/F 
            Res = 1 / Do + 1 / Di; Res += Math.Pow(Res, -1);
            Tips = "// 1/f = 1/di + 1/do " + "/n" +  "1 / f =" +  1 /Do + "+" + 1 / Di;

        }
        //]
    }
}
