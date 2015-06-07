using System;
using System.Text;
using System.Collections.Generic;

class Program
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
    }
}
