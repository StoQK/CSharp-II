using System;
using System.Collections.Generic;

class OperationsWithAnyNumericType
{
    static T MinInteger<T>(params T[] array)
    {
        dynamic minValue = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
            }
        }
        return minValue;
    }
    static T MaxInteger<T>(params T[] array)
    {
        dynamic maxValue = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
            }
        }
        return maxValue;
    }
    static T GetAverage<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / array.Length;
    }
    static T SumIntegers<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
    static T GetProduct<T>(params T[] array)
    {
        dynamic product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }

    static void Main()
    {
        Console.WriteLine(MinInteger(10, 65d, 13, -1, 4d, 1000000000, -5645645645632356456));
        Console.WriteLine(MaxInteger(324, 1, 23, 656, 6.17, 1000.1));
        Console.WriteLine(GetAverage(2, 5.0, 12));
        Console.WriteLine(GetProduct(2, -16.17, 54, 134));


    }
}

