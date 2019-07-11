using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Exercises
{
    class Palindrome
    {
        public static void palindrome()
        {
            while (true)
            {
                Console.WriteLine("Enter a String");
                String InputString = Console.ReadLine();

                if (InputString.ToLower() == "ok")
                {
                    Console.WriteLine("Since you entered OK , the program is exiting");
                    break;
                }

                else
                {
                    Char[] chrArray = InputString.ToCharArray();

                    Array.Reverse(chrArray);
                    String reversedstring = new String(chrArray);

                    Console.WriteLine(reversedstring);

                    if (InputString == reversedstring)
                    {
                        Console.WriteLine("The entered string is a Palindrome");
                    }
                    else
                    {
                        Console.WriteLine("The entered string is not a palindrome");
                    }
                }             
            }         
        }
    }
}
