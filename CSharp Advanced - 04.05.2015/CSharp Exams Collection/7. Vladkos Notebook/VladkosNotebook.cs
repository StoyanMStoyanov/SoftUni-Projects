using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class VladkosNotebook
{
    public class Player
    {
        public Player()
        {
            this.Name = string.Empty;
            this.Age = -1;
            this.Opponents = new List<string>();
            this.Win = 0;
            this.Loss = 0;            
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Opponents { get; set; }
        public double Rank
        {
            get
            {
                return (this.Win + 1.0) / (this.Loss + 1);
            }
        }
        public int Win { get; set; }
        public int Loss { get; set; }

        public override string ToString()
        {
            StringBuilder outputText = new StringBuilder();
            
                outputText.AppendLine(string.Format("-age: {0}", this.Age));           
                outputText.AppendLine(string.Format("-name: {0}", this.Name));            
            var sortedOpponents = this.Opponents.OrderBy(o => o, StringComparer.Ordinal);
            outputText.AppendLine(string.Format("-opponents: {0}", 
                this.Opponents.Count == 0 ? "(empty)" : string.Join(", ", sortedOpponents)));
            outputText.AppendLine(string.Format("-rank: {0:f2}", this.Rank));
            return outputText.ToString();
        }
    }
    static void Main()
    {
        Dictionary<string, Player> notebook = new Dictionary<string, Player>();
        var inputData = Console.ReadLine().Split('|');
        while (true)
        {
            if (inputData[0] == "end" || inputData[0] == "END") break;
            string pageColor = inputData[0];
            string command = inputData[1];
            string value = inputData[2];
            ExecuteCommand(pageColor, command, value, notebook);
            inputData = Console.ReadLine().Split('|');
        }
        bool isData = false;
        foreach (var page in notebook.OrderBy(c => c.Key))
        {            
            if (page.Value.Name == string.Empty) continue;
            if (page.Value.Age == -1) continue;
            Console.WriteLine("Color: {0}", page.Key);
            Console.Write(page.Value.ToString());
            isData = true;
        }
        if(!isData)
            Console.WriteLine("No data recovered.");
    }

    private static void ExecuteCommand(string pageColor, string command, string value, 
        Dictionary<string, Player> notebook)
    {
        switch (command)
        {
            case "name":
                if (notebook.ContainsKey(pageColor))
                {
                    notebook[pageColor].Name = value;
                }
                else
                {
                    notebook.Add(pageColor, new Player());
                    notebook[pageColor].Name = value;
                }
                break;
            case "age":
                if (notebook.ContainsKey(pageColor))
                {
                    notebook[pageColor].Age = int.Parse(value);
                }
                else
                {
                    notebook.Add(pageColor, new Player());
                    notebook[pageColor].Age = int.Parse(value);
                }
                break;
            case "win":
                if (notebook.ContainsKey(pageColor))
                {
                    notebook[pageColor].Win++;
                    notebook[pageColor].Opponents.Add(value); 
                }
                else
                {
                    notebook.Add(pageColor, new Player());
                    notebook[pageColor].Win = 1;
                    notebook[pageColor].Opponents.Add(value);
                }
                break;
            case "loss":
                if (notebook.ContainsKey(pageColor))
                {
                    notebook[pageColor].Loss++;
                    notebook[pageColor].Opponents.Add(value);
                }
                else
                {
                    notebook.Add(pageColor, new Player());
                    notebook[pageColor].Loss = 1;
                    notebook[pageColor].Opponents.Add(value);
                }
                break;
            default:
                Console.WriteLine("This is not command.");
                break;
        }
    }
       
}
