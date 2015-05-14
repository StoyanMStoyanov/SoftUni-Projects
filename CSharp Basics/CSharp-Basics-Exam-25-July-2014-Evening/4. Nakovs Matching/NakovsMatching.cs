using System;
using System.Text;

class NakovsMatching
{
    static void Main()
    {
        string firstStr = Console.ReadLine();
        string secondStr = Console.ReadLine();
        int limit = int.Parse(Console.ReadLine());
        bool isGoodCombination = false;
        for (int i = 1; i <= firstStr.Length - 1; i++)
        {
            string firstHalfFirst = firstStr.Substring(0, i);
            string secondHalfFirst = firstStr.Substring(i);
            for (int j = 1; j <= secondStr.Length - 1; j++)
            {
                string firstHalfSecondStr = secondStr.Substring(0, j);
                string secondHalfSecondStr = secondStr.Substring(j);

                int weight = (GetWeight(firstHalfFirst) * GetWeight(secondHalfSecondStr)) -
                    (GetWeight(secondHalfFirst) * GetWeight(firstHalfSecondStr));
                if (Math.Abs(weight) <= limit)
                {
                    Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs",
                        firstHalfFirst, secondHalfFirst,
                        secondStr.Substring(0, j), secondStr.Substring(j), Math.Abs(weight));
                    isGoodCombination = true;
                }                
            }
        }
        if (!isGoodCombination) Console.WriteLine("No");
    }   
    private static int GetWeight(string word)
    {
        int sum = 0;
        for (int index = 0; index < word.Length; index++)
            sum += (int)word[index];
        return sum;
    }
}
