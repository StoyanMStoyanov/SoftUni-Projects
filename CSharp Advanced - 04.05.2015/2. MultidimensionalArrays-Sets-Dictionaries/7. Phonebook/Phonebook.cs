using System;
using System.Collections.Generic;

class Phonebook
{
    static void Main()
    {
        Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();
        string[] separators = {" ", "-" };
        while (true)
        {
            string[] contacts = Console.ReadLine().Split(separators, 
                StringSplitOptions.RemoveEmptyEntries);
            if (contacts[0] == "Search" || contacts[0] == "search") break;
            if (phonebook.ContainsKey(contacts[0]))
                phonebook[contacts[0]].Add(contacts[1]);
            else
            {
                phonebook.Add(contacts[0], new List<string>());
                phonebook[contacts[0]].Add(contacts[1]);
            }
        }

        while(true)
        {
            string input = Console.ReadLine();
            if (input == "end" || input == "End" || input == "") break;
            if(phonebook.ContainsKey(input))
                foreach (var element in phonebook[input])
                    Console.WriteLine("{0} -> {1}", input, element);
            else 
                Console.WriteLine("Contact {0} does not exist.", input);
        }
    }
}
