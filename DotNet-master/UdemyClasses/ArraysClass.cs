using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.UdemyClasses
{
    class ArraysClass
    {
        public void ArraysMethod()
        {
            int[] IntArray = new int[] { 2, 3, 7, 9, 10, 12, 1, 39, 42 };
            foreach (var item in IntArray)
            {
                Console.WriteLine(item);
            }
            int index = Array.IndexOf(IntArray , 66);
            Console.WriteLine("The index of the number 3 is: " +index);
            Array.Clear(IntArray,0,4);

            Console.WriteLine("This is the effect of Clear method");
            foreach (var item in IntArray)
            {
                Console.WriteLine(item);
            }
        }    
    }
}
