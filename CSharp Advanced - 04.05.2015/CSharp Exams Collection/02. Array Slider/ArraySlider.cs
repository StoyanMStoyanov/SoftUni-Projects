using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;

class ArraySlider
{
    static void Main()
    {
#if DEBUG
        var file = new StreamReader("..\\..\\02. Array Slider_Нулеви тестове\\test.000.001.in.txt");
        Console.SetIn(file);
#endif
        string inputString = Regex.Replace(Console.ReadLine(), @"\s{2,}", " ").Trim();
        var inputData = inputString.Split();
        int[] collection = new int[inputData.Length];
        for (int i = 0; i < collection.Length; i++)
        {
            collection[i] = int.Parse(inputData[i]);
        }
        //Console.WriteLine(string.Join(", ", collection));
        inputString = Regex.Replace(Console.ReadLine(), @"\s{2,}", " ").Trim();
        int currentPosition = 0;
        while (inputString != "stop")
        {
            currentPosition = ManipulateCollection(currentPosition, inputString, collection);
            inputString = Regex.Replace(Console.ReadLine(), @"\s{2,}", " ").Trim();
            //Console.WriteLine("[" + string.Join(", ", collection) + "]" + "      " + currentPosition);
        }

        Console.WriteLine("[" + string.Join(", ", collection) + "]");
    }

    private static int ManipulateCollection(int currentPosition, string inputString, int[] collection)
    {
        int position = currentPosition;
        var commandArgs = inputString.Split();
        int offset = int.Parse(commandArgs[0]);
        char command = commandArgs[1][0];
        int value = int.Parse(commandArgs[2]);
        int pos = offset % collection.Length;
        position += pos;
        if (position >= collection.Length)
        {
            pos = position + collection.Length;
            position = pos % collection.Length;
        }
        if (position < 0)
        {
            pos = position + collection.Length;
            position = collection.Length - pos;
        }
        ExecuteCommand(position, command, value, collection);
        return position; 
    }

    private static void ExecuteCommand(int position, char command, int value, int[] collection)
    {
        switch (command)
        {
            case '&':
                collection[position] &= value;
                break;
            case '|':
                collection[position] |= value;
                break;
            case '^':
                collection[position] ^= value;
                break;
            case '+':
                collection[position] += value;
                break;
            case '–':
                collection[position] -= value;
                break;
            case '*':
                collection[position] *= value;
                break;
            case '/':
                collection[position] /= value;
                break;
            default:
                collection[position] -= value;
                break;
        }
        if (collection[position] < 0) collection[position] = 0;
        //Console.WriteLine(command);
    }
}
