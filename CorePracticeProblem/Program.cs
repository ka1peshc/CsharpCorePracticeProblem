using System;

namespace CorePracticeProblem
{
    class Program
    {
        void FlipCoin()
        {
            Console.WriteLine("Hello World!");
            HeadsAndTails hat = new HeadsAndTails();
            hat.HeadAndTail();
        }
        void LeapYear()
        {
            Console.WriteLine("Enter the year to check if leap year or not");
            int year = Convert.ToInt32(Console.ReadLine());
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
        }
        void PowerOf2Table()
        {
            PowerOfTwo pot = new PowerOfTwo();
            pot.printTable();
        }
        void HarmonicSeries()
        {
            HarmonicNumber hr = new HarmonicNumber();
            hr.calculateHarmonicNumber();
        }
        void SwapNumber()
        {
            Console.WriteLine("Enter two number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            SwapNumber sn = new SwapNumber();
            sn.doSwap(num1, num2);
        }
        void EvenOrOdd()
        {
            EvenOrOdd eo = new EvenOrOdd();
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            eo.checkEvenOrOdd(num);
        }
        void VowelOrConsonent()
        {
            Console.WriteLine("Enter an alphabet to check if it is vowel or consonent");
            String alpha = Console.ReadLine();
            VowelOrConsonent vc = new VowelOrConsonent();
            vc.checkVowelOrConsonent(alpha);
        }
        void LargestNumber()
        {
            Console.WriteLine("Enter three number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            FindLargestNum fln = new FindLargestNum();
            fln.findLargestNumber(number1, number2, number3);
        }
        void QuotientAndRemainder()
        {
            Console.WriteLine("Enter divident and divisor respectivily");
            int divident = Convert.ToInt32(Console.ReadLine());
            int divisor = Convert.ToInt32(Console.ReadLine());
            QuotientAndRemainder qar = new QuotientAndRemainder();
            qar.fetchQuotientAndRemainder(divident, divisor);
        }
        void PrimeFactor()
        {
            Console.WriteLine("Enter number to check prime factors");
            int numberP = Convert.ToInt32(Console.ReadLine());
            PrimeFactor pf = new PrimeFactor();
            pf.checkPrimeFactors(numberP);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter option number ");
            Console.WriteLine("1. Flip a coin and find result");
            Console.WriteLine("2. Check number is leap year");
            Console.WriteLine("3. Get power of 2 table ");
            Console.WriteLine("4. Harmonic Series");
            Console.WriteLine("5. Get Prime Factor");
            Console.WriteLine("6. Compute Quotient and Remainder");
            Console.WriteLine("7. Swap two number");
            Console.WriteLine("8. Number is even or odd");
            Console.WriteLine("9. Alphabet is vowel or consonant");
            Console.WriteLine("10. Largest Among three number");
            Program p = new Program();
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    p.FlipCoin();
                    break;
                case 2:
                    p.LeapYear();
                    break;
                case 3:
                    p.PowerOf2Table();
                    break;
                case 4:
                    p.HarmonicSeries();
                    break;
                case 5:
                    p.PrimeFactor();
                    break;
                case 6:
                    p.QuotientAndRemainder();
                    break;
                case 7:
                    p.SwapNumber();
                    break;
                case 8:
                    p.EvenOrOdd();
                    break;
                case 9:
                    p.VowelOrConsonent();
                    break;
                case 10:
                    p.LargestNumber();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

        }
    }
}
