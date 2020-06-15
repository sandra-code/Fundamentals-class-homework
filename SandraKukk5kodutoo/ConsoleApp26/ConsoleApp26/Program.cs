using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate(2200, 3, 2.1);
            FixCodes();
            GetMedianAndMean(5);
            GetMedianAndMean(4);
            PrintAsText(801);
            TVremote remote = new TVremote();
            remote.TurnOn();
            remote.IncreaseVolume();
            remote.IncreaseVolume();
            remote.DecreaseVolume();
            remote.ChangeChannelForward();
            remote.ChangeChannelBack();
            remote.ChangeChannel(34);
            remote.ChangeChannel(12);


            Console.ReadLine();
        }

        static void Calculate(double money, int years, double interest)
        {
            double yearSum;
            for (int i = 1; i <= years; i++)
            {

                yearSum = money + money * (interest / 100);
                money = yearSum;

                Console.WriteLine(yearSum);
            }
        }

        static void GetMedianAndMean(int sizeOfList)
        {
            List<int> listOfInts = new List<int>();
            Random rnd = new Random();
            double a_mean, sumMid;
            double sum = 0;
            int randomnr;
            int count = listOfInts.Count;

            for (int i = 0; i < sizeOfList; i++)
            {
                randomnr = rnd.Next(0, 10);
                listOfInts.Add(randomnr);
                sum += randomnr;
            }

            //Generated integers
            /*
            foreach (var item in listOfInts)
            {
                Console.WriteLine(item);
            }
            */
            a_mean = sum / sizeOfList;

            if (sizeOfList % 2 == 0)
            {
                double mid1 = listOfInts[count - (count / 2 - 1)];
                double mid2 = listOfInts[count - (count / 2 - 2)];

                sumMid = (mid1 + mid2) / 2;
            }
            else
            {
                sumMid = listOfInts[listOfInts.Count / 2];
            }

            Console.WriteLine("Arithmetic mean is {0}. Median is {1}", a_mean, sumMid);

        }

        static void PrintAsText(int enteredcode)
        {
            string code;
            if (enteredcode > 999)
            {
                Console.WriteLine("Amount has to be under 10 euros");
            }
            else
            {
                code = enteredcode.ToString();

                //cents
                if (code.Length == 1)
                {
                    Console.WriteLine("{0} cent", code);
                }
                else if (code.Length == 2)
                {
                    Console.WriteLine("{0} cents", code);
                }
                //euros
                else
                {
                    string first = code.Substring(0, 1);
                    string second_third = code.Substring(1, 2);
                    string one = code.Substring(2, 1);

                    if (second_third == "00" && first == "1")
                    {
                        Console.WriteLine("{0} euro", first);
                    }
                    else if (second_third == "01" && first == "1")
                    {
                        Console.WriteLine("{0} euro and {1} cent", first, one);
                    }
                    else if (second_third == "00")
                    {
                        Console.WriteLine("{0} euros", first);
                    }

                    //euros and cents
                    else
                    {
                        if (second_third == "01")
                        {
                            Console.WriteLine("{0} euros and {1} cent", first, one);
                        }
                        else
                        {
                            Console.WriteLine("{0} euros and {1} cents", first, second_third);
                        }
                    }
                }
            }
        }

        static void FixCodes()
        {
            string beginningsFile, endingsFile, newcodesFile, line1, line2;
            beginningsFile = @"C:\Users\sandr\source\repos\ConsoleApp26\ConsoleApp26\bin\Debug\beginnings.txt";
            endingsFile = @"C:\Users\sandr\source\repos\ConsoleApp26\ConsoleApp26\bin\Debug\endings.txt";
            newcodesFile = @"C:\Users\sandr\source\repos\ConsoleApp26\ConsoleApp26\bin\Debug\newcodes.txt";

            List<string> listOfBeginnings = new List<string>();
            List<string> listOfEndings = new List<string>();


            using (StreamReader reader = new StreamReader(beginningsFile))
            {
                while ((line1 = reader.ReadLine()) != null)
                {
                    listOfBeginnings.Add(line1);
                }

                using (StreamReader reader2 = new StreamReader(endingsFile))
                {
                   while ((line2 = reader2.ReadLine()) != null)
                   {
                      listOfEndings.Add(line2);
                   }
                }
                using (StreamWriter writer = new StreamWriter(newcodesFile, false))
                {
                    foreach (string beginning in listOfBeginnings)
                    {
                        int amountOfCharToAdd;
                        amountOfCharToAdd = 11 - beginning.Length;

                        foreach (string ending in listOfEndings)
                        {
                                while (amountOfCharToAdd == ending.Length)
                                {
                                    writer.WriteLine(beginning + ending);
                                    break;
                                }
                        }
                    }
                }
            }
        }
    }
}
