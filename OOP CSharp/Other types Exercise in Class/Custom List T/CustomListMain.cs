using System;

class CustomListMain
{
    static void Main()
    {
        CustomList<int> ints = new CustomList<int>();
        ints.Add(5);
        ints.Add(10);
        ints.Add(20);
        ints.Add(30);
        ints.Add(10);
        ints.Add(10);
        Console.WriteLine(ints);
        ints.Remove(10);
        Console.WriteLine(ints);
        ints.Add(40);
        Console.WriteLine(ints);
        ints.Remove(40);
        Console.WriteLine(ints);
        Console.WriteLine(ints.IndexOf(5));
        Console.WriteLine(ints.Min());
        Console.WriteLine(ints.Max());
        Console.WriteLine(ints[1]);
        ints[1] = 100;
        Console.WriteLine(ints[1]);
        Console.WriteLine(ints);
        ints.Insert(25, 3);
        Console.WriteLine(ints);
        Console.WriteLine(ints.ContainsValue(5));
        //ints[25] = 1;
    }
}
