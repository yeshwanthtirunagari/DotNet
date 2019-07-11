using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Strings
    {   
        public static void SplitString()
        {
            //String Name1 = "Hamedani";
            string Name = "Mosh";
            char ChName = Name[0];

            string Name2 = "Yeshwanth";
            char CharItem = Name2[0];
           // Console.WriteLine(CharItem);

            string[] StrArray1 = new string[3] {"Jack" , "Jason" , "Mary" };
            string str2 = string.Join("," ,StrArray1 );
            foreach (char c1 in Name2)
            {
                //char charWord = Name2[0];
                //Console.WriteLine(c1);
            }

            //System.Console.WriteLine(ChName);
            //System.Console.WriteLine(Name1);
        }

        public void TestingStaticKeyword()
        {
            Console.WriteLine("This is not a static method. An object needs to be created for this " +
                "class, to access this method.");
        }

        public static void FormattedString()
        {
            string[] FS = new string[3] {"Jack" , "John" , "Jamie" };
            string StringAfterFormatted = string.Join(", " , FS);
            Console.WriteLine(StringAfterFormatted);
        }

        public static void EscapeCharacters()
        {
            string text = @"C:\testdrive\mixeddrive\folderpath\abc";
            Console.WriteLine(text);
        }
        
    }
}
