using System;
using System.Collections.Generic;
using System.Text;

namespace CorePracticeProblem
{
    class FindLargestNum
    {
        internal void findLargestNumber(int num1, int num2, int num3)
        {
            if(num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine(num1 + " is a largest number");
                }
                else
                {
                    Console.WriteLine(num3 + " is a largest number");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num2 + " is a largest number");
                }
                else
                {
                    Console.WriteLine(num3 + " is a largest number");
                }
            }

        }
    }
}
