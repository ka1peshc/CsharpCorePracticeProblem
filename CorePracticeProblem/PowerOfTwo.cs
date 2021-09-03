using System;
using System.Collections.Generic;
using System.Text;

namespace CorePracticeProblem
{
    class PowerOfTwo
    {
        internal void printTable()
        {
            Console.WriteLine("Enter positive number n ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 32 || n < 1)
            {
                Console.WriteLine("Enter n in 1 to 32 range");
            }
            else
            {
                double endStatement = Math.Pow(2, n);
                int i = 1;
                double result;
                while (i <= n)
                {
                    result = Math.Pow(2, i);
                    Console.WriteLine("2 ^ "+i+" = " + result);
                    i++;
                }
            }
            
        }
    }
}
