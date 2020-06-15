using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class NormalBall : IBall
    {
        internal string sponsorName;
        internal double averageSpeed;
        internal int weight;
        internal double kineticEnergy;
        internal double diameter;
        internal double goalDepth;
        internal int succesfulGoals = 0;
        internal int unsuccesfulGoals = 0;

        public NormalBall(string sponsorNameString)
        {
            sponsorName = sponsorNameString;
            diameter = 70;
            weight = 450;
            goalDepth = 1.7;
        }

        public void CalculateAverageSpeed(int startCoordinate, int finalCoordinate, int time)
        {
            if (time <= 0)
            {
                Console.WriteLine("Time cannot be negative or 0");
            }
            else
            {
                averageSpeed = ((finalCoordinate - (double)startCoordinate) / time);
                Console.WriteLine("Average speed is {0}", Math.Abs(averageSpeed));
            }
        }
        public void CalculateKineticEnergy(int velocity)
        {
            if (velocity > 0)
            {
                kineticEnergy = (((double)weight * velocity * velocity) / 2);
                Console.WriteLine("Kinetic energy is {0}", kineticEnergy);
            }
            else
            {
                Console.WriteLine("Velocity cannot be negative");
            }
        }

        public void CheckIfGoalCounted(double ballCoordinate)
        {
            double leftGoalCoordinate, rightGoalCoordinate, diameterInCM, ballRadius;
            leftGoalCoordinate = -45 + goalDepth;
            rightGoalCoordinate = 45 - goalDepth;
            diameterInCM = diameter / 100;
            ballRadius = (double)diameterInCM / 2;

            try
            {
                if (ballCoordinate >= -45 && ballCoordinate <= 45)
                {
                    if (ballCoordinate - ballRadius <= leftGoalCoordinate || ballCoordinate - ballRadius >= rightGoalCoordinate)
                    {
                        Console.WriteLine("Goal scored");
                        succesfulGoals++;
                    }
                    else
                    {
                        Console.WriteLine("Goal not scored");
                        unsuccesfulGoals++;
                    }
                }
                else
                {
                    unsuccesfulGoals++;
                    throw new CoordinateValidityExecption("Coordinate is not valid");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
        public void PrintGoals()
        {
            Console.WriteLine("Scored: {0}. Missed: {1}", succesfulGoals, unsuccesfulGoals);
        }
        public virtual void CreateCode()
        {
            string firstLetters = sponsorName.Substring(0, 4);
            Random rnd = new Random();
            string numberCode = "";
            int numbers;

            for (int i = 1; i <= 5; i++)
            {
                numbers = rnd.Next(0, 10);
                numberCode = numberCode + numbers;
            }

            string ballCode = firstLetters + numberCode;
            Console.WriteLine("Code for the ball is {0}", ballCode);

        }
    }

}
