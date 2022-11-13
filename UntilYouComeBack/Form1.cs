using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UntilYouComeBack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 100; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime christmas = new DateTime(2023, 12, 14, 18, 00, 00);
            TimeSpan diff = christmas.Subtract(DateTime.Now);
            string label1InitialText = "Until I see you: ";
            label1.Text = label1InitialText + $"{diff.Days} days, {diff.Hours} hours, " +
                          $"{diff.Minutes} minutes {diff.Seconds} seconds, {diff.Milliseconds} ms";
        }
    }
}
