using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.UdemyClasses
{
    class PascalCase68
    {
        public void PascalCase()
        {
            Console.WriteLine("Enter a few words seperated by space.");
            string inputString = Console.ReadLine();

            StringBuilder sBuilder = new StringBuilder();

            string[] SplitString = inputString.Split(' ');

            foreach (var word in SplitString)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (i == 0)
                    {
                        sBuilder.Append(Char.ToUpper(word[i]));
                    }

                    else
                    {
                        sBuilder.Append(Char.ToLower(word[i]));
                    }
                }
            }

            Console.WriteLine(sBuilder);

            Console.ReadLine();
        }
    }
}
