using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class YouthBall : NormalBall
    {
        public YouthBall(string sponsorNameString) : base(sponsorNameString)
        {
            sponsorName = sponsorNameString;
            diameter = 56;
            weight = 380;
            goalDepth = 1.4;
        }

        public override void CreateCode()
        {
            string firstLetters = sponsorName.Substring(0, 3);
            Random rnd = new Random();
            string numberCode = "";
            int numbers;

            for (int i = 1; i <= 3; i++)
            {
                numbers = rnd.Next(0, 10);
                numberCode = numberCode + numbers;
            }

            string ballCode = firstLetters + numberCode;
            Console.WriteLine("Code for the ball is {0}", ballCode);

        }
    }
}
