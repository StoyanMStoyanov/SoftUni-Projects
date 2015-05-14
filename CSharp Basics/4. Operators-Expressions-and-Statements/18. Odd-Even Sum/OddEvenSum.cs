using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int oddNumbers = 0;
        int evenNumbers = 0;

        for (int index = 1; index <= 2 * n; index++)
        {
            int value = int.Parse(Console.ReadLine());
            if (index % 2 != 0) oddNumbers += value;
            else evenNumbers += value;
        }

        if (oddNumbers == evenNumbers) Console.WriteLine("Yes, sum={0}", oddNumbers);
        else Console.WriteLine("No, diff={0}", Math.Abs(oddNumbers - evenNumbers));
    }
}
