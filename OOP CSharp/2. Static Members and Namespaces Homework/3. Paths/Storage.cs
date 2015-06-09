using System;
using System.IO;
using System.Text;

static class Storage
{
    public static void SaveToFile(string filePath, string output)
    {
        StreamWriter writer = new StreamWriter(filePath);
        using (writer)
        {
            writer.Write(output);
        }
        Console.WriteLine("The point path Saved.");
    }

    public static string ReadFromFile(string filePath)
    {
        StringBuilder temp = new StringBuilder();
        StreamReader reader = new StreamReader(filePath);
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                temp.AppendLine(line);
                line = reader.ReadLine();
            }
        }
        return temp.ToString();
    }
}

