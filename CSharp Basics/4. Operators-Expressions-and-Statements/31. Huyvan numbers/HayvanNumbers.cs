using System;

class HayvanNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        int leftSide = 555;
        int centerSide = 0;
        int rightSide = 0;
        bool isNumber = true;

        for (int i = leftSide; i < 1000; i++)
        {
            
            centerSide = leftSide + diff;
            rightSide = centerSide + diff;
            if (IsTrue(leftSide, centerSide, rightSide) || SumDigit(leftSide, centerSide,rightSide, sum))
            {
                leftSide++;                
                continue;
            }
            Console.WriteLine("{0}{1}{2}", leftSide, centerSide,rightSide);
            leftSide++;
            isNumber = false;
        }
        if (isNumber) Console.WriteLine("No");
    }

    private static bool SumDigit(int leftSide, int centerSide, int rightSide, int sum)
    {
        string temp = leftSide.ToString() + centerSide.ToString() + rightSide.ToString();
        int tempSum = 0;
        for (int k = 0; k < temp.Length; k++)
            tempSum += int.Parse(temp[k].ToString());
        return tempSum != sum ? true : false;
    }

    private static bool IsTrue(int leftSide, int centerSide, int rightSide)
    {
        string tempValue = leftSide.ToString() + centerSide.ToString() + rightSide.ToString();
        bool temp = false;
        for (int j = 0; j < 9; j++)
        {
            if (tempValue[j] == '0' || tempValue[j] == '1' || tempValue[j] == '2' ||
                tempValue[j] == '3' || tempValue[j] == '4')
            {
                temp = true;
                break;
            }
        }
        return temp; 
    }
}
