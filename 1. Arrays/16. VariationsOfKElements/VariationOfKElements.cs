// Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
// Example:
// N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}


using System;

class VariationOfKElements
{
    static int numberOfVariations;
    static int numberOfInterations;
    static int[] variations;

    static void Main()
    {
        Console.Write("N = ");
        numberOfInterations = int.Parse(Console.ReadLine());

        Console.Write("K = ");
        numberOfVariations = int.Parse(Console.ReadLine());

        variations = new int[numberOfVariations];

        AllVariations(0);
    }
    static void AllVariations(int currentVariation)
    {
        if (currentVariation == numberOfVariations)
        {
            PrintVariations();
            return;
        }
        for (int counter = 1; counter <= numberOfInterations; counter++)
        {
            variations[currentVariation] = counter;
            AllVariations(currentVariation + 1);
        }
    }
    static void PrintVariations()
    {
        for (int i = 0; i < numberOfVariations; i++)
        {
            Console.Write("{0} ", variations[i]);
        }
        Console.WriteLine();
    }
}

