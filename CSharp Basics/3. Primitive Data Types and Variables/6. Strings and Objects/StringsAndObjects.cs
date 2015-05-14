using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Strings_and_Objects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string strHello = "Hello";
            string strWorld = "World.";
            object objVariable = strHello + " " + strWorld;
            string strVariable = (string)objVariable;
            Console.WriteLine(strVariable);
        }
    }
}
