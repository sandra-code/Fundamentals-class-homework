using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Premium : Standard
    {
        public Premium(string listNameString, string ownerNameString) : base(listNameString)
        {
            listName = listNameString;
            ownerName = ownerNameString;
            limit = 6;
            isActive = true;
            priority = 7;
        }

        public override void PrintListInfo()
        {
            Console.WriteLine("List name is {0}. Priority is {1}. Number of items in the list is {2}. Owner is {3}.", listName, priority, items.Count(), ownerName);

        }
    }
}
