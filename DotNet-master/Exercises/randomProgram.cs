using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Exercises
{
    class randomProgram
    {
        public void PrimeNumber()
        {
            Console.WriteLine("Enter a number:");
            int inputNumber1 = Convert.ToInt32(Console.ReadLine());

            int counter = 0;

            for (int i = 1; i <= inputNumber1; i++)
            {
                if (inputNumber1 % i == 0)
                {
                    counter++;
                }
            }

            if (counter == 2)
            {
                Console.WriteLine("The number you entered is a prime number");
            }
            else
            {

                Console.WriteLine("The number you entered is not a prime number");
            }
        }
    }
}
