using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class PopulationCounter
{
    static void Main()
    {
#if DEBUG
        var file = new StreamReader("..\\..\\04. Population Counter_Нулеви тестове\\test.000.002.in.txt");
        Console.SetIn(file);
#endif
        string inputString = Regex.Replace(Console.ReadLine(), @"\s{2,}", " ").Trim();

        var countries = new Dictionary<string, Dictionary<string, int>>();
        


        while (inputString != "report")
        {            
            var inputData = inputString.Split('|');
            string country = inputData[1].Trim();
            string town = inputData[0];
            int population = int.Parse(inputData[2]);
            AddData(country, town, population, countries);
            inputString = Regex.Replace(Console.ReadLine(), @"\s{2,}", " ").Trim();
        }
        Dictionary<string, long> sortedPopulation = new Dictionary<string, long>();
        foreach (var con in countries)
        {
            var temp = con.Value;
            long count = 0;
            foreach (var town in temp)
            {
                count += town.Value;
            }
            sortedPopulation.Add(con.Key, count);
        }
        var sortedCountries = sortedPopulation.OrderByDescending(x => x.Value);
        foreach (var item in sortedCountries)
        {
            string name = item.Key;
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0} (total population: {1})\n", name, item.Value);
            var sortedTowns = countries[name].OrderByDescending(x => x.Value);
            foreach (var town in sortedTowns)
            {                
                string output = string.Format("=>{0}: {1}\n", town.Key, town.Value);
                result.Append(output);                
            }            
            Console.Write(result);
        }
    }

    private static void AddData(string country, string town, int population, 
        Dictionary<string, Dictionary<string, int>> countries)
    {
        if (countries.ContainsKey(country))
        {
            countries[country].Add(town, population);
        }
        else
        {
            countries.Add(country, new Dictionary<string, int>());
            countries[country].Add(town, population);
        }
    }
}
