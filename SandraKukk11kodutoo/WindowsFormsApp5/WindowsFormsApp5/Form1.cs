using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        string username = "sandra";
        string password = "minupass123";
        bool isUsernameCorrect, isPasswordCorrect;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            isPasswordCorrect = false;

            if (textBoxPassword.Text == password)
            {
                isPasswordCorrect = true;
            }

            textBoxPassword.PasswordChar = '*';
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            isUsernameCorrect = false;

            if (textBoxUsername.Text == username)
            {
                isUsernameCorrect = true;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (isUsernameCorrect == true && isPasswordCorrect == true)
            {
                labelCorrect.Show();
            }
            else
            {
                labelWrong.Show();
            }
        }
    }
}
