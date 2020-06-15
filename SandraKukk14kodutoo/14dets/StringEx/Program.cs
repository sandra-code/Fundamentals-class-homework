using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEx
{
    class Program
    {
        static void Main(string[] args)
        {
            DecodeAccount(@"ttu\mari.maasikas");
            DecodeAccount(@"i:0#.w|microsoft\liina.miina");
            DecodeAccount(@"juhan.kannu.juurikas@ttu.ee");

            EncodeAccount("ttu.ee juhan kannu juurikas");
            Console.ReadLine();
        }

        static void DecodeAccount(string userAccount)
        {
            string domain = "";
            string[] names=null;
            
            if (userAccount.Contains("@"))
            {
                string[] splitAtSign = userAccount.Split('@');
                string domainWithDot = splitAtSign[1];
                domain = domainWithDot.Split('.')[0];
                names = splitAtSign[0].Split(new char[] { '.', '-' });

            }
            else if (userAccount.Contains(@"\") && !userAccount.Contains(@"|"))
            {
                string[] splitAtSign = userAccount.Split('\\');
                domain = splitAtSign[0];
                names = splitAtSign[1].Split(new char[] { '.', '-' });
            }
            else if (userAccount.Contains(@"\") && userAccount.Contains(@"|"))
            {
                string[] splitAtSign = userAccount.Split('\\');
                string firstpart = splitAtSign[0];

                string[] splitAtVerticalBarSign =firstpart.Split('|');
                domain = splitAtVerticalBarSign[1];
                names = splitAtSign[1].Split(new char[] { '.', '-' });
            
            }

            Console.Write("Name: ");
            foreach (string str in names)
            {
                Console.Write(makeUppercaseFirst(str) + " ");
            }
            Console.WriteLine("Domain: " + makeAllUppercase(domain));

        }

        static void EncodeAccount(string userAccount)
        {
            string[] splitAtSpaces = userAccount.Split(' ');
            string domainWithDot = splitAtSpaces[0];
            string domainWithoutDot = domainWithDot.Split('.')[0];

            string name = "";

            for (int i = 1; i < splitAtSpaces.Length; i++)
            {
                name += splitAtSpaces[i];

                if (i!= splitAtSpaces.Length-1)
                {
                    name += ".";
                }
            }
            Console.WriteLine(name+ "@"+domainWithDot +", "+domainWithoutDot+"\\"+name);

        }

        static string makeUppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        static string makeAllUppercase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return s.ToUpper();
        }
    }
}
