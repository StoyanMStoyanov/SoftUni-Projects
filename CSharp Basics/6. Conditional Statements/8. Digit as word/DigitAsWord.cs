using System;

class DigitAsWord
{
    static void Main()
    {
        Console.Write("Enter value in range [0...9]: ");
        int value = int.Parse(Console.ReadLine());
        string word;
        switch (value)
        {
            case 0:
                word = "Zero";
                break;
            case 1:
                word = "One";
                break;
            case 2:
                word = "Two";
                break;
            case 3:
                word = "Three";
                break;
            case 4:
                word = "Four";
                break;
            case 5:
                word = "Five";
                break;
            case 6:
                word = "Six";
                break;
            case 7:
                word = "Seven";
                break;
            case 8:
                word = "Eight";
                break;
            case 9:
                word = "Nine";
                break;
            default:
                word = "Not a digit.";
                break;
        }
        Console.WriteLine("The {0} is: {1}.", value, word);
    }
}
