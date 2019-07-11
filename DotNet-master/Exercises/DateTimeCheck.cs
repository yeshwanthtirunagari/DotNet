using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Exercises
{
    class DateTimeCheck
    {
        public static bool CheckDateTime(int month, int day)
        {
            try
            {
                if (month == 12 && day == 24)
                {
                    return true;
                }
                
            }
            catch (Exception)
            {
                Console.WriteLine("You entered an invalid date");
            }
            return false;
            //DateTime date1 = new DateTime(x, y, z);
            //Console.WriteLine(date1.ToString());
            //if (date1.ToString() == "12/24/2019 12:00:00 AM")
            //{
            //    return true;
            //}
            //return false;
        }

        public static int ReturnIncremented(int x)
        {
            x++;
            return x;
        }

        public static string FullName(string FN, string LN)
        {
            return LN + "," + FN;
            
        }
    }
}
