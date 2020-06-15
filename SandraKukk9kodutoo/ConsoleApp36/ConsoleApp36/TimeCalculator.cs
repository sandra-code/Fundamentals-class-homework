using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class TimeCalculator
    {
        DateTime date = new DateTime(2000, 1, 1);

        string hoursString;
        double minutes;


        public DateTime FindMinutesFromInput()
        {
            int indexOfComma = hoursString.IndexOf(".");
            double minutesDouble = Convert.ToDouble(hoursString.Substring(indexOfComma));
            minutes = 60 / minutesDouble;
            date.AddMinutes(minutes);
            return date;
        }

        public DateTime AddHours()
        {
            double hours = Convert.ToDouble(hoursString);
            if (hoursString.Contains("."))
            {
                FindMinutesFromInput();
                date.AddHours(hours);
            }
            else
            {
                date.AddHours(hours);
            }

            if (hours > 24)
            {
                date.AddDays(1);
            }
            return date;
        }

        public DateTime SubtractHours()
        {
            double hours = Convert.ToDouble(hoursString);
            if (hoursString.Contains("."))
            {
                FindMinutesFromInput();
                date.AddMinutes(-2 * minutes);
                date.AddHours(-hours);
            }
            else
            {
                date.AddHours(-hours);
            }

            date.AddDays(-1);

            return date;
        }
        

        public DateTime FindTime(double _hours)
        {
            hoursString = Convert.ToString(_hours);

            if (hoursString.StartsWith("-"))
            {
                SubtractHours();
            }
            else if (hoursString.StartsWith("+")) 
            {
                AddHours();
            }
            else
            {
                hoursString.Insert(0, "+");
                AddHours();
            }

            return date;
        }




        
       
    }
}
