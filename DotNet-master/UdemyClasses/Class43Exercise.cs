using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.UdemyClasses
{
    class UdemyClass43
    {
        public string TaskOne()
        {
            Console.WriteLine("Enter a Number between 1 and 10");
            int InputNumber = Convert.ToInt32(Console.ReadLine());
            if (InputNumber >= 1 && InputNumber <= 10)
            {
                return "This is a valid number";
            }
            return "This is NOT a valid number.";
        }

        public int DisplayMax()
        {
            Console.WriteLine("Enter the first number: ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            if (FirstNumber > SecondNumber)
            {
                return FirstNumber;
            }
            Console.Write("The largest number of the two is: ");
            return SecondNumber;
        }

        public string LandOrPotrait()
        {
            Console.WriteLine("Enter the Height of the photo: ");
            int Height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Width of the Photo: ");
            int Width = Convert.ToInt32(Console.ReadLine());
            if (Height > Width)
            {
                return "Potrait";
            }
            Console.Write("The photo is a ");
            return "Landscape";
        }

        public void SpeedCamera()
        {
            Console.WriteLine("Set the Speed Limit");
            int SpeedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the speed of the Car: ");
            int SpeedOfTheCar = Convert.ToInt32(Console.ReadLine());

            if (SpeedOfTheCar <= SpeedLimit)
            {
                Console.WriteLine("Your speed is ok");
            }
            else if (SpeedOfTheCar > SpeedLimit)
            {
                int DemeritPoints = (SpeedOfTheCar-SpeedLimit) / 5;
                Console.WriteLine("You are travelling at very high speeds, and your demerit points are: " +DemeritPoints);
                if (DemeritPoints>= 12)
                {
                    Console.WriteLine("Your demerit points are more than 12, hence your license has been suspended.");
                }
            }
        }
    }
}
