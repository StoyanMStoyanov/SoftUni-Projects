using System;

class Paths
{
    static void Main()
    {
        Path3D path = new Path3D();
        path.AddPoint(0, 0, 0);
        path.AddPoint(0, 5, 0);
        path.AddPoint(0, 4, 0);
        path.AddPoint(0, 3, 0);
        path.AddPoint(0, 2, 0);
        path.AddPoint(0, 1, 0);
        Console.WriteLine("Print path points.");
        Console.WriteLine(path);
        string filePath = "..\\..\\Text.txt";
        Storage.SaveToFile(filePath, path.ToString());
        Console.WriteLine("\nRead path points from file.");
        Console.WriteLine(Storage.ReadFromFile(filePath));
    }
}
