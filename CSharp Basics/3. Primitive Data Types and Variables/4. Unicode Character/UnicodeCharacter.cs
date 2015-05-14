using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Unicode_Character
{
    class UnicodeCharacter
    {
        static void Main(string[] args)
        {
            char charValue = '\u002A';            
            Console.WriteLine("The sumbol with code {0} is: {1}.", (int)charValue, charValue);
            int intValue = 42;
            Console.WriteLine("The sumbol with code {0} is: {1}.", intValue, (char)intValue);
        }
    }
}
