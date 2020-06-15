using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Standard : IList
    {
        internal string listName;
        internal string ownerName;
        internal int limit;
        internal bool isActive;
        internal int priority;
        internal string lastItem;
        internal List<string> items = new List<string>();


        public Standard(string listNameString)
        {
            listName = listNameString;
            limit = 3;
            isActive = true;
            priority = 5;
        }

        public void ChangeStatus()
        {
            isActive = false;
        }

        public virtual void AddItems(string addedItem)
        {

            if (isActive == true && items.Count()<=limit)
            {
                items.Add(addedItem);
            }
            else
            {
                Console.WriteLine("Cannot add this item, list is already full");
            }
            
        }

        public void SetPriority(int priorityInt)
        {
            if (isActive==true && priorityInt>=1 && priorityInt<=priority)
            {
                priority = priorityInt;
            }
            else if(isActive==false)
            {
                Console.WriteLine("List is completed");
            }
            else
            {
                Console.WriteLine("Invalid value for priority");
            }
        }

        public void PrintEntireList()
        {
            Console.WriteLine("List name: {0}", listName);

            foreach (string item in items)
            {
               Console.WriteLine(item);
            }
        }

        public virtual void PrintListInfo()
        {
            Console.WriteLine("List name is {0}. Priority is {1}. Number of items in the list is {2}", listName, priority, items.Count());

        }

        public void PrintLastItem()
        {
            lastItem = items[items.Count() - 1];

            Console.WriteLine("Last item in the list is: {0}", lastItem);

            if (listName.Count() == 0)
            {
                Console.WriteLine("No items are present");
            }
        }
    }
}
