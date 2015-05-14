using System;
using System.Text;

class OddEvenJumps
{
    static void Main()
    {
        var inputString = Console.ReadLine().Split(' ');
        int oddStep = int.Parse(Console.ReadLine());
        int evenStep = int.Parse(Console.ReadLine());
        StringBuilder inputStr = new StringBuilder();
        foreach (var item in inputString)        
            inputStr.Append(item.ToLower());
        
        StringBuilder oddHexSum = new StringBuilder();
        StringBuilder evenHexSum = new StringBuilder();
        decimal oddSum = 0;
        decimal evenSum = 0;
        int oddCount = 1;
        int evenCount = 1;
        
        for (int index = 0; index < inputStr.Length; index++)
        {
            if (index % 2 == 0)
            {
                if (oddCount > 0 && oddCount < oddStep)
                {
                    oddSum += inputStr[index];
                    oddCount++;
                }
                else
                {
                    oddSum *= inputStr[index];
                    oddCount = 1;
                }
            }
            else
            {
                if (evenCount > 0 && evenCount < evenStep)
                {
                    evenSum += inputStr[index];
                    evenCount++;
                }
                else
                {
                    evenSum *= inputStr[index];
                    evenCount = 1;
                }
            }
        }
        string odd = string.Format("{0:x}", Convert.ToInt64(oddSum)).ToUpper();
        string even = string.Format("{0:x}", Convert.ToInt64(evenSum)).ToUpper();
        Console.WriteLine("Odd: {0}\nEven: {1}", odd, even);

        //Software University
    }
}
