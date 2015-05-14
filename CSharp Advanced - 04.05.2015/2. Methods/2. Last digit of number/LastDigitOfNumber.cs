using System;

class LastDigitOfNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(LastDigit(n));
    }

    private static string LastDigit(int n)
    {
        string temp;
        switch (n%10)
        {
            case 0:
                temp = "Zero";
                break;
            case 1:
                temp = "One";
                break;
            case 2:
                temp = "Two";
                break;
            case 3:
                temp = "Three";
                break;
            case 4:
                temp = "Four";
                break;
            case 5:
                temp = "Five";
                break;
            case 6:
                temp = "Six";
                break;
            case 7:
                temp = "Seven";
                break;
            case 8:
                temp = "Eight";
                break;
            case 9:
                temp = "Nine";
                break;
            default:
                temp = "This can not digit.";
                break;
        }
        return temp;
    }
}
