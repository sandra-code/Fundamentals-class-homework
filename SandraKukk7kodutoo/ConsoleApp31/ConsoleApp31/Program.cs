using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalBall normalball1 = new NormalBall("olerex");
            normalball1.CheckIfGoalCounted(10);
            normalball1.CheckIfGoalCounted(20);
            normalball1.CheckIfGoalCounted(30);
            normalball1.CheckIfGoalCounted(0);
            normalball1.CheckIfGoalCounted(45);
            normalball1.CheckIfGoalCounted(-50);
            normalball1.CheckIfGoalCounted(-20);
            normalball1.CheckIfGoalCounted(-43.9);
            normalball1.CheckIfGoalCounted(44.5);
            normalball1.CheckIfGoalCounted(100);
            normalball1.CheckIfGoalCounted(2);
            normalball1.CheckIfGoalCounted(-25);
            normalball1.CheckIfGoalCounted(-44.7);
            normalball1.CheckIfGoalCounted(-42);
            normalball1.CheckIfGoalCounted(30);
            normalball1.CheckIfGoalCounted(1000);
            normalball1.CheckIfGoalCounted(6);
            normalball1.CheckIfGoalCounted(17);
            normalball1.CheckIfGoalCounted(-10);
            normalball1.CheckIfGoalCounted(43);
            normalball1.PrintGoals();
            Console.WriteLine("");
            normalball1.CalculateAverageSpeed(30, 70, 20);
            normalball1.CalculateAverageSpeed(10, 60, 10);
            normalball1.CalculateAverageSpeed(-30, 70, 20);
            normalball1.CalculateAverageSpeed(10, -10, 40);
            normalball1.CalculateAverageSpeed(50, 20, 25);
            normalball1.CalculateAverageSpeed(32, 10, 55);
            normalball1.CalculateAverageSpeed(-10, -70, 20);
            normalball1.CalculateAverageSpeed(23, -17, 0);
            normalball1.CalculateAverageSpeed(0, 70, 30);
            normalball1.CalculateAverageSpeed(35, 75, -20);
            Console.WriteLine("");
            normalball1.CalculateKineticEnergy(1);
            normalball1.CalculateKineticEnergy(2);
            normalball1.CalculateKineticEnergy(3);
            normalball1.CalculateKineticEnergy(4);
            normalball1.CalculateKineticEnergy(5);
            Console.WriteLine("");
            normalball1.CreateCode();

            YouthBall youthball1 = new YouthBall("olerex");
            youthball1.CreateCode();
           

            Console.ReadLine();
        }
    }
}
