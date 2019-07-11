using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Details
    {
        public int ID;
        public string age;

        public void CustomerDetails()
        {
            Console.WriteLine("The ID of the customer is {0} and the age of the customer is {1}", ID , age);
        }
    }
}
