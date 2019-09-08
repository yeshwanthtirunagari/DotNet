using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Details
    {
        public int ID { get; set; }
        public string age {get; set;}

        public void CustomerDetails()
        {
            Console.WriteLine("The ID of the customer is {0} and the age of the customer is {1}", ID , age);
        }
    }
}
