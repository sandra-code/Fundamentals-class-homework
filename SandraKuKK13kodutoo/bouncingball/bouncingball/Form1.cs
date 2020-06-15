using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace bouncingball
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int ballX, ballY, recY;
        int ballWidth = 20;
        int ballHeight = 20;

        int recX = 0;
        int recHeight = 0;

        int speedX = 0;
        int speedY = 0;

        int lives = 0;
        bool isGameOver;
        int score = 0;
        int counter = 0;
        Rectangle controlRectangle;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Black);
            Brush myBrush = new SolidBrush(Color.Black);
            Rectangle ballRectangle = new Rectangle(ballX, ballY, ballWidth, ballHeight);
            Graphics g = e.Graphics;
            g.DrawEllipse(myPen, ballRectangle);
            g.FillEllipse(myBrush, ballRectangle);

            controlRectangle = new Rectangle(0, recY, 10, recHeight);
            g.FillRectangle(myBrush, controlRectangle);


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (recY>=4)
                {
                   recY -= 4;

                }

            }
            else if (e.KeyCode == Keys.Down)
            {
                if (recY+recHeight <= pictureBox1.Height-4)
                {
                    recY += 4;

                }
            }
            

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            bool isOK=true;
            lives = int.Parse(textBoxLives.Text);
            speedX = int.Parse(textBoxSpeed.Text);
            speedY= int.Parse(textBoxSpeed.Text);
            recHeight = int.Parse(textBoxRecSize.Text);

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (lives <= 0 || speedX<=0 || recHeight<=0)
            {
                string message = "Amount of numbers/speed/height cannot be 0 or negative!";
                string caption = "Please enter correct number";
                DialogResult result = MessageBox.Show(message, caption, buttons);
                isOK = false;
            }
            if(speedX==0 || speedX > 5)
            {
                string message = "Speed must be between 1 and 5";
                string caption = "Please enter number between 1 and 5";
                DialogResult result = MessageBox.Show(message, caption, buttons);
                isOK = false;
            }
            if (recHeight>0 && recHeight <= 20)
            {
                string message = "Height is too small";
                string caption = "Please enter a bigger number";
                DialogResult result = MessageBox.Show(message, caption, buttons);
                isOK = false;
            }
            else if (recHeight>=pictureBox1.Height)
            {
                string message = "Number is too high";
                string caption = "Please enter a smaller number";
                DialogResult result = MessageBox.Show(message, caption, buttons);
                isOK = false;
            }
           
            textBoxRecSize.Enabled = false;
            textBoxSpeed.Enabled = false;
            textBoxLives.Enabled = false;
            buttonStart.Enabled = false;


            if (isOK == true)
            {
                timer1.Start();

            }

            counter++;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            timer1.Interval = 100;
            ballX += speedX;
            if (ballX <=0)
            {
                speedX = -speedX;
                lives--;
            }
            else if(ballX+ballWidth>pictureBox1.Width)
            {
                speedX= -speedX;
            }

            ballY += speedY;
            if (ballY < 0)
            {
                speedY = -speedY;
            }
            else if (ballY + ballHeight> pictureBox1.Height)
            {
                speedY = -speedY;
            }


            if (controlRectangle.IntersectsWith(new Rectangle(ballX, ballY, ballWidth, ballHeight)))
            {
                speedX = -speedX;
                
            }

            if (recHeight<=50)
            {
                score += 50;
            }
            else if(recHeight<=70)
            {
                score += 10;
            }
            else
            {
                score += 5;
            }

            labelScore.Text = score.ToString();

            if (lives == 0)
            {
                isGameOver = true;
            }
            label2.Text = lives.ToString();

            if (isGameOver == true)
            {
                timer1.Stop();
                labelGameOver.Visible = true;
                labelMax.Visible = true;
                labelScor.Visible = true;
                labelFinalScore.Visible = true;
                label7.Visible = true;
                labelFinalScore.Text = labelScore.Text;

                int line;

                using (StreamReader reader = new StreamReader("scores.txt"))
                {
                    line = int.Parse(reader.ReadLine());
                }

                using (StreamWriter writer = new StreamWriter("scores.txt", false))
                {
                    if (line < int.Parse(labelFinalScore.Text))
                    {
                        writer.Write(labelFinalScore.Text);
                        label7.Text = labelFinalScore.Text;

                    }
                    else
                    {
                        label7.Text = line.ToString();

                    }
                }
            }

            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ballX = rnd.Next(0,pictureBox1.Width-ballWidth);
            ballY = rnd.Next(0,pictureBox1.Height-ballHeight);

            recY = pictureBox1.Height / 2 - recHeight / 2;

        }
    }
}
