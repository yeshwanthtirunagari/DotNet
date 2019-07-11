using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Exercises
{
    class IstheStringNullOrEmpty
    {
        public static bool IstheGivenStringNullOrEmpty(string InputString)
        {
            bool Returnbool = string.IsNullOrEmpty(InputString);
            return Returnbool;
        }
        public static bool isStringNull()
        {
            string Input = Console.ReadLine();
            bool ret = string.IsNullOrEmpty(Input);
            return ret;
        }
    }
}
