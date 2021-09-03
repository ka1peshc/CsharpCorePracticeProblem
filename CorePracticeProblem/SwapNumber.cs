using System;
using System.Collections.Generic;
using System.Text;

namespace CorePracticeProblem
{
    class SwapNumber
    {
        internal void doSwap(int num1, int num2)
        {
            Console.WriteLine("before swap num1 is {0} num2 is {1}", num1, num2);
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("before swap num1 is {0} num2 is {1}", num1, num2);
        }
    }
}
