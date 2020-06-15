using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Factory
    {
        public static ISpeak getDog(string criteria)
        {
            if (criteria == "small")
            {
                return new Poodle();
            }
            else if (criteria == "big")
            {
                return new Rottweiler();
            }
            else if (criteria == "working")
            {
                return new SiberianHusky();
            }
            else
            {
                return null;
            }
        }
    }
}
