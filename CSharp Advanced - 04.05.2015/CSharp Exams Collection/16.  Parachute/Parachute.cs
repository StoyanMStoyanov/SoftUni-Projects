using System;
using System.Collections.Generic;
using System.IO;

class Parachute
{
    static void Main()
    {
#if DEBUG
        var file = new StreamReader("..\\..\\16. Parachute_Тестове\\test.000.002.in.txt");
        Console.SetIn(file);
#endif
        string inputRow = Console.ReadLine();
        List<string> board = new List<string>();
        while (inputRow != "END")
        {
            board.Add(inputRow);
            inputRow = Console.ReadLine();
        }
        int jumperRow = 0;
        int jumperCol = 0;
        for (int row = 0; row < board.Count; row++)
        {
            jumperRow = row;
            jumperCol = FindJumper(board[row]);
            if (jumperCol != -1) break;
        }
        //Console.WriteLine("------{0}  {1}-------", jumperRow, jumperCol);
        char charToHit = char.MinValue;
        for (int row = jumperRow+1; row < board.Count; row++)
        {
            jumperRow = row;
            jumperCol = JumperMove(jumperCol, board[row]);
            charToHit = charJumperPosition(jumperCol, board[jumperRow]);
            if (charToHit == '~' || charToHit == '/' || charToHit == '\\') break;
            //Console.WriteLine("{0}   {1}", jumperRow, jumperCol);
        }
        string outputMessage = Finished(charToHit);
        Console.WriteLine(outputMessage);
        Console.WriteLine(jumperRow + " " + jumperCol);
    }

    private static string Finished(char charToHit)
    {
        switch (charToHit)
        {            
            case '~':
                return "Drowned in the water like a cat!";
            case '/':
            case '\\':
                return "Got smacked on the rock like a dog!";
            default:
                break;
        }
        return "Landed on the ground like a boss!";
    }

private static char charJumperPosition(int jumperCol,string p)
{
 	return p[jumperCol];
}

    private static void PrintMatrix(List<string> board)
    {
        for (int row = 0; row < board.Count; row++)
        {
            Console.WriteLine(board[row]);
        }
        Console.WriteLine();
    }

    private static int JumperMove(int jumperCol, string p)
    {
        int resultCol = jumperCol;
        for (int col = 0; col < p.Length; col++)
        {
            if (p[col] == '>')
                resultCol++;
            if (p[col] == '<')
                resultCol--;
        }
        return resultCol;
    }

    private static int FindJumper(string p)
    {
        for (int index = 0; index < p.Length; index++)
        {
            if (p[index] == 'o')
                return index;
        }
        return -1;
    }
}

