using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Data
{
    class Arrays
    {
        

        public void intArray1()
        {
            int[] numbers = new int[3];
            //numbers[0] = 1;

            for (int i = 0; i < numbers.Length; i++)
            {

                if (i == 0)
                {
                    numbers[i] = 4;
                    Console.WriteLine(numbers[i]);
                }
               
                else if (i == 1)
                {
                    numbers[i] = 5;
                    Console.WriteLine(numbers[i]);
                }

                else
                {
                    numbers[i] = 6;
                    Console.WriteLine(numbers[i]);
                }
               
            }
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
        }

        public void boolArray1()
        {
            bool[] BValue = new bool[3];
            BValue[1] = true;

            for (int i = 0; i < BValue.Length; i++)
            {
                Console.WriteLine(BValue[i]);
            }
        //    Console.WriteLine(BValue[0]);
        //    Console.WriteLine(BValue[1]);
        //    Console.WriteLine(BValue[2]);
        }

        public void InitializingValues()
        {
            string[] names = new string[3] {"John" , "Jack" , "Mary" };

            foreach (string val in names)
            {
                Console.WriteLine(val);
            }


        }
        
    }
}
