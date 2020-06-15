using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class IDCode
    {
        string birthPlace, birthDay, sex, checknumber, randomIDcode, destinationFileLocation, line;
        int day, month, year;

        public IDCode()
        {

        }

        public IDCode(string idCode)
        {
            randomIDcode = idCode;
        }

        public string Decode()
        {
            //gender
            string stringSex = randomIDcode.Substring(0, 1);
            int intSex = int.Parse(stringSex);

            if (intSex % 2 == 0 && intSex <= 6)
            {
                sex = "female";
            }
            else if (intSex <= 6)
            {
                sex = "male";
            }
            else
            {
                sex = "unknown";
            }


            //birthday

            string yearString = randomIDcode.Substring(1, 2);
            year = int.Parse(yearString);

            string monthString = randomIDcode.Substring(3, 2);
            month = int.Parse(monthString);

            string dayString = randomIDcode.Substring(5, 2);
            day = int.Parse(dayString);

            if (month <= 12 && day <= 31)
            {
                birthDay = day + "/" + month + "/" + year;
            }
            else
            {
                birthDay = "unknown";
            }
            //birthplace

            string stringArea = randomIDcode.Substring(7, 3);
            int areaCode = int.Parse(stringArea);


            switch (areaCode)
            {
                case int n when (n >= 1 && n <= 10):
                    birthPlace = "Kuressaare Haigla";
                    break;
                case int n when (n > 10 && n <= 19):
                    birthPlace = "Tartu Ülikooli Naistekliinik";
                    break;
                case int n when (n > 20 && n <= 220):
                    birthPlace = "Ida-Tallinna Keskhaigla, Pelgulinna sünnitusmaja,Hiiumaa, Keila, Rapla haigla, Loksa haigla";
                    break;
                case int n when (n > 220 && n <= 270):
                    birthPlace = "Ida-Viru Keskhaigla";
                    break;
                case int n when (n > 270 && n <= 370):
                    birthPlace = "Maarjamõisa Kliinikum, Jõgeva Haigla";
                    break;
                case int n when (n > 370 && n <= 420):
                    birthPlace = "Narva Haigla";
                    break;
                case int n when (n > 420 && n <= 470):
                    birthPlace = "Pärnu Haigla";
                    break;
                case int n when (n > 470 && n <= 490):
                    birthPlace = "Pelgulinna Sünnitusmaja, Haapsalu haigla";
                    break;
                case int n when (n > 490 && n <= 520):
                    birthPlace = "Järvamaa Haigla";
                    break;
                case int n when (n > 520 && n <= 570):
                    birthPlace = "Rakvere, Tapa haigla";
                    break;
                case int n when (n > 570 && n <= 600):
                    birthPlace = "Valga Haigla";
                    break;
                case int n when (n > 600 && n <= 650):
                    birthPlace = "Viljandi Haigla";
                    break;
                case int n when (n > 650 && n <= 710):
                    birthPlace = "Lõuna-Eesti Haigla, Põlva Haigla";
                    break;

                default:
                    birthPlace = "unknown";
                    break;
            }

            //checknumber
            string checknumber = randomIDcode.Substring(10, 1);

            return string.Format("Person's gender is {0}, birthday is {1}, birthplace is {2}, checknumber is {3}", sex, birthDay, birthPlace, checknumber);
        }

        public void CreateIDcode(string birthPlace, DateTime birthDay, string sex, int checknumber)
        {
            /*
            //birthday
            string birthDayString = birthDay.ToShortDateString();
            string yearString = birthDayString.Substring(8, 2);
            string monthString = birthDayString.Substring(3, 2);
            string dayString = birthDayString.Substring(0, 2);

            //gender

            string decadeString = birthDayString.Substring(6, 2);
            int decade = int.Parse(decadeString);
        

            if(decade==18 && sex == "female")
            {
                sex = "2";
            }
            else if(decade==18 && sex == "male")
            {
                sex = "1";
            }
            else if (decade == 19 && sex == "female")
            {
                sex = "4";
            }
            else if (decade == 19 && sex == "male")
            {
                sex = "3";
            }
            else if (decade == 20 && sex == "female")
            {
                sex = "6";
            }
            else if (decade == 20 && sex == "male")
            {
                sex = "5";
            }
            else
            {
                sex = "unknown";
            }

            birthDayString = yearString + monthString + dayString;

            //birhplace
            Random random = new Random();
            int birthPlaceInt;

            if (birthPlace == "Kuressaare")
            {
                birthPlaceInt = random.Next(1, 10);
                if (birthPlaceInt < 10)
                {
                    string birthPlaceString = birthPlaceInt.ToString();
                    birthPlace = "0" + birthPlaceString;
                }
                else
                {
                    birthPlace = birthPlaceInt.ToString();
                }
            
            }

            //valikud
            string v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13;
            v1 ="Tartu Ülikooli Naistekliinik";
            v2 =;
            v3 =;
            v4 =;
            v5 =;
            

            if (v1.Contains(birthPlace)
            {
                birthPlaceInt = random.Next(11, 20);
                birthPlace = birthPlaceInt.ToString();
            }


            */

            //Ei oska koostada, jäi pooleli

        }

        public void PrintIdCodeInfoFromFile()
        {
            string IDcodeFileLocation = @"C:\Users\sandr\source\repos\ConsoleApp4\ConsoleApp4\bin\Debug\printedIDcodes.txt";
            using (StreamReader reader = new StreamReader(IDcodeFileLocation))
            {
                
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

            }

        }

        public void SaveIDCodeToFile()
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\sandr\source\repos\ConsoleApp4\ConsoleApp4\bin\Debug\SavedIDcodes.txt", true))
            {

                writer.WriteLine("ID code is " + randomIDcode);
                writer.WriteLine(Decode());
            }
        }
    }
}
