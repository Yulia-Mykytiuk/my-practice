﻿using System;
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
            // not finished yet
            List<long> Primes = new List<long>();

            for (long i = 1; i < 2000; i++)
            {
                bool test = false;
                for (long j = i - 1; j > 0; j--)
                {
                    if (i % j == 0)
                    {
                        test = false;
                        //break;
                    }
                    else
                    {
                        test = true;
                        break;
                    }
                }
                if (test)
                {
                    Primes.Add(i);
                    test = false;
                }
            }

            long summ = 0;

            Primes.ForEach(delegate(long item)
            {
                if (item < 2000000)
                {
                    summ += item;
                }
                Console.Write(item + ", ");
            });

            Console.WriteLine("Summ of primes below 2 million = {0}", summ);
            Console.ReadKey();
        }
    }
}
