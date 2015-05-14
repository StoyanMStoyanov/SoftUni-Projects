using System;
using System.Collections.Generic;
using System.Linq;

class GenericArraySort
{
    static void Main()
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, -1 };
        string[] str = { "zaz", "cba", "baa", "azis" };
        DateTime[] dates = 
        {
            new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1)
        };
        SortArray(numbers);
        SortArray(str);
        SortArray(dates);
        //Array.Sort(str, ((a, b) => a.CompareTo(b)));
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine(string.Join(", ", str));
        Console.WriteLine(string.Join("; ", dates));
    }

    private static void SortArray(DateTime[] date)
    {
        for (int i = date.Length - 1; i >= 0; i--)
        {
            DateTime temp = date[i];
            int position = i;
            for (int j = 0; j < i; j++)
                if (date[position] < date[j]) position = j;
            
            date[i] = date[position];
            date[position] = temp;
        }
    }
    private static void SortArray(string[] str)
    {
        for (int i = str.Length - 1; i >= 0; i--)
        {
            string temp = str[i];
            int position = i;
            for (int j = 0; j < i; j++)
                if (string.Compare(str[position], str[j]) < 0) position = j;
            str[i] = str[position];
            str[position] = temp;
        }
    }
    private static void SortArray(int[] numbers)
    {
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            int temp = numbers[i];
            int position = i;
            for (int j = 0; j < i; j++)
                if (numbers[position] < numbers[j]) position = j;            
            numbers[i] = numbers[position];
            numbers[position] = temp;
        }
    }
}
