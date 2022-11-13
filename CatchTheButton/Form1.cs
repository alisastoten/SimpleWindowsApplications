using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchTheButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 500; // 0.5 seconds
            timer1.Start();
        }

        private bool IsButtonClicked = false;

        private void button_catchMe_Click(object sender, EventArgs e)
        {
            IsButtonClicked = true;
            button_catchMe.Text = "Got it!";
            timer1.Stop();
            Text = "Done"; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (!IsButtonClicked)
            {
                button_catchMe.Top = rnd.Next(0, Height - button_catchMe.Height);
                button_catchMe.Left = rnd.Next(0, Width - button_catchMe.Width);
            }
        }
    }
}
