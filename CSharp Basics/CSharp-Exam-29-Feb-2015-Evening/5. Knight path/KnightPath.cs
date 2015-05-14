using System;

class KnightPath
{
    static void Main()
    {        
        int horizontal = 0;
        int vertical = 0;
        int tempHorizontal = 0;
        int tempVertical = 0;
        int[] gameBoard = new int[8];
        gameBoard[0] = 1;
        while (true)
        {
            string command = Console.ReadLine();
            tempHorizontal = horizontal;
            tempVertical = vertical;
            if (command == "stop") break;
            
            switch (command)
            {
                case "left up":
                    horizontal += 2;
                    vertical--;
                    break;
                case "left down":
                    horizontal += 2;
                    vertical++;
                    break;
                case "right up":
                    horizontal -= 2;
                    vertical--;
                    break;
                case "right down":
                    horizontal -= 2;
                    vertical++;
                    break;
                case "up left":
                    horizontal++;
                    vertical -= 2;
                    break;
                case "up right":
                    horizontal--;
                    vertical -= 2;
                    break;
                case "down left":
                    horizontal++;
                    vertical += 2;
                    break;
                case "down right":
                    horizontal--;
                    vertical += 2;
                    break;
            }

            if (horizontal > 7 || vertical > 7
                || horizontal < 0 || vertical < 0)
            {
                horizontal = tempHorizontal;
                vertical = tempVertical;
                continue;
            }
            gameBoard[vertical] ^= 1 << horizontal;
        }
        bool isEmpty = true;
        foreach (var item in gameBoard)
        {
            if (item != 0)
            {
                isEmpty = false;
                Console.WriteLine(item);
            }
        }
        if (isEmpty) Console.WriteLine("[Board is empty]");
    }
}
