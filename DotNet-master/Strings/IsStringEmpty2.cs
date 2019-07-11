using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class IsStringEmpty2
    {
        public static bool IsTheGivenStringEmpty(string ReceivedString)
        {
            foreach (char C1 in ReceivedString)
            {
                char.IsLetterOrDigit(C1);
                return false;
            }
            return true;
        }

        /****** flip the boolean *****/////

        public static bool FlipTheBoolean(bool bool1)
        {
            if (bool1 == true)
            {
                return false;
            }
            return true;
        }

    }
}
