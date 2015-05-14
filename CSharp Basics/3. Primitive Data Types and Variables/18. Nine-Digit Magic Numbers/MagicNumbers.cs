using System;

class MagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        int leftSide = 111;
        int centerSide = 0;
        int rightSide = 0;

        int resultCount = 0;
        for (int index = leftSide; index < 777; index++)
        {
            leftSide++;
            centerSide = leftSide + diff;
            rightSide = centerSide + diff;
            if (IsAllowedNumber(leftSide) && IsAllowedNumber(centerSide) &&
                IsAllowedNumber(rightSide) && (rightSide <= 777) &&
                CalcSumOfDigits(leftSide) + CalcSumOfDigits(centerSide) + CalcSumOfDigits(rightSide) == sum)
            {
                Console.WriteLine("{0}{1}{2}", leftSide, centerSide, rightSide);
                resultCount++;
            }
        }

        if (resultCount == 0) Console.WriteLine("No");
    }

    private static int CalcSumOfDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num = num / 10;
        }
        return sum;
    }

    private static bool IsAllowedNumber(int num)
    {
        string digits = num.ToString();
        foreach (var digit in digits)
        {
            if (digit < '1' || digit > '7')
            {
                return false;
            }
        }
        return true;
    }
}
