using System;

class EnterNumbers
{
    static void Main()
    {
        int start = 1;
        int end = 100;
        for (int i = 1; i <= 10; i++)
        {            
            Console.WriteLine("{0}  ->  {1}", i, ReadNumbers(start, end));
        }        
    }

    private static int ReadNumbers(int start, int end)
    {        
        int number = 0;
        while (true)
        {
            try
            {
                number = int.Parse(Console.ReadLine());
                if (number < start || number > end)
                    throw new ArgumentOutOfRangeException();
                return number;
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid format. Cannot parse.");
                Console.WriteLine("Try again!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("Argument must be in range [1..100]. ");
                Console.WriteLine("Try again!");
            }            
        }
    }
}
