using System;
using System.Collections.Generic;
using System.Text;

namespace CorePracticeProblem
{
    class LeapYear
    {
        public Boolean checkLeapYear(int year)
        {
            if (year < 1000 || year > 9999)
            {
                Console.WriteLine("Enter year in valid range 1000 to 9999");
                return false;
            }
            else
            {
                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        if (year % 400 == 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
