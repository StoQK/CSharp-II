//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Linq;

class MaximalElementInArray
{
    static int[] arrayOfIntegers = new int[11];
    static int GetMaxElement(int n, int[] array)
    {
        int biggestInt = 0;
            for (int i = n; i < array.Length; i++)
            {
                if (array[i] > biggestInt)
                {
                    biggestInt = array[i];
                }
            }
        return biggestInt;
    }
    static void GenerateRandomArray()
    {
        Random randomNumber = new Random();
        for (int i = 0; i < arrayOfIntegers.Length; i++)
        {
            arrayOfIntegers[i] = randomNumber.Next(101);
        }
    }
    static int[] SortInDescendingOrder(int[] array)
    {

        for (int i = 0; i < array.Length; i++)
        {
            int maxElementIndex = Array.IndexOf(array, GetMaxElement(i, array));
            int temp = array[maxElementIndex];
            array[maxElementIndex] = array[i];
            array[i] = temp;
        }
        return array;
    }

    static int[] SortInAscendingOrder(int[] array)
    {
        int[] sortedArray = SortInDescendingOrder(array);
        sortedArray = sortedArray.Reverse().ToArray();
        return sortedArray;
      
    }
    static void PrintArray(int[] array)
    {
        Console.WriteLine("Array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0}", array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        GenerateRandomArray();
        PrintArray(arrayOfIntegers);

        Console.Write("Enter an index(0-14): ");
        int userInput = int.Parse(Console.ReadLine());

        Console.WriteLine("The biggest integer in the array after index {0} is {1}", userInput, GetMaxElement(userInput, arrayOfIntegers));

        Console.WriteLine("Descending order: ");
        SortInDescendingOrder(arrayOfIntegers);
        PrintArray(arrayOfIntegers);
        Console.WriteLine();
    }
}
