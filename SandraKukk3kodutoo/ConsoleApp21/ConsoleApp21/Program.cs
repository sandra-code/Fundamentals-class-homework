using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandraKukk3kodutoo
{
    class Program
    {
        static void Main(string[] args)
        {
            BankCard card1 = new BankCard();
            BankCard card2 = new BankCard();

            card1.SetCardNumber(12345678);
            card2.SetCardNumber("a3dfghjk");

            /*
            card1.PrintBalance();
            card1.PrintCardType();
            */
            card1.AddMoney(200);
            card1.PrintBalance();

            card1.GetMoney(50);
            card1.PrintBalance();

            card1.GetMoney(500);
            card1.PrintBalance();


            Console.ReadLine();
        }
    }
}
