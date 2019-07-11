using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Addition
    {
        public static string EvenOdd()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                return "Even";
            }
            return "Odd";
        }
        public static bool  HasSpaces()
        {
            //best way to do is "return (str.contain(" "));"
            string str = Console.ReadLine();
            return (str.Contains(" "));
           
        }
        public static double differenceMaxMin(double[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine("The difference is");
            return arr[0];
           // return arr[arr.Length - 1] - arr[0];
        }


    }
}
