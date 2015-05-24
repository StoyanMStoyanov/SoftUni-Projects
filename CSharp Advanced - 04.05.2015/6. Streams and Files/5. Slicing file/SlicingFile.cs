using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class SlicingFile
{
    static void Main()
    {
        string filePath = "../../IMG_20120214.jpg";
        string destinationFilePath = "../../DestinationDirectory/";
        //Console.Write("Enter pieses: ");
        //int pieses = int.Parse(Console.ReadLine()) - 1;
        int pieses = 5;
        Slice(filePath, destinationFilePath, pieses);
        List<string> files = new List<string>() {
            "Part-0.jpg", 
            "Part-1.jpg", 
            "Part-2.jpg", 
            "Part-3.jpg", 
            "Part-4.jpg"
        };
        Assemble(files, destinationFilePath);
    }

    private static void Assemble(List<string> files, string destinationFilePath)
    {
        string pathName = string.Format("{0}file1.jpg", destinationFilePath);
        using (var source = new FileStream(pathName, FileMode.Create))
        {
            foreach (var item in files)
            {
                byte[] readFromFile = new byte[256000];
                using (var tempSource = new FileStream(destinationFilePath + item, FileMode.Open))
                {
                    int readFile = tempSource.Read(readFromFile, 0, readFromFile.Length);
                    while (readFile != 0)
                    {
                        source.Write(readFromFile, 0, readFile);
                        readFile = tempSource.Read(readFromFile, 0, readFile);
                    }
                }
            }
        }
    }
    private static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        string fileExtension = Regex.Match(sourceFile, @"(?<=\.)\w+\b").ToString();
        int index = 0;
        if (!Directory.Exists(destinationDirectory))
            Directory.CreateDirectory(destinationDirectory);
        using (var source = new FileStream(sourceFile, FileMode.Open))
        {
            byte[] buffer = new byte[source.Length / (parts - 1)];
            while (true)
            {
                int read = source.Read(buffer, 0, buffer.Length);
                if (read == 0) break;
                string tempFileName = string.Format("{0}Part-{1}.{2}", destinationDirectory, index, fileExtension);
                using (var destination = new FileStream(tempFileName, FileMode.Create))
                {
                    destination.Write(buffer, 0, read);
                }
                index++;
            }
       
        }
    }
}