using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //textBox_password.PasswordChar = '*'; // a lot easier tbh
        }

        private string password = "CatsAreGreat";
        private string login = "HavingFun";
        private string enteredPassword = "";

        private void button_submit_Click(object sender, EventArgs e)
        {
            if (Equals(login, textBox_username.Text) && Equals(password, enteredPassword))
            {
                label_wrongOrCorrect.Text = "Correct";
                label_wrongOrCorrect.ForeColor = Color.DarkGreen;
                label_wrongOrCorrect.Show();
            }
            else
            {
                label_wrongOrCorrect.Text = "Wrong password!";
                label_wrongOrCorrect.Show();
            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            if (textBox_password.Text.Length > 0)
            {
                int len = textBox_password.Text.Length;
                char c = textBox_password.Text[len - 1];
                if (!Equals(c,'*'))
                    enteredPassword += c;

                // technically this is bad
                // because textbox text is changed here and the method is called again 
                // which means that a '*' symbol is added to the end but i dont want
                // it in enteredPassword
                // but above is an if statement that ignores it
                // there probably is a better way to do this
                // but this is the only one i could think of
                textBox_password.Text = textBox_password.Text.Replace(c, '*');

                // to get to the end of the text before next letter is entered
                textBox_password.SelectionStart = textBox_password.Text.Length;
                textBox_password.SelectionLength = 0; 
            }
        }
    }
}
