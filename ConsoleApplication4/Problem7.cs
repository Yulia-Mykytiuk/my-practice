using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Problem7
    {
        static void Answer7()
        {
            for (int c = 999; c > 0; c--)
            {
                for (int b = 999; b > 0; b--)
                {
                    for (int a = 999; a > 0; a--)
                    {
                        if (a < b && b < c && a + b + c == 1000 && a * a + b * b == c * c)
                        {
                            Console.WriteLine("a = {0}, b = {1}, c = {2}, abc = {3}", a, b, c, a * b * c);
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
    }
}
