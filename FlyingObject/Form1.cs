using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyingObject
{
    public partial class Form1 : Form
    {
        private int leftStep = 70;
        private int downStep = 50;
        public Form1()
        {
            InitializeComponent();
            //timer interval should be 0.4s 
            timer1.Interval = 200; // 0.4 * 1000
            label_flying.Left = leftStep;
            label_flying.Top = downStep;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            label_flying.Text = "I'm flying!";
            timer1.Start();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            label_flying.Text = "I stopped :(";
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // all clockwise moving logic should be here

            // how far from the left + extra length from the label itself
            int distanceFromLeft = label_flying.Left + label_flying.Width;
            int distanceFromTop = label_flying.Top + label_flying.Height;

            if (Width - distanceFromLeft > 150 && label_flying.Top < 100)
            {
                label_flying.Left += leftStep;
            }
            else if (Height - distanceFromTop > 100 && Width - distanceFromLeft <= 150)
            {
                label_flying.Top += downStep;
            }
            else if (label_flying.Left > 100)
            {
                label_flying.Left -= leftStep;
            }
            else
            {
                label_flying.Top -= downStep;
            }


        }
    }
}
