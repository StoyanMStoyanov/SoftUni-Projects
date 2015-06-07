using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyExtension;

class ExtensionMethods
{
    static void Main()
    {
        Console.WriteLine("Stoyan".ReverseString());
        StringBuilder sb = new StringBuilder("Stoyan");
        Console.WriteLine(sb.ReverseToUpper());
    }
}
