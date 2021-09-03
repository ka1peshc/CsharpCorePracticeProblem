using System;
using System.Collections.Generic;
using System.Text;

namespace CorePracticeProblem
{
    class QuotientAndRemainder
    {
        internal void fetchQuotientAndRemainder(int divident, int divisor)
        {
            float quotient = divident / divisor;
            float remainder= divident % divisor;
            Console.WriteLine("Quotient is {0} and Remainder is {1}", quotient, remainder);
        }
    }
}
