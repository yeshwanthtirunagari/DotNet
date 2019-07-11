using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Concepts
{
    class GetSetProperties
    {
        private string Name;

        public int ReturnLength(string str1)
        {
            Name = str1; 
            return Name.Length;
        }
    }
}
