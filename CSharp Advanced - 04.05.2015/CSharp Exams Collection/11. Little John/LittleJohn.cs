using System;
using System.Text;
using System.Text.RegularExpressions;

class LittleJohn
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        while (true)
        {
            string line = Console.ReadLine();
            if (line == "end" | line == "END" | line == "End") break;
            sb.AppendLine(line);

        }
        //int index = sb.ToString().IndexOf(">----->");
        string arrowPattern = @"(>----->)|(>>----->)|(>>>----->>)";
        Regex ma = new Regex(arrowPattern);
        MatchCollection matches = ma.Matches (sb.ToString());
        int smallArrow = 0;
        int mediumArrow = 0;
        int largeArrow = 0;
        foreach (var item in matches)
        {
            if (item.ToString() == ">----->") smallArrow++;
            else if (item.ToString() ==">>----->") mediumArrow++;
            else largeArrow++;
            //Console.WriteLine(item);
        }
        StringBuilder intValue = new StringBuilder();
        intValue.Append(smallArrow);
        intValue.Append(mediumArrow);
        intValue.Append(largeArrow);
        //Console.WriteLine(intValue);
        string binaryValue = Convert.ToString(int.Parse(intValue.ToString()), 2);
        string rewBinaryValue = Reverse(binaryValue);
        Console.WriteLine(Convert.ToInt32(binaryValue+rewBinaryValue, 2));
        
    }

    private static string Reverse(string binaryValue)
    {
        StringBuilder temp = new StringBuilder(binaryValue.Length);
        foreach (var item in binaryValue)        
           temp.Insert(0, item);
        return temp.ToString();
        
    }
}
