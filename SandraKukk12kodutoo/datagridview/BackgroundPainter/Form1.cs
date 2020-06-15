using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundPainter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics graphics;
        Point endPosition;
        Point startPosition = new Point(0, 0);
        Random random = new Random();
       

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            DrawLine();
        }

        public void DrawLine()
        {
            graphics = CreateGraphics();
            Pen myPen = new Pen(Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255)), 4);

            if (startPosition.Y < ClientSize.Height)
            {
                startPosition.Y += 10;
                graphics.DrawLine(myPen, startPosition, endPosition);
                endPosition = startPosition;

            }
            else if (startPosition.Y >= ClientSize.Height)
            {
                startPosition.X += 4;
                graphics.DrawLine(myPen, startPosition, endPosition);
                endPosition = startPosition;

                while(startPosition.Y>0)
                {
                    startPosition.Y -= 10;
                    graphics.DrawLine(myPen, startPosition, endPosition);
                    endPosition = startPosition;
                }
            }

        }
    }
}
