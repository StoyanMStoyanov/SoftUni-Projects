using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter positive integer value: ");
        uint uintValue = uint.Parse(Console.ReadLine());
        int firstBit, secondBit;
        uint resultValue = uintValue;

        for (int i = 3, j = 24; i <= 5; i++, j++)
        {
            firstBit = (int)(uintValue & (1 << i)) >> i;
            secondBit = (int)(uintValue & (1 << j)) >> j;
            //Console.WriteLine("{0} {1} {2}", Convert.ToString(uintValue, 2), firstBit, secondBit);
            if (firstBit == secondBit) continue;
            else if (firstBit == 0)
            {
                resultValue = resultValue & (uint)(~(1 << j)); //set bit at 0
                resultValue = resultValue | (uint)(1 << i); //set bit at 1
            }
            else
            {
                resultValue = resultValue & (uint)(~(1 << i)); //set bit at 0
                resultValue = resultValue  | (uint)(1 << j); //set bit at 1
            }
        }
        Console.WriteLine("\nThe input value is {0}, in binary: {1}.", uintValue, Convert.ToString(uintValue, 2));
        Console.WriteLine("The result value is {0}, in binary: {1}.", resultValue, Convert.ToString(resultValue, 2));
    }
}
