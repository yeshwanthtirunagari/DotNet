using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Exercises
{
    class RandomPracticing
    {
        public string ConvertToUpperCase()
        {
            Console.WriteLine("Enter a string: ");
            string inputString = Console.ReadLine();
            int i = 0;
            char[] chArray = new char[inputString.Length];

            foreach (char ch in inputString)
            {
                chArray[i] = char.ToUpper(ch);
                i++;
            }

            string inputString2 = new string(chArray);

            return inputString2;
        }

        public string reverseName()
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();
            char[] chAray = new char[inputString.Length];

            for (int i = inputString.Length; i > 0; i--)
            {
                chAray[inputString.Length - i] = inputString[i - 1];
            }
            char[] chArray = inputString.ToArray();

            Array.Reverse(chArray);

            string returnString = new string(chArray);

            return returnString;
        }

        public int uniqueNumbers()
        {
            List<int> numberList = new List<int>();
            int counter = 0;
            while (counter < 5)
            {
                Console.WriteLine("Enter a number");
                int number = Convert.ToInt32(Console.ReadLine());

                if (!string.IsNullOrEmpty(number.ToString()))
                {
                    if (!numberList.Contains(number))
                    {
                        numberList.Add(number);
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("This is a duplicate number, please enter again");
                    }
                }
                else
                {
                    Console.WriteLine("you didn't enter any number, please enter a number");
                }

                if (counter == 5)
                {
                    break;
                }
            }
            int sum = 0;
            Console.WriteLine("Following are the numbers in the list");
            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine(numberList[i]);
                sum = sum + numberList[i];
            }
            return sum;
        }

        public void printUniqueNumbers()
        {
            List<int> numbersList = new List<int>();
            while (true)
            {
                try
                {
                    string inputNumber = Console.ReadLine();
                    if (inputNumber.ToLower() == "quit")
                    {
                        break;
                    }
                    else
                    {
                        numbersList.Add(Convert.ToInt32(inputNumber));
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("please enter a valid input:");
                }
            }

            for (int i = 0; i < numbersList.Count; i++)
            {
                int counter = 0;
                for (int j = 0; j < numbersList.Count; j++)
                {
                    if (numbersList[i] == numbersList[j])
                    {
                        counter++;
                    }
                }

                if (counter < 2)
                {
                    Console.WriteLine(numbersList[i]);
                }
            }
        }

        public void smallestThree()
        {
            List<int> listNumber = new List<int>();
            while (true)
            {
                try
                {
                    int inputNumber = Convert.ToInt32(Console.ReadLine());
                    if (inputNumber == 999)
                    {
                        break;
                    }
                    else
                    {
                        listNumber.Add(inputNumber);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid input");
                }
            }

            listNumber.Sort();

            Console.WriteLine(listNumber[0]);
            Console.WriteLine(listNumber[1]);
            Console.WriteLine(listNumber[2]);
        }

        public void threeNumbers()
        {
            string[] elements;
            List<int> numberList = new List<int>();
            while (true)
            {
               
                Console.WriteLine("Please enter numbers seperated by coma.");
                string inputNumbers = Console.ReadLine();

                elements = inputNumbers.Split(',');

                if (elements.Length < 5 || String.IsNullOrEmpty(inputNumbers))
                {
                    Console.WriteLine("Please enter a valid input");
                }

                else
                {
                    foreach (var item in elements)
                    {
                        numberList.Add(Convert.ToInt32(item));
                    }
                    break;
                }
            }

            List<int> minList = new List<int>();
            int counter = 0;
            
            while (minList.Count<3)
            {
                int num = numberList[0];
                //foreach (var item in numberList)
                //{
                //    if (item < num)
                //    {
                //        num = item;
                //    }
                //}
                ////numberList.Remove(num);
                //minList.Add(num);


                for (int i = 0; i < numberList.Count; i++)
                {
                    if (numberList[i] < num)
                    {
                        num = numberList[i];
                    }                  
                }
                minList.Add(num);
                numberList.Remove(num);
            }

            foreach (var item in minList)
            {
                Console.WriteLine(item);
            }
        }
    }
}


