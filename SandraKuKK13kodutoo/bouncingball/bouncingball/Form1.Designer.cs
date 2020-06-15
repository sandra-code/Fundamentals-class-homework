namespace bouncingball
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLives = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRecSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelScor = new System.Windows.Forms.Label();
            this.labelFinalScore = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 322);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonStart.Location = new System.Drawing.Point(508, 343);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Choose amount of lives:";
            // 
            // textBoxLives
            // 
            this.textBoxLives.Location = new System.Drawing.Point(491, 46);
            this.textBoxLives.Name = "textBoxLives";
            this.textBoxLives.Size = new System.Drawing.Size(100, 22);
            this.textBoxLives.TabIndex = 6;
            this.textBoxLives.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Choose the speed of the ball:";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(491, 116);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 22);
            this.textBoxSpeed.TabIndex = 8;
            this.textBoxSpeed.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Choose the size of the rectangle:";
            // 
            // textBoxRecSize
            // 
            this.textBoxRecSize.Location = new System.Drawing.Point(491, 180);
            this.textBoxRecSize.Name = "textBoxRecSize";
            this.textBoxRecSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxRecSize.TabIndex = 10;
            this.textBoxRecSize.Text = "40";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lives:";
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BackColor = System.Drawing.Color.Lavender;
            this.labelGameOver.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.ForeColor = System.Drawing.Color.Red;
            this.labelGameOver.Location = new System.Drawing.Point(106, 141);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(550, 93);
            this.labelGameOver.TabIndex = 12;
            this.labelGameOver.Text = "GAME OVER!";
            this.labelGameOver.Visible = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(222, 381);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(16, 17);
            this.labelScore.TabIndex = 13;
            this.labelScore.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Score:";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.BackColor = System.Drawing.Color.Lavender;
            this.labelMax.Location = new System.Drawing.Point(106, 245);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(76, 17);
            this.labelMax.TabIndex = 16;
            this.labelMax.Text = "Max score:";
            this.labelMax.Visible = false;
            // 
            // labelScor
            // 
            this.labelScor.AutoSize = true;
            this.labelScor.BackColor = System.Drawing.Color.Lavender;
            this.labelScor.Location = new System.Drawing.Point(106, 276);
            this.labelScor.Name = "labelScor";
            this.labelScor.Size = new System.Drawing.Size(109, 17);
            this.labelScor.TabIndex = 17;
            this.labelScor.Text = "Your score was:";
            this.labelScor.Visible = false;
            // 
            // labelFinalScore
            // 
            this.labelFinalScore.AutoSize = true;
            this.labelFinalScore.BackColor = System.Drawing.Color.Lavender;
            this.labelFinalScore.Location = new System.Drawing.Point(222, 276);
            this.labelFinalScore.Name = "labelFinalScore";
            this.labelFinalScore.Size = new System.Drawing.Size(16, 17);
            this.labelFinalScore.TabIndex = 18;
            this.labelFinalScore.Text = "0";
            this.labelFinalScore.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Lavender;
            this.label7.Location = new System.Drawing.Point(191, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "0";
            this.label7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(719, 429);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelFinalScore);
            this.Controls.Add(this.labelScor);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRecSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLives);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLives;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRecSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelScor;
        private System.Windows.Forms.Label labelFinalScore;
        private System.Windows.Forms.Label label7;
    }
}

