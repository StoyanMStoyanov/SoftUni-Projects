using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class MatrixShuffle
{    
    static void Main()
    {
#if DEBUG
        var file = new StreamReader("..\\..\\14. Matrix Shuffle_Тестове\\test.006.in.txt");
        Console.SetIn(file);
#endif

        int matrixSize = int.Parse(Console.ReadLine());
        string inputSring = Console.ReadLine();
        var matrix = new char[matrixSize, matrixSize];
        FillMatrix(inputSring, matrix);
        //PrintMatrix(matrix);
        int startIndex = 0;
        string evenLetters = ExtractLetters(startIndex, matrix);
        startIndex = 1;
        string oddLetters = ExtractLetters(startIndex, matrix);
        //Console.WriteLine(evenLetters);
        //Console.WriteLine(oddLetters);
        string evenPlusOdd = evenLetters + oddLetters;
        Console.WriteLine(evenPlusOdd.ToLower());
        Console.WriteLine(Reverse(evenPlusOdd).ToLower());

        bool isPalindromes = checkPalindromes(evenPlusOdd.ToLower(), Reverse(evenPlusOdd.ToLower()));
        if (isPalindromes)
        {
            
            Console.WriteLine("<div style='background-color:#4FE000'>{0}</div>", evenPlusOdd);
        }
        else
        {
            Console.WriteLine("<div style='background-color:#E0000F'>{0}</div>", evenPlusOdd);
        }
    }

    private static bool checkPalindromes(string p1, string p2)
    {
        Regex regex = new Regex(@"\s+");        
        string firstString = regex.Replace(p1, "");  
        string secondString = regex.Replace(p2, "");
        
        if (firstString.Equals(secondString)) return true;
        else return false;
    }

    private static string Reverse(string evenPlusOdd)
    {
        StringBuilder reverseString = new StringBuilder();
        foreach (var element in evenPlusOdd)
        {
            reverseString.Insert(0, element);
        }
        return reverseString.ToString();
    }

    private static string ExtractLetters(int startIndex, char[,] matrix)
    {
        StringBuilder resultString = new StringBuilder();
        if (startIndex == 0)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col += 2)
                    {
                        resultString.Append(matrix[row, col]);
                    }
                }
                else
                {
                    for (int col = 1; col < matrix.GetLength(1); col += 2)
                    {
                        resultString.Append(matrix[row, col]);
                    }
                }
            }
        }
        else
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 1; col < matrix.GetLength(1); col += 2)
                    {
                        resultString.Append(matrix[row, col]);
                    }
                }
                else
                {
                    for (int col = 0; col < matrix.GetLength(1); col += 2)
                    {
                        resultString.Append(matrix[row, col]);
                    }
                }
            }
        }
        
        return resultString.ToString();
    }

    private static void PrintMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static void FillMatrix(string inputSring, char[,] matrix)
    {
        int matrixSize = matrix.GetLength(0);

        double center = (double)(1 + (double)(matrixSize - 1) / 2);

        int ring = 0, number;
        //int quadrant;

        for (int i = 1; i <= matrixSize; i++)
        {
            for (int j = 1; j <= matrixSize; j++)
            {
                ring = matrixSize / 2 - (int)Math.Max(Math.Ceiling(Math.Abs(center - i)), Math.Ceiling(Math.Abs(center - j)));
                number = 0;
                if (i == center && j == center)
                {
                    number = matrixSize * matrixSize;
                }
                else
                    if (i <= j && j <= (matrixSize - i) && i < center)
                    {
                        //quadrant = 1;
                        number = matrixSize * matrixSize - (matrixSize - 2 * ring) * (matrixSize - 2 * ring) + j - i + 1;
                    }
                    else
                        if ((matrixSize - j) < i && i <= (j - 1) && center < j)
                        {
                            //quadrant = 2;
                            number = matrixSize * matrixSize - (matrixSize - 2 * ring) * (matrixSize - 2 * ring) + j + i - 1 - 2 * ring;
                        }
                        else
                            if (center < i && (matrixSize + 2 - i) <= j && j <= i)
                            {
                                //quadrant = 3;
                                number = matrixSize * matrixSize - (matrixSize - 2 * (ring + 1)) * (matrixSize - 2 * (ring + 1)) - (matrixSize - 2 * (ring + 1)) - (j - (matrixSize - i + 1));
                            }
                            else
                                if (j < center && (j + 1) <= i && i <= (matrixSize - j + 1))
                                {
                                    //quadrant = 4;
                                    number = matrixSize * matrixSize - (matrixSize - 2 * (ring + 1)) * (matrixSize - 2 * (ring + 1)) + j - i + 1;
                                }

                if (number > inputSring.Length)
                {
                    matrix[i - 1, j - 1] = ' ';
                }
                else
                {
                    matrix[i - 1, j - 1] = inputSring[number - 1];
                }
            }            
        }

    }
}
