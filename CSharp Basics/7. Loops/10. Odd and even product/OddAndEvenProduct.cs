using System;

class OddAndEvenProduct
{
    static void Main(string[] args)
    {
        Console.Write("Enter some integer numbers with space: ");
        string[] elements = Console.ReadLine().Split(',', ' ');
        int oddNumbers = 1;
        int evenNumbers = 1;
        for (int index = 0; index < elements.Length; index++)
        {
            if (index % 2 == 0)
                evenNumbers *= int.Parse(elements[index]);
            else oddNumbers *= int.Parse(elements[index]);
        }
        if (evenNumbers == oddNumbers)
            Console.WriteLine("Yes, product = {0}.", evenNumbers);
        else
            Console.WriteLine("No,\nOdd_product = {0},\nEven_product = {1}.",  evenNumbers, oddNumbers);
    }
}
