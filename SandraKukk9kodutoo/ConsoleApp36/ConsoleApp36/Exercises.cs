using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Exercises
    {
        public string JoinStrings(string a, string b)
        {
            return a + b;
        }

        public int[] GenerateArrayOfSix()
        {
            Random rnd = new Random();
            int randomNr0_20, randomNr30_60, randomNr100_200;
            int oddNumbers = 0;
            int evenNumbers=0;
            int nrDividesWith5 = 0;
            bool isConditionTrue;

            List<int> listOfNumbers = new List<int>();
            top:
            for (int i = 1; i <=2; i++)
            {
                
                randomNr0_20 = rnd.Next(0, 21);
                randomNr30_60 = rnd.Next(30, 61);
                randomNr100_200 = rnd.Next(100, 201);
                listOfNumbers.Add(randomNr0_20);
                listOfNumbers.Add(randomNr30_60);
                listOfNumbers.Add(randomNr100_200);


            }

            foreach (int nr in listOfNumbers)
            {
                if (nr % 2 == 0)
                {
                    evenNumbers++;
                }
                else
                {
                    if (nr % 5 == 0)
                    {
                        nrDividesWith5++;
                        oddNumbers++;
                    }
                    else
                    {
                        oddNumbers++;
                    }
                }
            }

            if(oddNumbers >= 2 && evenNumbers >= 2 && nrDividesWith5 >= 1)
            {
                isConditionTrue = true;
            }
            else
            {
                isConditionTrue = false;
            }

            while(isConditionTrue==false)
            {
                goto top;
            }

            int[] arrayOfSix = listOfNumbers.ToArray();
            return arrayOfSix;
        }

        public string CalculateBMI(double height, double weight)
        {
            double BMI = weight / ((height / 100) * (height / 100));
            Math.Round(BMI, 1);
            string value = "";

            if (BMI < 18.5)
            {
                value = "underweight";
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                value = "normal";
            }
            else if (BMI >= 25 && BMI < 30)
            {
                value = "overweight";
            }
            else if (BMI >= 30)
            {
                value = "obese";
            }

            return value;
        }

        public string ReplaceSpaces(string sentence)
        {
            
            sentence = System.Text.RegularExpressions.Regex.Replace(sentence, @"\s{1,}", "*");
            return sentence;
           
        }

    }
}
