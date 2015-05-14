using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DeclareVariables
    {
        static void Main(string[] args)
        {
            byte byteNumber = 97;
            sbyte sbyteValue = -115;
            short shortValue = -10000;
            ushort ushortValue = 52130;
            int intValue = 4825932;

            Console.Write("Byte: {0}\nSByte: {1}\nShort: {2}\nUShort: {3}\nInt: {4}\n", 
                byteNumber, sbyteValue, shortValue, ushortValue, intValue);

        }
    }
}
