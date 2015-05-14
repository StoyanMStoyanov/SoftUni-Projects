using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempProject
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 97; i < 123; i++)
            {
                Console.WriteLine("{0} {1}", i, (char)i);
            }
        }
    }
}
