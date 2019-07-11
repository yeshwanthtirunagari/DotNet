using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Exercises
{ 
    class IsDivisibleBy5
    {
        public static bool IsDivisibleByFive(int num)
        {
            int res = num % 5;
            if (res == 0)
            {
                return true;
            }
            return false; ;
            //string strnum = num.ToString();
            //char[] chAr1 = strnum.ToCharArray();
            //int LastDigit = Convert.ToInt32((chAr1[strnum.Length - 1]).ToString());
            //Console.WriteLine(LastDigit);
            //if (LastDigit == 0 || LastDigit == 5)
            //{
            //    return true;
            //}
            //return false;
        }
    }
}
