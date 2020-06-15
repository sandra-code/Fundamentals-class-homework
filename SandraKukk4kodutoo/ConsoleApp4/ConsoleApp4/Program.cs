using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            IDCode printIDcode = new IDCode();
            printIDcode.PrintIdCodeInfoFromFile();

            IDCode decodedIdCode = new IDCode("34501234215");
            decodedIdCode.Decode();
            decodedIdCode.SaveIDCodeToFile();


            /* IDCode createdIdCode = new IDCode();
             createdIdCode.CreateIDcode("Kuressaare",new DateTime(1955, 2, 14),"female", 3);
             */

             Console.ReadLine();
        }
    }
}
