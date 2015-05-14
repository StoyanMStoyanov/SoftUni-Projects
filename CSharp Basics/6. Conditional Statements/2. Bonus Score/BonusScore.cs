using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter score in range [1...9]: ");
        int score = int.Parse(Console.ReadLine());
        if (score > 0 && score <= 3) Console.WriteLine("Bonus Score is: {0}.", score *= 10);
        else if (score > 3 && score <= 6) Console.WriteLine("Bonus Score is: {0}.", score *= 100);
        else if (score > 6 && score <= 9) Console.WriteLine("Bonus Score is: {0}.", score *= 1000);
        else Console.WriteLine("invalid score");
    }
}
