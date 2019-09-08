using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.UdemyClasses
{
    class myStringBuilder66
    {
        public void mySBuilder()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append('-' , 1);

            var name = "Mosh";

           var x =  name.ToUpper();

            Console.WriteLine(x);


        }

    }
}
