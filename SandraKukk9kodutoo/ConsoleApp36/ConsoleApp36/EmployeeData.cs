using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class EmployeeData
    {
        List<string> ListOfEmails = new List<string>();
        List<string> ListOfNames = new List<string>();
        List<string> ListOfSeparatedNames = new List<string>();
        List<string> ListOfFinalNames = new List<string>();
        string firstName, lastName, fullName;



        public EmployeeData()
        {
            ListOfEmails.Add("andre.griffin@ou.eu");
            ListOfEmails.Add("jhon.snow@gt.eu");
            ListOfEmails.Add("tim-allen.toomingas@eu.eu");
            ListOfEmails.Add("hei-hoo.chee_choo@china.eu");
            ListOfEmails.Add("a.chin_chan@c.e");
        }

        public List<string> GetRidOffEmailEnding()
        {
            string theEntireNameWithSigns;
            int indexOfAtSign;

            foreach (string email in ListOfEmails)
            {
                indexOfAtSign=email.IndexOf("@");
                theEntireNameWithSigns = email.Remove(indexOfAtSign);
                ListOfNames.Add(theEntireNameWithSigns);

            }
            return ListOfNames;

        }
        /*
        public List<string> SeparateName()
        {
            int indexOfPunct;
            foreach (string item in ListOfNames)
            {
                indexOfPunct = item.IndexOf(".");
                firstName = item.Substring(0, indexOfPunct);
                lastName = item.Substring(indexOfPunct + 1);
                fullName = firstName + " " + lastName;
                ListOfSeparatedNames.Add(fullName);
            }

            return ListOfSeparatedNames;
        }
        */


        public List<string> FindNames()
        {
            int indexOfPunct, indexOfDash, indexOfUnderscore;
            foreach (string name in ListOfNames)
            {
                
                indexOfPunct = name.IndexOf(".");
                indexOfDash = name.IndexOf("-");
                indexOfUnderscore = name.IndexOf("_");

                string firstNameString = name.Substring(0, indexOfPunct-1);
                string lastNameString = name.Substring(indexOfPunct+1);

                if(firstNameString.Length<2)
                {
                    firstName = "unknown";
                   
                }
                else if(lastNameString.Length<2)
                {
                    lastName = "unknown";
                }
                else
                {
                    if (firstNameString.Contains("-"))
                    {
                        string firstNamePartOne = firstNameString.Substring(0, indexOfDash - 1);
                        string firstNamePartTwo = firstNameString.Substring(indexOfDash + 1);

                        firstName = firstNamePartOne + " " + firstNamePartTwo;
                    }
                    else
                    {
                        firstName = firstNameString;
                    }

                    if (lastNameString.Contains("_"))
                    {
                        string lastNamePartOne = lastNameString.Substring(0, indexOfUnderscore - 1);
                        string lastNamePartTwo = lastNameString.Substring(indexOfUnderscore + 1);
                        lastName = lastNamePartOne + "-" + lastNamePartTwo;
                    }
                    else
                    {
                        lastName = lastNameString;
                    }
                }
                
                string finalName = firstName + " " + lastName;
                ListOfFinalNames.Add(finalName);

            }


            return ListOfFinalNames;
        }
    }
}
