using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15dets
{
    class Planet
    {
        public List<Spaceship> ListOfSpaceships=new List<Spaceship>();
        
        string name, differenceString;
        double weight, lengthOfDay, lengthOfYears_earthYears, lengthOfYears_solarYears, difference;
        public int nrOfPlatforms;

        public Planet(string planetName, double planetWeight, int _nrOfPlatforms)
        {
            name = planetName;
            weight = planetWeight;
            nrOfPlatforms = _nrOfPlatforms;
            GetSizeDifference();
        }

        public void SetDayLengths(double _lengthOfDay, double _lengthOfYears_earthYears, double _lengthOfYears_solarYears)
        {
            lengthOfDay = _lengthOfDay;
            if (_lengthOfYears_earthYears == 0)
            {
                lengthOfYears_earthYears = Math.Round((_lengthOfYears_solarYears*lengthOfDay / (365 * 24)), 2);
            }
            else
            {
                lengthOfYears_earthYears = _lengthOfYears_earthYears;
            }

            if (_lengthOfYears_solarYears==0)
            {
                lengthOfYears_solarYears = Math.Round(((365*24*lengthOfYears_earthYears)/lengthOfDay),2);
            }
            else
            {
                lengthOfYears_solarYears = _lengthOfYears_solarYears;
            }
        }

        public string GetSizeDifference()
        {
           
            double earthWeight = 5.97;

            if (weight < earthWeight)
            {
                difference = Math.Round((earthWeight / weight),0);
                differenceString = difference + " times smaller";
            }
            else
            {
                difference = Math.Round((weight / earthWeight),0);
                differenceString = difference + " times bigger";
            }
            
            return differenceString;
        }

        public void PrintPlanetInfo()
        {
            if (name == "Earth")
            {
                Console.WriteLine("Planet is {0}. Its day is {1} hours. Its year is {2} Earth years and {3} solar days.", name, lengthOfDay, lengthOfYears_earthYears, lengthOfYears_solarYears);

            }
            else
            {
                Console.WriteLine("Planet {0} is {1} than Earth. Its day is {2} hours. Its year is {3} Earth years and {4} solar days.", name, differenceString, lengthOfDay, lengthOfYears_earthYears, lengthOfYears_solarYears);

            }
           
        }
       
        public void PrintSpaceshipInfo()
        {
            Console.WriteLine("Number of platforms: {0}", nrOfPlatforms);
           
            for (int i = 1; i <= nrOfPlatforms; i++)
            {

                if (ListOfSpaceships.Count==0)
                {
                    Console.WriteLine("Landing platform {0}: empty", i);

                }
                else
                {
                    foreach (Spaceship ship in ListOfSpaceships)
                    {
                        Console.WriteLine("Landing platform {0}: {1}", i, ship.spaceshipName);
                    }
                   
                }

            }
            Console.WriteLine(" ");
        }
    }
}
