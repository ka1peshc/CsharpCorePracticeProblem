using System;
using System.Collections.Generic;
using System.Text;

namespace CorePracticeProblem
{
    class PrimeFactor
    {
        internal void checkPrimeFactors(int numberp)
        {
            while (numberp % 2 == 0)
            {
                Console.Write(2 + " ");
                numberp /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(numberp); i += 2)
            {
                // While i divides n, print i and divide n
                while (numberp % i == 0)
                {
                    Console.Write(i + " ");
                    numberp /= i;
                }

            }
            if (numberp > 2)
                Console.Write(numberp);
        }
    }
}
