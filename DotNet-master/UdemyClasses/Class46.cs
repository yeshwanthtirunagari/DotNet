using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.UdemyClasses
{
    class Class46
    {
        public void loop()
        {
            int i = 0;
            //string name = "John McKay";
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach (char Character in name)
            //{
            //    Console.WriteLine(Character);
            //}

            int[] IntArray = new int[] { 97, 16, 99, 0, 36, 3, 6, 9, 10, 24, 33 };
            foreach (int number in IntArray)
            {
                Console.WriteLine(number);
            }
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            while (true)
            {
                string name = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("The name entered is: " + name);
                    continue;
                }
                break;
            }
        }
    }
}
