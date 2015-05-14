using System;

class ModifyBitAtPosition
{
    static void Main()
    {
        bool parseSuccess = false;
        int outValue = 0;
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        do
        {
            Console.Write("Enter bit number for modify from 0 to 31: ");
            parseSuccess = int.TryParse(Console.ReadLine(), out outValue);
            if (outValue < 0 || outValue > 31)
            {
                parseSuccess = false;
                Console.WriteLine("Invalid value for position.");
            }

        } while (!parseSuccess);
        byte position = (byte)outValue;

        parseSuccess = false;
        do
        {
            Console.Write("Enter bitValue from 0 to 1: ");
            parseSuccess = int.TryParse(Console.ReadLine(), out outValue);
            if (outValue < 0 || outValue > 1)
            {
                parseSuccess = false;
                Console.WriteLine("Invalid value for position.");
            }

        } while (!parseSuccess);
        byte bitValue = (byte)outValue;

        int resultValue;
        if (bitValue == 0)
        {
            resultValue = number & (~(1 << position)); //set bit at 0
            Console.WriteLine("The input value is {0}, in binary: {1}.", number, Convert.ToString(number, 2));
            Console.WriteLine("The result value is {0}, in binary: {1}.", resultValue, Convert.ToString(resultValue, 2));
        }
        else
        {
            resultValue = number | (1 << position); //set bit at 1
            Console.WriteLine("The input value is {0}, in binary: {1}.", number, Convert.ToString(number, 2));
            Console.WriteLine("The result value is {0}, in binary: {1}.", resultValue, Convert.ToString(resultValue, 2));
        }
    }
}
