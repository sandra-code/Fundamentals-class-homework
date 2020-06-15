using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingEx
{
    class Expenses
    {
        public string date;
        public string description;
        public string category;
        public double amount;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int maxExpenses = 100;
            Expenses[] arrayOfExpenses = new Expenses[maxExpenses];

            bool finished = false;
            int counter=0;
            string option;

            while (!finished)
            {
                Console.WriteLine("Household accounts");
                Console.WriteLine("1.- Add data");
                Console.WriteLine("2.- View all data in certain category");
                Console.WriteLine("3.- Search data");
                Console.WriteLine("4.- Modify data");
                Console.WriteLine("5.- Delete data");
                Console.WriteLine("6.- Normalize data");
                Console.WriteLine("7.- View all expenses");
                Console.WriteLine("0.- Quit");

                string dateToModify = "";
                string textToModify = "";
                string categoryToModify = "";
                double amountToModify = 0;
                Expenses expenseObject = new Expenses();
                option = Console.ReadLine();
                switch (option)
                {
                    

                    case "1": Console.WriteLine("Option: 1");
                        
                        Console.WriteLine("Enter date (DDMMYYYY): ");
                        string inputDate = Console.ReadLine();
                        int day = int.Parse(inputDate.Substring(0, 2));
                        int month= int.Parse(inputDate.Substring(2, 2));
                        int year = int.Parse(inputDate.Substring(4, 4));
                        
                        
                        if (day<32 && month<13 && year>=1000 && year<=3000)
                        {
                            expenseObject.date = day + "/" + month + "/" + year;
                            expenseObject.date = dateToModify;
                        }
                        else
                        {
                            Console.WriteLine("Please enter your date");
                            finished = true;
                        }

                        Console.WriteLine("Enter description: ");
                        string inputDescription = Console.ReadLine();
                        if (inputDescription != null)
                        {
                            expenseObject.description = inputDescription;
                            textToModify = inputDescription;
                        }
                        else
                        {
                            Console.WriteLine("Enter description");
                        }
                        Console.WriteLine("Enter category: ");
                        expenseObject.category = Console.ReadLine();
                        categoryToModify = expenseObject.category;

                        Console.WriteLine("Enter amount");
                        expenseObject.amount = double.Parse(Console.ReadLine());
                        amountToModify = expenseObject.amount;


                        arrayOfExpenses[counter] = expenseObject;
                        counter++;

                        break;
                    case "2": Console.WriteLine("Option: 2");
                        Console.WriteLine("Enter category: ");
                        string categoryChoice = Console.ReadLine();
                        int listCounter = 1;

                        foreach (Expenses item in arrayOfExpenses)
                        {
                            if (item != null)
                            {
                                if (item.category == categoryChoice)
                                {
                                    Console.WriteLine("{0} - {1} - {2} -{{{3}}} - {4}", listCounter, item.date, item.description, categoryChoice, Math.Round(item.amount, 2));
                                    listCounter++;
                                }
                                else
                                {
                                    Console.WriteLine("There isn't any category named {0}", categoryChoice);
                                }
                            }
                        }

                        break;
                    case "3": Console.WriteLine("Option: 3");
                        Console.WriteLine("Enter the keyword");
                        string keyword = Console.ReadLine().ToLower();

                        int listCounter1 = 1;
                        foreach (Expenses item in arrayOfExpenses)
                        {
                            if (item != null)
                            {
                                if (item.category.Contains(keyword) || item.description.Contains(keyword))
                                {
                                    Console.WriteLine("{0} - {1} - {2}", listCounter1, item.date, item.description);
                                    listCounter1++;
                                }
                                else
                                {
                                    Console.WriteLine("Keyword not found");
                                }
                            }
                        }

                        break;
                    case "4": Console.WriteLine("Option: 4");
                        Console.WriteLine("Enter the record number");
                        int recordNumber = int.Parse(Console.ReadLine());

                        if (recordNumber == 1)
                        {
                            Console.WriteLine("Date (was {0}: hit ENTER to leave as is)", dateToModify);
                            if (Console.ReadLine() != "")
                            {
                                expenseObject.date = Console.ReadLine();
                                dateToModify = expenseObject.date;
                            }
                        }
                        if (recordNumber == 2)
                        {
                            Console.WriteLine("Description (was {0}: hit ENTER to leave as is)", textToModify);
                            if (Console.ReadLine() != "")
                            {
                                expenseObject.description = Console.ReadLine();
                                textToModify = expenseObject.description;
                            }
                        }
                        if (recordNumber==3)
                        {
                            Console.WriteLine("Category (was {0}: hit ENTER to leave as is)", categoryToModify);
                            if (Console.ReadLine() != "")
                            {
                                expenseObject.category = Console.ReadLine();
                                expenseObject.category = categoryToModify;
                            }
                        }
                        if (recordNumber == 4)
                        {
                            Console.WriteLine("Amount (was {0}: hit ENTER to leave as is)", amountToModify);
                            if (Console.ReadLine() != "")
                            {
                                expenseObject.amount = double.Parse(Console.ReadLine());
                                expenseObject.amount = amountToModify;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter number between 1-4");
                        }



                        break;
                    case "5": Console.WriteLine("Option: 5");
                        Console.WriteLine("Enter record number to delete data");
                        recordNumber = int.Parse(Console.ReadLine());
                        if (recordNumber == 1)
                        {
                            dateToModify = null;
                        }
                        else if (recordNumber == 2)
                        {
                            textToModify = null;
                        }
                        else if (recordNumber == 3)
                        {
                            categoryToModify = null;
                        }
                        else if (recordNumber == 4)
                        {
                            amountToModify = 0;
                        }


                        break;
                    case "6": Console.WriteLine("Option: 6");

                        foreach (Expenses item in arrayOfExpenses)
                        {
                            if (item != null)
                            {
                                item.description = item.description.ToLower();
                            }
                        }

                                break;
                    case "7": Console.WriteLine("Option: 7");

                        

                        break;
                    case "0": Console.WriteLine("Option: 0");
                        finished = true;
                        break;
                }
            }
        }
    }
}
