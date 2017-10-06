using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Problem2
    {
        static void Answer2()
        {
            List<int> Fibonacci = new List<int>();
            Fibonacci.Add(1);
            Fibonacci.Add(2);

            for (int i = 0; i < 100; i++)
            {
                var length = Fibonacci.Count();
                var x = Fibonacci.ElementAt(length - 1);
                var y = Fibonacci.ElementAt(length - 2);
                var a = Convert.ToInt32(x) + Convert.ToInt32(y);
                if (x <= 4000000)
                {
                    Fibonacci.Add(a);
                }
            }

            int Fib_summ = 0;

            Fibonacci.ForEach(delegate(int item)
            {
                //Console.Write(item + ", ");
            });
            //Console.ReadLine();

            for (int i = 0; i <= Fibonacci.Count - 1; i++)
            {
                if (Fibonacci[i] < 4000000 && Fibonacci[i] % 2 == 0)
                {
                    Fib_summ += Fibonacci[i];
                }
            }

            Console.Out.WriteLine("Summ = {0}", Fib_summ);
            Console.Read();
        }
    }
}
