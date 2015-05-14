using System;
using System.Collections.Generic;

class FillMatrixPatternA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int temp = 0;
        for (int row = 0; row < n; row++)
        {
            temp = row +1;
            for (int col = 1; col <= n; col++)
            {
                Console.Write("{0,4}", temp);
                temp += n;
            }
            Console.WriteLine();
           
        }
    }
}
