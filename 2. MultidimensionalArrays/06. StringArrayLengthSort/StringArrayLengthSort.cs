//You are given an array of strings.
//Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class StringArrayLengthSort
{
    static void Main()
    {
        string[] array = { "software", "doggie", "four", "programming", "visual", "keyboard", "Levski", "alo" };

        Console.WriteLine("Unsorted array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("{0} ", array[i]);
        }

        Console.WriteLine("\n");

        Array.Sort(array, (x, y) => (x.Length).CompareTo(y.Length));

        Console.WriteLine("Sorted array:");
        foreach (var word in array)
        {
            Console.WriteLine(word);
        }
    }
}
