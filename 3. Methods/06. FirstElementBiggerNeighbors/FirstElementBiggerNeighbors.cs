// Write a method that returns the index of the first element in array that is bigger than its neighbors,
// or -1, if there’s no such element.
// Use the method from the previous exercise.

using System;

class FirstElementBiggerNeighbors
{
    static int[] arrayOfIntegers = new int[10];
    static void generateRandomArray()
    {
        Random randomNumber = new Random();
        for (int i = 0; i < arrayOfIntegers.Length; i++)
        {
            arrayOfIntegers[i] = randomNumber.Next(11);
        }
    }
    public static void PrintNumbers(params int[] array)
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
        Console.WriteLine("\n");
    }
    
    static int GetIndexOfBiggerInteger(params int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (BiggerNeighboringIntegerCheck.NeigborIntegerCheck(i, array))
            {
                return i;
            }
        }
        return -1;
    }
    static void Main()
    {
        generateRandomArray();
        PrintNumbers(arrayOfIntegers);
        Console.WriteLine(GetIndexOfBiggerInteger(arrayOfIntegers));
    }
}

