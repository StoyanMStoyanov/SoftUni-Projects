using System;

class ChangeEvenBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
            numbers[i] = int.Parse(Console.ReadLine());
        ulong l = ulong.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int temp = numbers[i];
            //Console.WriteLine("String - {0} -> Length - {1}", 
                //IntToBinaryString(temp), IntToBinaryString(temp).Length);
            //Console.WriteLine(Convert.ToString(temp, 2));
            int maxIndex = IntToBinaryString(temp).Length;
            for (int j = 0; j < maxIndex * 2; j += 2)
            {
                if ((l & (ulong)(1 << j)) == 0) count++;
                l |= (ulong)(1 << j);
            }
            //Console.WriteLine("{0}\n{1}", l, count);
        }
        Console.WriteLine("{0}\n{1}", l, count);
    }
    private static string IntToBinaryString(int number)
    {
        var binary = string.Empty;
        while (number > 0)
        {
            // Logical AND the number and prepend it to the result string
            binary = (number & 1) + binary;
            number = number >> 1;
        }
        return binary;    }
}

