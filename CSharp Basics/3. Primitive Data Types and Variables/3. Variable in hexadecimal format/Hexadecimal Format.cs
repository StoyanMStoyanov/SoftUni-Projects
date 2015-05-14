using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variable_in_hexadecimal_format
{
    class HexadecimalFormat
    {
        static void Main(string[] args)
        {            
            Console.Write("Enter integer value: ");
            int intValue = int.Parse(Console.ReadLine());
            Console.WriteLine("The variable in decimal is: {0}.", intValue);
            Console.WriteLine("The variable in hexadecimal is: {0:X}.", intValue);
        }
    }
}
