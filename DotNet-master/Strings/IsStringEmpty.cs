using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class IsStringEmpty
    {
        public static bool IsTheStringEmpty(string StrEmpty)
        {
            
            //foreach (char c1 in StrEmpty)
            //{
            //    Char.IsLetterOrDigit(c1);
            //    return false;
            //}
            //    return true;

        //    if (string.IsNullOrEmpty(StrEmpty))
        //    {
        //        var stringChar = StrEmpty.ToCharArray();

        //        foreach (var value in stringChar)
        //        {
        //            Char.IsLetterOrDigit(value);
        //            return false;
        //        }
        //        return true;
        //    }

            return true;
        }

        public static bool Checkstring(string chkstr)
        {

            foreach (char citem in chkstr)
            {
                //isletterordigit checks for whether the char is a letter or a digit
                char.IsLetterOrDigit(citem);                         
                return false;
            }
            return true;
        }
        
    }
}
