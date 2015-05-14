using System;

class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int tempPosition = 6;
        for (int i = 0; i < n; i++)
            numbers[i] = int.Parse(Console.ReadLine());

        for (int index = 0; index < numbers.Length; index++)
        {
            int value = numbers[index];            
            while (tempPosition >= 0)
            {
                value |= 1 << (tempPosition);
                tempPosition = tempPosition - step;                
            }
            Console.WriteLine(value);
            tempPosition += 8;
        }
    }
}
