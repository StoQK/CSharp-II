//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

using System;

public class BiggerNeighboringIntegerCheck
{
    public static bool NeigborIntegerCheck(int n, params int[] array)
    {
        bool isBigger = false;
        if (array.Length - 1 > n && n > 0)
        {
            if (array[n] > array[n + 1] && array[n] > array[n - 1])
            {
                isBigger = true;
            }
            return isBigger;
        }

        else
        {
            //Console.WriteLine("No two neighboring numbers exist");
            return false;
        }
    }
    public static void Main()
    {
        int[] arrayOfIntegers = { 3, 2, 355, 1, 432, 56, 30, 9 };
        Console.WriteLine("Array:");
        CountNumberInArray.PrintNumbers(arrayOfIntegers);
        Console.WriteLine("\n");
        Console.Write("Enter the position of the integer you want to check for: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The number is bigger than its neighbors: {0}" , NeigborIntegerCheck(n, arrayOfIntegers));
    }
}

