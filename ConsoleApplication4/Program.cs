using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            // **************************************
            int summ = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    summ += i;
                }
            }
            //Console.Out.WriteLine("Summ = {0}", summ);
            //Console.ReadLine();

            // **************************************

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

            for (int i = 0; i <= Fibonacci.Count-1; i++ )
            {
                if (Fibonacci[i] < 4000000 && Fibonacci[i] % 2 == 0)
                {
                    Fib_summ += Fibonacci[i];
                }
            }

            //Console.Out.WriteLine("Summ = {0}", Fib_summ);
            //Console.Read();

            // **************************************

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
            //Console.Out.WriteLine("The biggest number = {0}", biggest);
            //Console.ReadKey();

            // **************************************

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
            //Console.Out.WriteLine("Smalest multiple = {0}", result);
            //Console.ReadKey();

            // **********************************

            int SummOfSqares = 0;
            int SquareOfSumm = 0;

            for (int i = 1; i <= 100; i++)
            {
                SquareOfSumm += i;
                SummOfSqares += i * i;
            }

            SquareOfSumm *= SquareOfSumm;
            int difference = SquareOfSumm - SummOfSqares;
            //Console.Out.WriteLine("Difference = {0}", difference);
            //Console.ReadLine();

            // *************************************

            long Largesta = 600851475143;
            long PrimeResult = PrimeFactors.LargestPrimeFactor(Largesta);
            Console.Out.WriteLine("Largest Prime Factor = {0}", PrimeResult);
            Console.ReadLine();
        }
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

    static class PrimeFactors
    {
        public static long LargestPrimeFactor(long x)
        {
            for (long i = x-1; i > 0; i--)
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
