using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class OlympicsAreComing
{
    static void Main()
    {
        SortedDictionary<string, int> wins = new SortedDictionary<string, int>();
        Dictionary<string, List<string>> participants = new Dictionary<string,List<string>>();
        while (true)
        {
            string line = Console.ReadLine();
            if (line == "report") break;
            var input = line.Split('|');
            string country = input[1].Trim();
            string[] separators = { " " };
            string name = input[0].Trim();
            input = name.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string aaa = string.Empty;
            if (wins.ContainsKey(country))
                wins[country]++;
            else
            {
                wins.Add(country, 1);
            }

            foreach (var item in input)
            {
                aaa += item;
            }
            if (participants.ContainsKey(country)) 
                participants[country].Add(aaa);
            else
            {
                participants.Add(country, new List<string> { aaa});
            }

            var res = wins.OrderBy(x => x.Value);
            //Console.WriteLine(input[0]+input[1]);
            

        }
        string result = string.Empty;
        List<string> result1 = new List<string>();
        var sss = participants.OrderByDescending(x => x.Value.Count);
        foreach (var item in sss)
        {
            var nnn = item.Value.ToArray();
            HashSet<string> part = new HashSet<string>();
            foreach (var name in nnn)
            {
                part.Add(name);
            }
            int partisip = part.Count;            

            Console.WriteLine("{0} ({2} participants): {1} wins", item.Key, item.Value.Count, partisip);
        }

    }
}
