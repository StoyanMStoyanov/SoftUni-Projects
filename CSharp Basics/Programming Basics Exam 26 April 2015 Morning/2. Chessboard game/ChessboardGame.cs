using System;
using System.Text;

class ChessboardGame
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string inputStr = Console.ReadLine();

        int blackSum = 0;
        int whiteSum = 0;

        /*for (int i = 0; i < n * n; i++)
        {
            
            if (i >= inputStr.Length) continue;
            char tempChar = inputStr[i];
            if (i % 2 == 0)
            {
                if ((int)inputStr[i] >= 97 && (int)inputStr[i] <= 122
                    && (int)inputStr[i] >= 48 && (int)inputStr[i] <= 57
                    && (int)inputStr[i] >= 65 && (int)inputStr[i] <= 90)
                    blackSum += (int)inputStr[i];
            }
            else
            {
                if ((int)inputStr[i] >= 97 && (int)inputStr[i] <= 122
                    && (int)inputStr[i] >= 48 && (int)inputStr[i] <= 57
                    && (int)inputStr[i] >= 65 && (int)inputStr[i] <= 90)
                    whiteSum += (int)inputStr[i];
            }
        }*/
        for (int i = 0; i < n * n; i++)
        {
            
            if (i >= inputStr.Length) continue;
            if (i % 2 == 0)
            {
                if ((int)inputStr[i] >= 97 && (int)inputStr[i] <= 122) blackSum += (int)inputStr[i];
                if((int)inputStr[i] >= 65 && (int)inputStr[i] <= 90) whiteSum += (int)inputStr[i];
                if ((int)inputStr[i] >= 48 && (int)inputStr[i] <= 57) blackSum += (int)inputStr[i];
            }
            else
            {
                if ((int)inputStr[i] >= 97 && (int)inputStr[i] <= 122) whiteSum += (int)inputStr[i];
                if ((int)inputStr[i] >= 65 && (int)inputStr[i] <= 90) blackSum += (int)inputStr[i];
                if ((int)inputStr[i] >= 48 && (int)inputStr[i] <= 57) whiteSum += (int)inputStr[i];

            }

        }
        if (blackSum == whiteSum) Console.WriteLine("Equal result: {0}", blackSum);
        else if (blackSum < whiteSum) Console.WriteLine("The winner is: white team\n{0}", whiteSum - blackSum);
        else Console.WriteLine("The winner is: black team\n{0}", blackSum - whiteSum);

        //Console.WriteLine("black {0}  white{1} ", blackSum, whiteSum);

    }

}