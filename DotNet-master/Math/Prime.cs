using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Math
{
    class Prime
    {
        public void IsPrime()
        {
            int InputNumber = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < InputNumber; j++)
            {
                int k = 0;
                int f = j;
                for (int i = 1; i <= f; i++)
                {
                    if (f % i == 0)
                    {
                        k++;
                    }
                }
                if (k == 2)
                {
                  Console.WriteLine(f +",");
                }
            }
        }

        public bool Hello()
        {
            int InputNumber = 5; int k = 0; int res = 0;
                for (int i = 1; i <= InputNumber; i++)
                {
                    res = InputNumber % i;
                    if (res == 0)
                    {
                        k++;
                    }
                    if (k == 2)
                    {
                    return true;
                    }                
                }
            return false;
        }
    }
}
