using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandraKukk3kodutoo
{
    class BankCard
    {
        int Balance;
        string cardType;
        int CardNumber;

        public BankCard()
        {
            Balance = 0;
            cardType = "Visa";
        }

        private BankCard(int Balance, string cardType)
        {
        }


        public void SetCardNumber(int CardNumber)
        {
            string CardNumString = CardNumber.ToString();
            bool alldigits = CardNumString.All(char.IsDigit);


            if (CardNumString.Length == 8 && alldigits == true)
            {
                Console.WriteLine(CardNumber);
            }
            else
            {
                Console.WriteLine("Invalid value, the correct format is 8 digits");
            }

        }

        public void SetCardNumber(string CardNumber)
        {
            string CardNumString = CardNumber;
            bool alldigits = CardNumString.All(char.IsDigit);

            if (CardNumString.Length == 8 && alldigits == true)
            {
                Console.WriteLine(CardNumber);
            }
            else
            {
                Console.WriteLine("Invalid value, the correct format is 8 digits");
            }

        }

        public void PrintCardType()
        {
            Console.WriteLine(cardType);
        }

        public void PrintBalance()
        {
            Console.WriteLine(Balance);
        }

        public void AddMoney(int Amount)
        {
            Balance += Amount;
        }

        public void GetMoney(int AmountWanted)
        {
            if (Balance <= 0)
            {
                Console.WriteLine("Cannot do this operation, not sufficient funds");
            }
            else
            {
                Balance -= AmountWanted;
            }

        }
    }
}
