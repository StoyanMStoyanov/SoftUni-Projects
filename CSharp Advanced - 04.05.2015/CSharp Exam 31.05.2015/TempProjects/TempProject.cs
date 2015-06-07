using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TempProject
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        Dictionary<string, List<string>> winners = new Dictionary<string, List<string>>();
        while (true)
        {
            string[] line = Console.ReadLine().Split('|');
            if (line[0] == "report") break;
            string[] names = line[0].Split(new string[]{" "}, StringSplitOptions.RemoveEmptyEntries);

            string name = string.Join(" ", names);
            string country = line[1].Trim();
            if (winners.ContainsKey(country))
                winners[country].Add(name);
            else
            {
                winners.Add(country, new List<string>());
                winners[country].Add(name);
            }
            
        }
        /*var sortWinners =
            from winner in winners
            orderby winner.Value.Count descending
            select winner;*/
        var sortWinners = winners.OrderByDescending(x => x.Value.Count);
        foreach (var element in sortWinners)
        {           
            Console.WriteLine("{0} ({1} participants): {2} wins", 
                element.Key, element.Value.Distinct().Count(), element.Value.Count);
        }
    }
}
