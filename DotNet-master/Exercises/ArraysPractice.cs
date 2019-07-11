using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Exercises
{
    class ArraysPractice
    {
        int[] arr = new int[] { 3, 9, 2, 0, 4, 67, 89, 69 };

        public void LargestArray()
        {
            Array.Sort(arr);
            Console.WriteLine(arr[arr.Length-1]);
        }

        public void DeleteSmallest()
        {
            List<int> numbersArray = arr.ToList();
            numbersArray.Sort();
            numbersArray.Remove(0);
            foreach (var i in numbersArray)
            {
                Console.WriteLine(i);
            }
        }

        public int Factorial()
        {
            int InputNumber = Convert.ToInt32(Console.ReadLine());
            int res = InputNumber;
            for (int i = InputNumber-1; i >= 1; i--)
            {
                res = res * i;
            }
            return res;
        }
        public bool prime()
        {
            int j = Convert.ToInt32(Console.ReadLine()); ;int k = 0;
            for (int i = 1; i <=j; i++)
            {
                if (j%i == 0)
                {
                    k++;
                }
            }
            if (k == 2)
            {
                return true;
            }
            return false;
        }

    }



}
