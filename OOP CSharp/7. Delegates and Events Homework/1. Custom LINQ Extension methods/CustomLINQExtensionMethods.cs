using System;
using System.Collections.Generic;
using System.Linq;

class CustomLINQExtensionMethods
{
    static void Main()
    {
        List<int> nums = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };
        var filteredCollection = nums.WhereNot(x => x % 2 == 0);
        Console.WriteLine(string.Join(", ",  filteredCollection));
        Console.WriteLine(new string('-', 50));

        var students = new List<Student>
        {
            new Student ("Stoyan", 9),
            new Student ("Niki", 7),
            new Student("Gosho", 5),
            new Student ("Ivan", 6)
        };

        Console.WriteLine("Max grade: {0}", students.Max(s => s.Grade));
        Console.WriteLine(new string('-', 50));
    }
}
