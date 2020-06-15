using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14dets
{
    class SortingEx
    {
        static void Main(string[] args)
        {
            Sort();
            Console.ReadLine();
        }

        static void Sort()
        {
            //teend 10 random numbrit
            Random rnd = new Random();
            int total = 10;

            int[] arrayOfInts = new int[total];

            for (int i = 0; i < total; i++)
            {
                arrayOfInts[i] = rnd.Next(-1000, 1000);

            }
            //prindin esialgse array
            Console.WriteLine("Numbers before sorting");
            foreach (int item in arrayOfInts)
            {
                Console.Write(item + " ");
            }

            //cycle käib kuni array lõpuni
            for (int i = 0; i < arrayOfInts.Length - 1; i++)
            {
                //j on i kõrval asuv number
                for (int j = i + 1; j > 0; j--)
                {
                    if (arrayOfInts[j - 1] > arrayOfInts[j])
                    {
                        int a = arrayOfInts[j - 1];
                        //asendan
                        arrayOfInts[j - 1] = arrayOfInts[j];
                        arrayOfInts[j] = a;
                    }
                }
            }

            
            Console.WriteLine("\nNumbers after sorting");

            foreach (int item in arrayOfInts)
            {
                Console.Write(item + " ");
            }


        }
    }
}
