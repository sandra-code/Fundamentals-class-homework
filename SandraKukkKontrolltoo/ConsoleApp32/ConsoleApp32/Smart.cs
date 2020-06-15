using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Smart : Standard
    {
        public Smart(string listNameString) : base(listNameString)
        {
            listName = listNameString;
            isActive = true;
            priority = 5;
        }

        public override void AddItems(string addedItem)
        {
           string addedItemLowered= addedItem.ToLower();

            if (isActive == true && items.Contains(addedItemLowered))
            {
                Console.WriteLine("List already contains {0}", addedItemLowered);
               
            }
            else if (isActive==true)
            {
                items.Add(addedItemLowered);
            }
            else
            {
                Console.WriteLine("Cannot add this item, list is already full");
            }
        }

        public void GetRandomItem()
        {
            Random rnd = new Random();
            string randomitem=items[rnd.Next(0, items.Count)];

            Console.WriteLine("Random item from the list is: {0}",randomitem);
        }

    }
}
