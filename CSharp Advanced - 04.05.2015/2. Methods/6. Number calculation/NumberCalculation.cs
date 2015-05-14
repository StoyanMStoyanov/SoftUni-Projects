using System;
using System.Collections.Generic;


class NumberCalculation
{
    static void Main()
    {
        int[] numbers = { 1, 6, 8, 2};
        decimal[] decimalNumbers = { 1254.4M, 1254789, 365.987M, 7854120.5M};
        double[] doubleNumbers = { 1254.4, 1254789, 365.987, 7854120.5 };
        
        Console.WriteLine("Integers: \nMaxInt -> {0},  MinInt  -> {1},  SumInt -> {2}\nAverageInt  -> {3},   ProductInt  -> {4}.",
           MaxValue(numbers), MinValue(numbers), SumCalculation(numbers), AverageCalculation(numbers), ProductCalculation(numbers));
        Console.WriteLine();
        Console.WriteLine("Doubles: \nMaxDouble -> {0},  MinDouble  -> {1},  SumDouble -> {2}\nAverageDouble  -> {3},   ProductDouble  -> {4}.",
           MaxValue(doubleNumbers), MinValue(doubleNumbers), SumCalculation(doubleNumbers), AverageCalculation(doubleNumbers), ProductCalculation(doubleNumbers));

        Console.WriteLine();
        Console.WriteLine("Decimals: \nMaxDecimal -> {0},  MinDecimal  -> {1},  SumDecimal -> {2}\nAverageDecimal  -> {3},   ProductDecimal  -> {4}.",
           MaxValue(decimalNumbers), MinValue(decimalNumbers), SumCalculation(decimalNumbers), AverageCalculation(decimalNumbers), ProductCalculation(decimalNumbers));


    }

    private static long ProductCalculation(int[] numbers)
    {
        long tempProduct = 1;
        foreach (var element in numbers)
            tempProduct *= element;

        return tempProduct ;
    }
    private static double ProductCalculation(double[] numbers)
    {
        double tempProduct = 1;
        foreach (var element in numbers)
            tempProduct *= element;

        return tempProduct;
    }
    private static decimal ProductCalculation(decimal[] numbers)
    {
        decimal tempProduct = 1;
        foreach (var element in numbers)
            tempProduct *= element;

        return tempProduct;
    }

    private static int MaxValue(int[] numbers)
    {
        int tempMax = int.MinValue;
        foreach (var element in numbers)
            if (element > tempMax) tempMax = element;
        return tempMax;
    }
    private static double MaxValue(double[] numbers)
    {
        double tempMax = double.MinValue;
        foreach (var element in numbers)
            if (element > tempMax) tempMax = element;
        return tempMax;
    }
    private static decimal MaxValue(decimal[] numbers)
    {
        decimal tempMax = decimal.MinValue;
        foreach (var element in numbers)
            if (element > tempMax) tempMax = element;
        return tempMax;
    }

    private static int MinValue(int[] numbers)
    {
        int tempMin = int.MaxValue;
        foreach (var element in numbers)
            if (element < tempMin) tempMin = element;
        return tempMin;
    }
    private static double MinValue(double[] numbers)
    {
        double tempMin = double.MaxValue;
        foreach (var element in numbers)
            if (element < tempMin) tempMin = element;
        return tempMin;
    }
    private static decimal MinValue(decimal[] numbers)
    {
        decimal tempMin = decimal.MaxValue;
        foreach (var element in numbers)
            if (element < tempMin) tempMin = element;
        return tempMin;
    }

    private static int AverageCalculation(int[] numbers)
    {
        int tempSum = 0;
        foreach (var element in numbers)
            tempSum += element;
        return tempSum / numbers.Length;
    }
    private static double AverageCalculation(double[] numbers)
    {
        double tempSum = 0;
        foreach (var element in numbers)
            tempSum += element;
        return tempSum / numbers.Length;
    }
    private static decimal AverageCalculation(decimal[] numbers)
    {
        decimal tempSum = 0;
        foreach (var element in numbers)
            tempSum += element;
        return tempSum / numbers.Length;
    }

    private static int SumCalculation(int[] numbers)
    {
        int tempSum = 0;
        foreach (var element in numbers)
            tempSum += element;
        return tempSum;
    }
    private static double SumCalculation(double[] numbers)
    {
        double tempSum = 0;
        foreach (var element in numbers)
            tempSum += element;
        return tempSum;
    }
    private static decimal SumCalculation(decimal[] numbers)
    {
        decimal tempSum = 0;
        foreach (var element in numbers)
            tempSum += element;
        return tempSum;
    }
}
