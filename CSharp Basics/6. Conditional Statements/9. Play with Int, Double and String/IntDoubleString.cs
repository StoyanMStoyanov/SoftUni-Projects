using System;

class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choice a type:\n1-->int\n2-->double\n3-->string");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("Please enter integer value: ");
                int intValue = int.Parse(Console.ReadLine());
                Console.WriteLine(intValue + 1);
                break;
            case 2:
                Console.Write("Please enter a double value: ");
                int doubleValue = int.Parse(Console.ReadLine());
                Console.WriteLine(doubleValue + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string str = Console.ReadLine();
                Console.WriteLine(str + "*");
                break;
            default:
                break;
        }
    }
}
