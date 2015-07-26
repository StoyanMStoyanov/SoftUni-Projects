using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

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
        string arrowPattern = @"(>----->)|(>>----->)|(>>>----->>)";
        Regex match = new Regex(arrowPattern);
        MatchCollection matches = match.Matches (sb.ToString());
        int smallArrow = 0;
        //var small = matches[2].Groups.Count;
        //Console.WriteLine( small);
        int mediumArrow = 0;
        int largeArrow = 0;
        foreach (var item in matches)
        {
            if (item.ToString() == ">----->") smallArrow++;
            else if (item.ToString() ==">>----->") mediumArrow++;
            else largeArrow++;            
        }
        StringBuilder intValue = new StringBuilder();
        intValue.Append(smallArrow);
        intValue.Append(mediumArrow);
        intValue.Append(largeArrow);
        
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
