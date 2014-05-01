//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;

class OperationsWithIntegers
{
    static int MinInteger(params int[] array)
    {
        int minValue = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
            }
        }
        return minValue;
    }
    static int MaxInteger(params int[] array)
    {
        int maxValue = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
            }
        }
        return maxValue;
    }
    static decimal GetAverage(params int[] array)
    {
        decimal sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / array.Length;
    }
    static decimal SumIntegers(params int[] array)
    {
        decimal sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
    static decimal GetProductOfIntegers(params int[] array)
    {
        decimal product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }

    static void Main()
    {
        Console.WriteLine("Max integer: {0}", MaxInteger(4, -5, 6, 8, -12, 1, 13, 2, 18));
        Console.WriteLine("Min integer: {0}", MinInteger(2, 8, -13, 6, 7));
        Console.WriteLine("Average: {0}", GetAverage(6, 123,61));
        Console.WriteLine("Sum: {0}", SumIntegers(55, 23, 1, 78));
        Console.WriteLine("Product: {0}", GetProductOfIntegers(2, 4, 3, 7, 9, 16));
        Console.WriteLine();

        Console.WriteLine("Max integer: {0}", MaxInteger(435, 2, -124, 4, 67));
        Console.WriteLine("Min integer: {0}", MinInteger(4, 3, 765, 3, 4, 6, 0, -3, 324));
        Console.WriteLine("Average: {0}", GetAverage(6, 4, 2, 129, 54));
        Console.WriteLine("Sum: {0}", SumIntegers(5, 213, 10, 78, 23));
        Console.WriteLine("Product: {0}", GetProductOfIntegers(2, 1, -9, 12));
    }
}

