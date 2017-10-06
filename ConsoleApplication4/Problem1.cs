using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Problem1
    {
        static void Answer1()
        {
            int summ = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    summ += i;
                }
            }
            Console.Out.WriteLine("Summ = {0}", summ);
            Console.ReadLine();
        }
    }
}
