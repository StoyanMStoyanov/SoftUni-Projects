using System;
using System.Collections.Generic;
using System.Linq;

class StringDisperserMain
{
    static void Main()
    {
        StringDisperser first = new StringDisperser("Stoyan", "Ivan", "Niki");
        StringDisperser second = new StringDisperser("Ivan", "Niki", "Stoyan");
        Console.WriteLine(first);
        Console.WriteLine(second);
        Console.WriteLine("Are dispensers equals: {0}.",  StringDisperser.Equals(first, second));
        Console.WriteLine("Are customers !=: {0}.", first != second);
        Console.WriteLine("Are customers ==: {0}.", first == second);
        Console.WriteLine("First hash code: {0}.", first.GetHashCode());

    }
}
