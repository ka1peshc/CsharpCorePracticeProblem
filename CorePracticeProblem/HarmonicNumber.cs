using System;
using System.Collections.Generic;
using System.Text;

namespace CorePracticeProblem
{
    class HarmonicNumber
    {
        internal void calculateHarmonicNumber()
        {
            Console.WriteLine("Enter number n ");
            int n = Convert.ToInt32(Console.ReadLine());
            float result=0;
            for(int i = 1; i <= n; i++)
            {
                Console.Write("1/{0}+", i);
                result += 1 / (float)i;
            }
            
            Console.WriteLine("\nSum of series upto {0} is {1}", n, result);
        }
    }
}
