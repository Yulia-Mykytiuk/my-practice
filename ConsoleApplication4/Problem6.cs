using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Problem6
    {
        static void Answer6()
        {
            long Largesta = 600851475143;
            long PrimeResult = PrimeFactors.LargestPrimeFactor(Largesta);
            Console.Out.WriteLine("Largest Prime Factor = {0}", PrimeResult);
            Console.ReadLine();
        }

        static class PrimeFactors
        {
            public static long LargestPrimeFactor(long x)
            {
                for (long i = x - 1; i > 0; i--)
                {
                    if (x % i == 0)
                    {
                        return i;
                    }
                }
                return x;
            }
        }
    }
}
