using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number <= 0) throw new OverflowException();
            Console.WriteLine(Math.Sqrt(number));
        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid format. Cannot parse.");
        }
        catch (OverflowException)
        {
            Console.Error.WriteLine("The number is too long/small, zero or negative. Cannot Parse.");
        }
        finally
        {
            Console.WriteLine("Good bye.");
        }

    }
}
