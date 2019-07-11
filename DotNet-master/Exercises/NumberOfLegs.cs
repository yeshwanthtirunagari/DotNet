using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Exercises
{
    class NumberOfLegs
    {
        public static int NoOfLegs(int ChickenLegs, int CowLegs, int PigLegs)
        {            
            int TotalLegs = 2*ChickenLegs + 4*(CowLegs + PigLegs);
            return TotalLegs;
        }

        public static int remainder(int numerator, int denominoator)
        {
            int rem = numerator % denominoator;
            return rem;
        }
    }
}
