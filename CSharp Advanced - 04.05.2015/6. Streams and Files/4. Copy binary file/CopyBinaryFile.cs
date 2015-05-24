using System;
using System.Collections.Generic;
using System.IO;

class CopyBinaryFile
{
    const string imagePath = "../../IMG_20120214.jpg";
    const string resultImagePath = "../../CopiedIMG.jpg";
    static void Main()
    {
        FileStream source = new FileStream(imagePath, FileMode.Open);
        FileStream destination = new FileStream(resultImagePath, FileMode.Create);
        using (source)
        {
            using (destination)
            {
                long fileLength = source.Length;
                byte[] buffer = new byte[128000];
                while (true)
                {
                    int read = source.Read(buffer, 0, buffer.Length);
                    if (read == 0) break;
                    destination.Write(buffer, 0, buffer.Length);

                    Console.WriteLine("{0:P}", Math.Min(source.Position / (double)fileLength, 1));
                }
            }
        }
    }
}
