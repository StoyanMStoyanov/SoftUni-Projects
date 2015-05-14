using System;

class CheatSheet
{
    static void Main()
    {
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        long verticalStart = long.Parse(Console.ReadLine());
        long horizontalStart = long.Parse(Console.ReadLine());
        decimal temp = 0;

        for (decimal row = verticalStart; row < r + verticalStart; row++)
        {
            for (decimal col = horizontalStart; col < c + horizontalStart; col++)
            {
                temp = row * col;
                if (col < c + horizontalStart)
                    Console.Write(temp + " ");
                else
                    Console.Write(temp);
            } 
            Console.WriteLine();
        }
    }
}
