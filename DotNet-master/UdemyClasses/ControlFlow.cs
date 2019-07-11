using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.UdemyClasses
{
    class ControlFlow
    {
        public  void IfStatement()
        {
            int i = 1; bool GoldCustomer = true; float price;
            if (i> 0 && i <=12)
            {
                Console.WriteLine("It's morning");
            }
            if (GoldCustomer)
            {
                price = 30.30f;
            }
            else { price = 21.30f; }

            float price1 = (GoldCustomer) ? 19.95f : 20.25f;
        }

        public string SwitchCase()
        {
            var season = Seasons.Rainy;
            switch (season)
            {
                case Seasons.Autumn:
                case Seasons.Summer:
                case Seasons.Winter:
                    Console.WriteLine("These seasons are recognized");
                    break;
            }
            return "season unrecognized";
                
            
        }
    }

}
