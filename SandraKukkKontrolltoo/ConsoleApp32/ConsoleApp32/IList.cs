using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    interface IList
    {
        void ChangeStatus();
        void AddItems(string addedItem);
        void SetPriority(int priorityInt);
        void PrintEntireList();
        void PrintListInfo();
        void PrintLastItem();
    }
}
