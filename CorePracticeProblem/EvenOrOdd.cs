using System;
using System.Collections.Generic;
using System.Text;

namespace CorePracticeProblem
{
    class EvenOrOdd
    {
        internal void checkEvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("{0} is a even number", num);
            }
            else
            {
                Console.WriteLine("{0} is not a even number", num);
            }
        }
    }
}
