using System;
using System.Numerics;

class FibonicchiNumbers
{
    static void Main()
    {
        bool success = false;
        int length = 0;
        do
        {
            Console.Clear();
            Console.Write("Enter positive integer value 1 < n <= 200: ");
            success = int.TryParse(Console.ReadLine(), out length);
            if (length <= 0 || length > 200) success = false;
        } while (!success);
        BigInteger prevValue = 0;
        BigInteger currentValue = 1;
        BigInteger sum = 1;
        if (length == 1) Console.Write("Fibonachi sequence: 0.");
        else
        {
            Console.Write("Fibonachi sequence: 0, ");
            for (int i = 1; i < length; i++)
            {
                Console.Write(currentValue);
                if (i != length - 1) Console.Write(", ");
                else Console.Write(".");                
                sum = currentValue + prevValue;
                prevValue = currentValue;
                currentValue = sum;
            }
        }
        Console.WriteLine();
    }
}
