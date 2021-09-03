using System;
using System.Collections.Generic;
using System.Text;

namespace CorePracticeProblem
{
    class VowelOrConsonent
    {
        internal void checkVowelOrConsonent(String s)
        {
            if(s.Equals("a") || s.Equals("A"))
            {
                Console.WriteLine(s + " is vowel");
            }
            else if(s.Equals("e") || s.Equals("E"))
            {
                Console.WriteLine(s + " is vowel");
            }
            else if (s.Equals("i") || s.Equals("I"))
            {
                Console.WriteLine(s + " is vowel");
            }
            else if (s.Equals("o") || s.Equals("O"))
            {
                Console.WriteLine(s + " is vowel");
            }
            else if (s.Equals("u") || s.Equals("U"))
            {
                Console.WriteLine(s + " is vowel");
            }
            else
            {
                Console.WriteLine(s + " is a consonent");
            }
        }
    }
}
