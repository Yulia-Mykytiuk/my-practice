using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Problem4
    {
        static void Answer4()
        {
            List<long> smalestMultiple = new List<long>();

            for (long i = 1; i < 1000000000; i++)
            {
                bool test = false;
                for (int j = 1; j <= 20; j++)
                {
                    if (i % j == 0)
                    {
                        test = true;
                    }
                    else
                    {
                        test = false;
                        break;
                    }
                }
                if (test == true)
                {
                    smalestMultiple.Add(i);
                }
            }

            long result = smalestMultiple.Min();
            Console.Out.WriteLine("Smalest multiple = {0}", result);
            Console.ReadKey();
        }
    }
}
