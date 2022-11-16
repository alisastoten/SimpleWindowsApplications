using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountdownTimer
{
    public partial class Form1 : Form
    {
        private int minutes, seconds;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_countdown.Text = "00:00";
            label_info.Hide();
            timer_countdown.Stop();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer_countdown.Stop();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            //int indexOfTwoDots = textBox_countdown.Text.IndexOf(':');
            //string s = textBox_countdown.Text.Substring(indexOfTwoDots + 1);
            //string m = textBox_countdown.Text.Substring(0, indexOfTwoDots);

            string[] numberList = textBox_countdown.Text.Split(':');

            if (IsCorrectInput(numberList[0]) && IsCorrectInput(numberList[1]))
            {
                label_info.Hide(); // if it was incorrect previously
                // int parse is okay
                // because they have been tryparsed already
                minutes = int.Parse(numberList[0]);
                seconds = int.Parse(numberList[1]);
                timer_countdown.Start();
            }
            else
            {
                label_info.Show();
                label_info.Text = "Incorrect input.";
            }

        }

        private void timer_countdown_Tick(object sender, EventArgs e)
        {
            if (seconds >= 0)
            {
                seconds--;
                // -1 for seconds - otherwise it will skip 1:00, 2:00
                if (minutes > 0 && seconds == -1)
                {
                    minutes--;
                    seconds += 60;
                }

                // if minutes are 0
                // then the last second needs to be added back
                // otherwise end will look like 00:-1
                if (seconds == -1 && minutes == 0)
                {
                    seconds++;
                }
            }
            
            
            //string m = minutes.ToString().PadLeft(2, '0'); // same thing
            string m = DisplayAs2PartNum(minutes);
            string s = DisplayAs2PartNum(seconds);
            textBox_countdown.Text = m + ":" + s;
        }

        //
        private string DisplayAs2PartNum(int num)
        {
            string numAsString = num.ToString();
            if (numAsString.Length == 2)
            {
                return numAsString;
            }
            // otherwise it could only be
            // 1, 2, 3 or any other num < 10
            // needs to be 01, 02, 03, 04, 05
            return "0" + numAsString;
        }

        private bool IsCorrectInput(string num)
        {
            // both sides of ":" have to have two chars
            if (num.Length == 2)
            {
                // check if input is numeric
                if (int.TryParse(num, out int result))
                {
                    // check if input is <= 59 for m and s (in case it is numeric)
                    if (result <= 59)
                        return true;
                }
            }

            return false;
        }
    }
}
