using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassesAndObjects
{
   public class ReadingTheFile
    {
        private int population { get; set; }
        private string City { get; set; }
        private string State { get; set; }
        private List<int> Interstate = new List<int>();

        public void ReadFileProcess()
        {
            int i = 0;
            string[] SplittingEachLine = null;
            var TxtFile = File.ReadAllLines(@"C:\MyProgrammingFiles\MyLearning\C#\myCodingTasks\firstTaskForAssessment\Challenge\Sample_Cities.txt", Encoding.UTF8);
            foreach (var EachLine in TxtFile)
            {
                SplittingEachLine = EachLine.Split('|');
                Console.WriteLine(SplittingEachLine[0]);
                Console.WriteLine(SplittingEachLine[1]);
                Console.WriteLine(SplittingEachLine[2]);
                Console.WriteLine(SplittingEachLine[3]);
            }
            Array.Sort(SplittingEachLine);
           
        }
    }
}
