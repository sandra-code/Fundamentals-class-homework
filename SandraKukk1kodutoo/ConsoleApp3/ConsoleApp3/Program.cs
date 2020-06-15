using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esimene ülesanne

            string a, b;
            double firstnum, secondnum, sum, sub, mul, div, sqrt, vastus;

            Console.WriteLine("Sisesta esimene arv: ");
            a = Console.ReadLine();

            firstnum = Double.Parse(a);

            Console.WriteLine("Sisesta teine arv: ");
            b = Console.ReadLine();

            secondnum = Double.Parse(b);

            sum = firstnum + secondnum;

            Console.WriteLine("Summa on " + sum);



            sub = firstnum - secondnum;

            Console.WriteLine("Vahe on " + sub);

            mul = firstnum * secondnum;
            Console.WriteLine("Korrutis on " + mul);

            div = firstnum / secondnum;
            Console.WriteLine("Jagatis on " + div);

            vastus = Math.Sqrt(sum);

            if (vastus > 0)
            {
                Console.WriteLine("Ruutjuur nende arvude summast on " + vastus);
            }
            else if (vastus == 0)
            {
                Console.WriteLine("Summa on 0. Ruutjuurt nullist võtta ei saa!");
            }

            else
            {
                Console.WriteLine("Summa tuleb negatiivne. Ruutjuurt negatiivsest arvust võtta ei saa!");
            }





            Console.ReadLine();

            /*

             //Teine ülesanne

             int correctAnswers = 0;

             int userAnswer1;
             int correctAnswer1 = 7;

             Console.WriteLine("Mitu päeva on nädalas?");
             string userAnswerString = Console.ReadLine();
             userAnswer1 = Int32.Parse(userAnswerString);

             if (correctAnswer1 == userAnswer1)
             {
                 correctAnswers = correctAnswers + 1;
                 Console.WriteLine("Sinu skoor on " + correctAnswers);
             }
             else
             {
                 Console.WriteLine("Vale vastus!");
             }



             string userAnswer2;
             string correctAnswer2 = "kaljulaid";
             Console.WriteLine("Mis on hetkel ametisoleva presidendi perekonnanimi?");
             userAnswer2 = Console.ReadLine();
             if (correctAnswer2 == userAnswer2)
             {
                 correctAnswers = correctAnswers + 1;
                 Console.WriteLine("Sinu skoor on " + correctAnswers);

             }
             else
             {
                 Console.WriteLine("Vale vastus ");

             }

             double userAnswer3;
             double correctAnswer3 = 30.3;

             Console.WriteLine("Kui suur on rahvastikutihedus Eestis(2015. a. seisuga)? 30.5 ; 28.0 ; 30.3");
             string userAnswerString1 = Console.ReadLine();
             userAnswer3 = Double.Parse(userAnswerString1);

             if (correctAnswer3 == userAnswer3)
             {
                 correctAnswers = correctAnswers + 1;
                 Console.WriteLine("Sinu skoor on " + correctAnswers);
             }

             else
             {
                 Console.WriteLine("Vale vastus!");

             }

             if (correctAnswers == 3)
             {
                 Console.WriteLine("Tubli! Kõik sinu vastused olid õiged!");
             }
             else
             {
                 Console.WriteLine("Sinu skoor oli väiksem kui 3. Proovi uuesti!");
             }
             Console.ReadLine();
             */
        }
    }
}
