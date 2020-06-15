using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Top = 50;
            label1.Left = 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 100;

            if (label1.Left <280 && label1.Top==50)
            {
                label1.Left += 10;
            }
            else if(label1.Left==280 && label1.Top<150)
            {
                label1.Top += 10;
            }
            else if(label1.Top==150 && label1.Left>50)
            {
                label1.Left-=10;
            }
            else if (label1.Left == 50 && label1.Top>=50)
            {
                label1.Top -= 10;
            }


        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
