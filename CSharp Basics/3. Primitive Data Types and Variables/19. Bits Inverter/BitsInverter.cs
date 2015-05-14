using System;

class BitsInverter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        byte step = byte.Parse(Console.ReadLine());
        int tempPosition = 7;
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)        
            numbers[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            int value = numbers[i];
            while (tempPosition >= 0)
            {
                value ^= (1 << tempPosition);
                tempPosition = tempPosition - step;
            }
            Console.WriteLine(value);
            tempPosition += 8;
        }
    }
}
