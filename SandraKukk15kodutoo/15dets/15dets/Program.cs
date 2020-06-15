using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15dets
{
    class Program
    {
        static void Main(string[] args)
        {
            PlanetarySystem sys1 = new PlanetarySystem();
            Spaceship laevJuku = new Spaceship("Juku", sys1);
            laevJuku.Travel(3);
            Spaceship laevKalle = new Spaceship("Kalle", sys1);
            laevKalle.Travel(3);
            laevKalle.Travel(4);
            laevKalle.Travel(3);
            laevKalle.Travel(2);

            AdvancedSpaceship laevPille = new AdvancedSpaceship("Pille", sys1);
            laevPille.Travel(5);
            Console.ReadLine();
        }
    }
}
