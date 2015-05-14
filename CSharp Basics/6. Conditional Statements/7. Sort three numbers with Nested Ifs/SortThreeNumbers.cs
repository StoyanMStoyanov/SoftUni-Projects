using System;

class SortThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter value: ");
        int firstValue = int.Parse(Console.ReadLine());
        Console.Write("Enter value: ");
        int secondValue = int.Parse(Console.ReadLine());
        Console.Write("Enter value: ");
        int thirdValue = int.Parse(Console.ReadLine());
        
        int tempValue = firstValue;

        if (firstValue > secondValue)
        {
            firstValue = secondValue;
            secondValue = tempValue;
            if (secondValue > thirdValue)
            {
                tempValue = secondValue;
                secondValue = thirdValue;
                thirdValue = tempValue;
                if (firstValue > secondValue)
                {
                    tempValue = firstValue;
                    firstValue = secondValue;
                    secondValue = tempValue;
                }
            }
        }
        else
        {
            if (secondValue > thirdValue)
            {
                tempValue = secondValue;
                secondValue = thirdValue;
                thirdValue = tempValue;
                if (firstValue > secondValue)
                {
                    tempValue = firstValue;
                    firstValue = secondValue;
                    secondValue = tempValue;
                }
            }
        }
        Console.WriteLine("The sorted values are: {0} {1} {2}", firstValue, secondValue, thirdValue);
    }
}
