using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    interface IBall
    {
        void CalculateAverageSpeed(int startCoordinate, int finalCoordinate, int time);
        void CalculateKineticEnergy(int velocity);
        void CheckIfGoalCounted(double ballCoordinates);
        void PrintGoals();
        void CreateCode();
    }
}
