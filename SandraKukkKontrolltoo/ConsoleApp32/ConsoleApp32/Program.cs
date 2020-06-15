using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            Standard standardlist = new Standard("shopping");
            standardlist.AddItems("milk");
            standardlist.AddItems("flour");
            standardlist.AddItems("eggs");
            standardlist.SetPriority(3);
            standardlist.PrintEntireList();
            standardlist.PrintListInfo();
            standardlist.PrintLastItem();
            Console.WriteLine("");

            Standard standardlist1 = new Standard("books");
            standardlist1.AddItems("firstbook");
            standardlist1.AddItems("secondbook");
            standardlist1.SetPriority(4);
            standardlist1.PrintEntireList();
            standardlist1.PrintListInfo();
            standardlist1.PrintLastItem();
            Console.WriteLine("");

            Premium premiumlist1 = new Premium("movies", "dad");
            premiumlist1.AddItems("firstmovie");
            premiumlist1.AddItems("secondmovie");
            premiumlist1.AddItems("thirdmovie");
            premiumlist1.AddItems("fourthmovie");
            premiumlist1.SetPriority(2);
            premiumlist1.PrintEntireList();
            premiumlist1.PrintListInfo();
            premiumlist1.PrintLastItem();
            Console.WriteLine("");

            Premium premiumlist2 = new Premium("colours", "sandra");
            premiumlist2.AddItems("yellow");
            premiumlist2.AddItems("red");
            premiumlist2.AddItems("blue");
            premiumlist2.AddItems("green");
            premiumlist2.SetPriority(6);
            premiumlist2.PrintEntireList();
            premiumlist2.PrintListInfo();
            premiumlist2.PrintLastItem();
            Console.WriteLine("");

            Smart smartlist = new Smart("shopping");
            smartlist.AddItems("apple");
            smartlist.AddItems("TOMATO");
            smartlist.AddItems("tomATo");
            smartlist.AddItems("Pineapple");
            smartlist.AddItems("bananas");
            smartlist.GetRandomItem();
            Console.ReadLine();
        }
    }
}
