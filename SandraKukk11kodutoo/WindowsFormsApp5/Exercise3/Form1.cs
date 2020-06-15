using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Form1 : Form
    {
        int counterSec, counterMin;
        bool isValidFormat;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        public bool CheckIfFormatIsValid()
        {
            isValidFormat = false;
            if (counterSec < 60 && counterMin < 60 && textBox1.Text.Substring(2, 1) == ":")
            {
                isValidFormat = true;
            }

            return isValidFormat;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = counterMin.ToString() + ":" + counterSec.ToString();

            if (counterSec < 10)
            {
                textBox1.Text = counterMin + ":" + "0" + counterSec;
            }
            if (counterMin < 10)
            {
                textBox1.Text = "0" + counterMin + ":" + counterSec;
            }
            if (counterMin < 10 && counterSec < 10)
            {
                textBox1.Text = "0" + counterMin + ":" + "0" + counterSec;
            }

            if (counterSec == 0 && counterMin == 0)
            {
                timer1.Stop();
                textBox1.ForeColor = Color.Red;
            }
            if (counterSec == 0)
            {
                counterMin--;
                counterSec = 59;
            }
            counterSec--;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            counterMin = int.Parse(textBox1.Text.Substring(0, 2));
            counterSec = int.Parse(textBox1.Text.Substring(3, 2));

            timer1.Interval = 1000;
            if (CheckIfFormatIsValid() == true)
            {
                timer1.Start();
            }

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            counterMin = 0;
            counterSec = 0;
            textBox1.Text = "0" + counterMin + ":" + "0" + counterSec;
        }
    }
}
