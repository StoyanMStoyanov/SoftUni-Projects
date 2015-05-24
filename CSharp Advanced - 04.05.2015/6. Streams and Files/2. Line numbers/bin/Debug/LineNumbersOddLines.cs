using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../Simple.txt");
        int index = 0;
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                index++;
                if (index % 2 != 0)
                    Console.WriteLine("{0}. {1}", index, line);
                line = reader.ReadLine();                
            }
        }
        Console.WriteLine();
    }
}
