using System;

class BitLock
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ');
        int[] matrix = new int[8];

        for (int row = 0; row < matrix.Length; row++)
            matrix[row] = int.Parse(numbers[row]);
        int count = 0;
        int iteration = 0;
        int tempBit = 0;

        while (true)
        {
            var commands = Console.ReadLine().Split(' ');
            if (commands[0] == "end") break;
            if (commands[0] == "check")
            {
                int col = int.Parse(commands[1]);
                int bit = 0;
                for (int row = 0; row < matrix.Length; row++)
                {
                    bit = matrix[row] & (1 << col);
                    if (bit != 0) count++;                
                }
                Console.WriteLine(count);
                count = 0;

            }
            else
            {                
                if (commands[1] == "left")
                {
                    iteration = int.Parse(commands[2]);
                    //if (iteration > 12) iteration %= 12;
                    tempBit = 0;
                    while (iteration > 0)
                    {
                        tempBit = 0;
                        int tempLastBit = 0;
                        int row = int.Parse(commands[0]);
                        for (int col = 11; col >= 0; col--)
                        {
                            if (col == 11)                            
                                tempLastBit = matrix[row] & (1 << 11);                                
                            
                            if (col == 0)
                            {
                                if (tempLastBit == 0) matrix[row] &= (~(1 << 0));
                                else matrix[row] |= 1 << 0;
                                break;
                            }
                            tempBit = matrix[row] & (1 << (col - 1));
                            if (tempBit != 0) matrix[row] |= (1 << col);
                            else matrix[row] &= (~(1 << col));
                        }
                        iteration--;
                        
                    }
                    /*foreach (var item in matrix)
                    {
                        Console.Write("{0} ", item);
                    }
                    Console.WriteLine();*/
                }
                else
                {
                    tempBit = 0;
                    iteration = int.Parse(commands[2]);
                    //if (iteration > 12) iteration %= 12;
                    int tempFirstBit = 0;
                    int row = int.Parse(commands[0]);
                    while (iteration > 0)
                    {
                        for (int col = 0; col <= 11; col++)
                        {
                            if (col == 0)
                                tempFirstBit = matrix[row] & (1 << 0);

                            if (col == 11)
                            {
                                if (tempFirstBit == 0) matrix[row] &= ~(1 << col);
                                else matrix[row] |= 1 << col;
                                break;
                            }
                            tempBit = matrix[row] & (1 << col + 1);
                            if (tempBit != 0) matrix[row] |= (1 << col);
                            else matrix[row] &= ~(1 << col);
                        }
                        iteration--;
                        
                    }
                    /*foreach (var item in matrix)
                    {
                        Console.Write("{0} ", item);
                    }
                    Console.WriteLine();*/
                }
            }
        }
        foreach (var number in matrix)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
    }
}
