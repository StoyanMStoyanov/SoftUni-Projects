using System;

class FirstLargerThanNeighbors
{
    static void Main()
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5};
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceThree = { 1, 1, 1 };
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbors(sequenceOne));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbors(sequenceTwo));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbors(sequenceThree));
    }

    private static string GetIndexOfFirstElementLargerThanNeighbors(int[] sequence)
    {
        int temp = -1;
        int count = 0;
        if (sequence[0] > sequence[1]) temp = 0;
        for (int i = 1; i < sequence.Length-1; i++)
        {
            if (sequence[i] > sequence[i - 1] && sequence[i] > sequence[i + 1])
            {
                temp = i;
                count++;
            }
        }
        int last = sequence.Length - 1;
        if (sequence[last] > sequence[last - 1] && count == 0) temp = last;
        return temp.ToString();
    }
}
