using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    interface ISpeak
    {
        void Speak();
    }

    class Poodle : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("The poodle says \"arf\"");
        }
    }

    class Rottweiler : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("The Rottweiler says (in a very deep voice) \"WOOF!\"");
        }
    }

    class SiberianHusky : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("The husky says \"Dude, what's up?\"");
        }
    }


}
