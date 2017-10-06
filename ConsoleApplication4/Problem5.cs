using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Problem5
    {
        static void Answer5()
        {
            int SummOfSqares = 0;
            int SquareOfSumm = 0;

            for (int i = 1; i <= 100; i++)
            {
                SquareOfSumm += i;
                SummOfSqares += i * i;
            }

            SquareOfSumm *= SquareOfSumm;
            int difference = SquareOfSumm - SummOfSqares;
            Console.Out.WriteLine("Difference = {0}", difference);
            Console.ReadLine();
        }
    }
}
