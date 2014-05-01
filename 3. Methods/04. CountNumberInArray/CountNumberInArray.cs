//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is working correctly.

using System;

public class CountNumberInArray
{
    public static int[] arrayOfNumbers = { 1, 7, 3, 2, 7, 7, -1, 3, 3, 3, 21, 765, 21 };
    public static int NumberCount(int n, params int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (n == array[i])
            {
                count++;
            }
        }
        return count;
    }
    public static void PrintNumbers(params int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0}", array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Array: ");
        PrintNumbers(arrayOfNumbers);
        Console.WriteLine("\n");
        Console.Write("Enter an integer you would like to search for: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} appears {1} time(s) in the given array", n, NumberCount(n, arrayOfNumbers));

    }
}