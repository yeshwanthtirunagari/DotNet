using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.UdemyClasses
{
    class Class49
    {
        Random random;

        public string RandomNumbers()
        {
            random = new Random();
            int randomNumber = random.Next(1,10);
            int counter = 0;
           
            while (true)
            {
                Console.WriteLine("Enter a Number");
                int InputNumber = Convert.ToInt32(Console.ReadLine());
                if (InputNumber == randomNumber)
                {
                    Console.WriteLine("Yayy you found the number");
                    break;
                }
                else
                {
                    counter++;
                    if (counter == 4)
                    {
                        Console.WriteLine("your chances are over.");
                        break;
                    }

                }
            }
            return "Exiting the program";
        }
        
        public int  DivisibleByThree()
        {
            int j = Convert.ToInt32(Console.ReadLine());
            int numbers = 0;
            for (int i = 1; i <= j; i++)
            {
                if (i%3 == 0)
                {
                    numbers++;
                }
            }
           return numbers;
        }

        public static int SumOfAllEnteredNumbers()
        {   
            int sum = 0;
            while (true)
            {
                Console.Write("Enter a number or OK to exit: ");
                string Input = Console.ReadLine();
                if (Input.ToLower() == "ok" || String.IsNullOrEmpty(Input))
                {                    
                    Console.WriteLine("Exiting out of the program");
                    break;
                }
                else
                {
                    sum += Convert.ToInt32(Input);                              
                }
            }
          return sum;
        }

        public int FactorialOfNumber()
        {
            int InputNumber;
            while (true)
            {
                InputNumber = Convert.ToInt32(Console.ReadLine());
                if (InputNumber == 0)
                {
                    break;
                }
                else
                {
                    for (int i = InputNumber - 1; i >= 1; i--)
                    {
                        InputNumber = InputNumber * i;
                    }                    
                }
                Console.WriteLine(InputNumber);
            }
            return InputNumber;
        }

        public int PrintLargest()
        {
            int[] IntArray = new int[5];
            Console.WriteLine("Enter 5 numbers-");
            for (int i = 0; i < IntArray.Length; i++)
            {
                IntArray[i] = Convert.ToInt32(Console.ReadLine());
                if (i == IntArray.Length-1)
                {
                    Console.WriteLine("The Array has reached it's size.");
                    //break;
                }
            }
            Array.Sort(IntArray);
            Console.Write("The largest number is: ");
            return IntArray[IntArray.Length-1];            
        }
    }
}
