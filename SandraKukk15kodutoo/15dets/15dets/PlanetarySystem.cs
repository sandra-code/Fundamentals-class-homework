using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15dets
{
    class PlanetarySystem
    {
        public Planet[] planets;

        public PlanetarySystem()
        {
            planets = new Planet[8];

            Planet planetMercury = new Planet("Mercury", 0.330, 1);
            planetMercury.SetDayLengths(4222.6, 0, 0.498);
            planets[0] = planetMercury;

            Planet planetVenus = new Planet("Venus", 4.87, 2);
            planetVenus.SetDayLengths(2802, 0.62, 0);
            planets[1] = planetVenus;

            Planet planetEarth = new Planet("Earth", 5.97, 6);
            planetEarth.SetDayLengths(24, 1, 365);
            planets[2] = planetEarth;

            Planet planetMars = new Planet("Mars", 0.642, 2);
            planetMars.SetDayLengths(24.7, 1.88, 0);
            planets[3] = planetMars;

            Planet planetJupiter = new Planet("Jupiter", 1898, 2);
            planetJupiter.SetDayLengths(9.9, 11.86, 0);
            planets[4] = planetJupiter;

            Planet planetSaturn = new Planet("Saturn", 586, 1);
            planetSaturn.SetDayLengths(10.7, 0, 24491);
            planets[5] = planetSaturn;

            Planet planetUranus= new Planet("Uranus", 86.8, 0);
            planetUranus.SetDayLengths(17.2, 0, 42786.49);
            planets[6] = planetUranus;

            Planet planetNeptune = new Planet("Neptune", 102, 1);
            planetNeptune.SetDayLengths(16.1, 164.8, 0);
            planets[7] = planetNeptune;

            foreach (Planet pl in planets)
            {
                pl.PrintPlanetInfo();
                pl.PrintSpaceshipInfo();
            }

            

        }

    }
}
