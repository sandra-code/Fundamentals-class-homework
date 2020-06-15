using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15dets
{
    interface ISpaceship
    {
        void Travel(int planetsIndex);
    }
    class Spaceship : ISpaceship
    {

        public int travelLength;
        public string spaceshipName;
        public PlanetarySystem psystem;
        public int currentLocationIndex = 2;
        Planet destinationPlanet, currentPlanet;
        public Spaceship(string _spaceshipName, PlanetarySystem _psystem)
        {
            spaceshipName = _spaceshipName;
            psystem = _psystem;
            travelLength = 1;

        }

        public  void Travel(int planetsIndex)
        {
            
            if (planetsIndex > 8)
            {
                Console.WriteLine("There are 8 planets in planetary system. You cannot travel");
            }
            else
            {
                
                destinationPlanet = psystem.planets[planetsIndex];
                currentPlanet= psystem.planets[currentLocationIndex];
                
                if (Math.Abs(planetsIndex-currentLocationIndex)<=travelLength)
                {
                    
                    if (destinationPlanet.ListOfSpaceships.Count<destinationPlanet.nrOfPlatforms)
                    {
                        currentPlanet.ListOfSpaceships.Remove(this);
                        destinationPlanet.ListOfSpaceships.Add(this);
                        currentLocationIndex = planetsIndex;
                    }
                    else
                    {
                        Console.WriteLine("Platforms are full. You cannot travel");
                    }
                   
                }
                else
                {
                    Console.WriteLine("Your destination planet is too far from you current location.");
                }
            }
            
        }

    }

    class AdvancedSpaceship : Spaceship
    {
        
        public AdvancedSpaceship(string _spaceshipName, PlanetarySystem _psystem) : base(_spaceshipName, _psystem)
        {
            spaceshipName = _spaceshipName;
            psystem = _psystem;
            travelLength = 2;
        }
        
        
    }
}
