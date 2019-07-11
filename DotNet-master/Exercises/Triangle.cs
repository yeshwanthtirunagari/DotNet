using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Exercises
{
    class Triangle
    {
        //Parameters to a method/function must be passed when that function is being called in the Main method. 
        //Parameters to this function are passed in the Main method. "Program.CS"
        public static int AreaOfTriangle(int TBase, int Theight)
        {
            return (TBase * Theight) / 2;         
        }

        public int PerimeterOfTriangle(int side1, int side2, int base1)
        {
             return side1 + side2 + base1;
             
        }
    }


}
