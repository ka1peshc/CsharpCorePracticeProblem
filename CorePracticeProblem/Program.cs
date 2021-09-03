using System;

namespace CorePracticeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Flip Coin and print percentage of Heads and Tails
            Console.WriteLine("Hello World!");
            HeadsAndTails hat = new HeadsAndTails();
            hat.HeadAndTail();
            //Leap Year
            Console.WriteLine("Enter the year to check if leap year or not");
            int year=Convert.ToInt32(Console.ReadLine());
            LeapYear ly = new LeapYear();
            bool leap = ly.checkLeapYear(year);
            if (leap)
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year");
            }
            //Power of 2
            PowerOfTwo pot = new PowerOfTwo();
            pot.printTable();
            //Harmonic
            HarmonicNumber hr = new HarmonicNumber();
            hr.calculateHarmonicNumber();
            
            //Swap number
            Console.WriteLine("Enter two number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            SwapNumber sn = new SwapNumber();
            sn.doSwap(num1, num2);
            
            //Even or odd
            EvenOrOdd eo = new EvenOrOdd();
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            eo.checkEvenOrOdd(num);
            
            //Check Alphabet is vowel or consonent
            Console.WriteLine("Enter an alphabet to check if it is vowel or consonent");
            String alpha = Console.ReadLine();
            VowelOrConsonent vc = new VowelOrConsonent();
            vc.checkVowelOrConsonent(alpha);
            
            //Check for largest number
            Console.WriteLine("Enter three number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            FindLargestNum fln = new FindLargestNum();
            fln.findLargestNumber(number1, number2, number3);
            */
            //Finding Quotient and Remainder
            Console.WriteLine("Enter divident and divisor respectivily");
            int divident = Convert.ToInt32(Console.ReadLine());
            int divisor = Convert.ToInt32(Console.ReadLine());
            QuotientAndRemainder qar = new QuotientAndRemainder();
            qar.fetchQuotientAndRemainder(divident,divisor);

        }
    }
}
