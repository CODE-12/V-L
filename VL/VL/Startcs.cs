using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace VL
{
    public partial class Start : MetroForm
    {
        public Start()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; tt();

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public void tt()
        {
            lesson.Text = null;
            experiment.Text = null;
            {
                lesson.SelectedIndex = -1;
                lesson.Items.Clear();

                lesson.Items.AddRange(new string[] { "الانعكاس والمرايا", "الانكسار والعدسات", "التداخل والحيود" });
            }
        }
        public void Lessons()
        {
            try
            {
                if (lesson.SelectedItem.ToString() == "الانعكاس والمرايا")
                {
                    experiment.SelectedIndex = -1;
                    experiment.Items.Clear();
                    experiment.Items.AddRange(new string[] { "انعكاس الضوء في مرايا محدبة", "انعكاس الضوء في مرايا مقعرة" });
                }
                else if (lesson.SelectedItem.ToString() == "الانكسار والعدسات")
                {
                  experiment.SelectedIndex = -1;
                    experiment.Items.Clear();
                    experiment.Items.AddRange(new string[] { "انكسار الضوء في عدسة محدبة", "انكسار الضوء في عدسة مقعرة" });
                }
                else if (lesson.SelectedItem.ToString() == "التداخل والحيود")
                {
                    experiment.SelectedIndex = -1;
                    experiment.Items.Clear();
                    experiment.Items.AddRange(new string[] { "تداخل الضوء المتزامن - تجربة يونج" });
                }
            }
            catch { return; }
        }
        private void Startcs_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void lesson_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lessons();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (lesson.SelectedItem == null || experiment.SelectedItem == null)
            {
                return;
            }
            else if (lesson.SelectedItem.ToString() == "الانعكاس والمرايا" && experiment.SelectedItem.ToString() == "انعكاس الضوء في مرايا مقعرة")
            {
                this.Hide();
             
                this.Close();
            }
            else if (lesson.SelectedItem.ToString() == "الانعكاس والمرايا" && experiment.SelectedItem.ToString() == "انعكاس الضوء في مرايا محدبة")
            {
                this.Hide();
              
                this.Close();
            }
            else if (lesson.SelectedItem.ToString() == "الانكسار والعدسات" && experiment.SelectedItem.ToString() == "انكسار الضوء في عدسة محدبة")
            {
                this.Hide();
            
                this.Close();
            }
            else if (lesson.SelectedItem.ToString() == "الانكسار والعدسات" && experiment.SelectedItem.ToString() == "انكسار الضوء في عدسة مقعرة")
            {
                this.Hide();
                
                this.Close();
            }
            else if (lesson.SelectedItem.ToString() == "التداخل والحيود" && experiment.SelectedItem.ToString() == "تداخل الضوء المتزامن - تجربة يونج")
            {
                this.Hide();
             
                this.Close();
            }

        }
    }
    
}
