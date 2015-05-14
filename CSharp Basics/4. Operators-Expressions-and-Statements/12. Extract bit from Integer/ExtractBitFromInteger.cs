using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        bool parseSuccess = false;
        int outValue = 0;
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        do
        {
            Console.Write("Enter bit number for check from 0 to 31: ");
            parseSuccess = int.TryParse(Console.ReadLine(), out outValue);
            if (outValue < 0 || outValue > 31)
            {
                parseSuccess = false;
                Console.WriteLine("Invalid value for position.");
            }

        } while (!parseSuccess);
        byte position = (byte)outValue;
        int mask = number << position;
        int numberAndMask = number & mask;
        Console.WriteLine("The bit at position {0} of value {2} is: {1}.", position, numberAndMask == 0 ? 0 : 1, Convert.ToString(number, 2));
    }
}
