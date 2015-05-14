using System;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int value;
        decimal firstHalf = 0;
        decimal secondHalf = 0;
        for (int i = 0; i < 2 * n; i++)
        {
            value = int.Parse(Console.ReadLine());
            if (i < n) firstHalf += value;
            else secondHalf += value;
        }
        if (firstHalf == secondHalf) Console.WriteLine("Yes, sum={0}", firstHalf);
        else Console.WriteLine("No, diff={0}", Math.Abs(firstHalf - secondHalf));
    }
}
