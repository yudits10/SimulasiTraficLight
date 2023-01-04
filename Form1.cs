using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulasiTraficLight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LampuMerah.Visible = true;
            LampuKuning.Visible = false;
            LampuHijau.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (LampuMerah.Visible == true)
            {
                LampuMerah.Visible = false;
                LampuKuning.Visible = false;
                LampuHijau.Visible = true;
            }
            else if (LampuHijau.Visible == true)
            {
                LampuMerah.Visible = false;
                LampuKuning.Visible = true;
                LampuHijau.Visible = false;
            }
            else if (LampuKuning.Visible == true)
            {
                LampuMerah.Visible = true;
                LampuKuning.Visible = false;
                LampuHijau.Visible = false;
            }
        }

        private void star_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(LampuKuning.Visible == true)
            {
                mobil.Left = mobil.Left += 5;
            }
            if(LampuHijau.Visible == true)
            {
                mobil.Left = mobil.Left += 10;
            }
        }
    }
}
