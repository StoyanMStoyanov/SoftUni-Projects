using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BiggerNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(GetMax(firstNumber, secondNumber));
    }

    private static int GetMax(int firstNumber, int secondNumber)
    {
        int temp = secondNumber;
        if (firstNumber > secondNumber) temp = firstNumber;
        return temp;
    }
}
