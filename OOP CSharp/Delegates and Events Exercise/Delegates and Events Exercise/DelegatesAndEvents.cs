using System;
using System.Collections.Generic;
using System.Linq;

class DelegatesAndEvents
{
    static void Main()
    {
        List<int> collection = new List<int> { 1, 9, 3, 4 , 6, 11, 3, 22};
        Console.WriteLine(collection.FirstOrDefault(x => x > 7));
        Console.WriteLine(new string('-', 50));
        Console.WriteLine(collection.FirstOrDefault(x => x < 0));
        Console.WriteLine(new string('-', 50));
        Console.WriteLine(string.Join(", ", collection.TakeWhile(x => x < 10)));
        Console.WriteLine(new string('-', 50));
        collection.ForEach(Console.WriteLine);
        Console.WriteLine(new string('-', 50));
    }
}
