using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Problem3
    {
        static void Answer3()
        {
            List<long> biggestPalindrom = new List<long>();

            for (int i = 999; i > 0; i--)
            {
                for (int j = 999; j > 0; j--)
                {
                    int mnoz = i * j;
                    string mnozstr = mnoz.ToString();
                    string revstr = StringHelper.ReverseString(mnozstr);
                    if (mnozstr == revstr)
                    {
                        biggestPalindrom.Add(mnoz);
                    }
                }
            }

            long biggest = biggestPalindrom.Max();
            Console.Out.WriteLine("The biggest number = {0}", biggest);
            Console.ReadKey();
        }

        static class StringHelper
        {
            public static string ReverseString(string s)
            {
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                return new string(arr);
            }
        }
    }
}
