using System;
using System.IO;

class LineNumbers
{
    
    static void Main()
    {
        StreamReader reader = new StreamReader("../../OddLinesTemp.cs");
        StreamWriter writer = new StreamWriter("../../LineNumbersOddLines.txt");
        int index = 0;
        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    index++;
                    //Console.WriteLine("{0,3} {1}", index, line);
                    writer.WriteLine("{0,3} {1}", index, line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
