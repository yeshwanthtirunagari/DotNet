using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.MyPrograms
{
    public class PrimeNumbers
    {
        public string Prime(int inpuNumber)
        {
            int counter = 0;
            for (int i = 1; i <= inpuNumber; i++)
            {
                if (inpuNumber % i == 0)
                {
                    counter++;
                }
            }
            if (counter == 2)
            {
                return "It is a prime number";
            }

            return "It is not a prime number";
        }
    }
}