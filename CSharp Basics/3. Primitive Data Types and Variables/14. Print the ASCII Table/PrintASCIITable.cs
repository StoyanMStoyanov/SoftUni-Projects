using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Print_the_ASCII_Table
{
    class PrintASCIITable
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 254; i++)
            {
                Console.WriteLine("{0} - {1}", i, (char) i);
            }
        }
    }
}
