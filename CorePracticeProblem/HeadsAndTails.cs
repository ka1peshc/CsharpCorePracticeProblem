using System;
using System.Collections.Generic;
using System.Text;

namespace CorePracticeProblem
{
    class HeadsAndTails
    {
        public void HeadAndTail()
        {
            Console.WriteLine("Enter number of times to toss a coin");
            int flipTill = Convert.ToInt32(Console.ReadLine());
            int headCount = 0;
            int tailCount = 0;
            int coinFlip = 1;
            float n;
            Random random = new Random();
            while (coinFlip <= flipTill)
            {
                n = random.Next(0, 2);
                if (n < 0.5)
                {
                    tailCount++;
                }
                else
                {
                    headCount++;
                }
                coinFlip++;
            }
            Console.WriteLine(headCount);
            Console.WriteLine(tailCount);
            float temp;
            float headPercent = (headCount * 100) / flipTill;
            temp = tailCount * 100;
            float tailPercent = temp / flipTill;
            Console.WriteLine("head's is " + headPercent+"%" + " tail's is " + tailPercent + "%");
        }
    }
}
