//Write a program that finds the maximal increasing sequence in an array.
//Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.


using System;

class MaxIncreasingSequence
{
    static void Main()
    {
        int[] myArray = { 1, 1, 1, 1, 1, 1, 2, 3, 4, 5, 5, 5, 6, 9, 9, 9, 9, 7, 8 };
        int len = 1;
        int bestLen = 1;
        int start = 0;
        int newStart = 0;
        for (int index = 0; index < myArray.Length - 1; index++)
        {
            if (myArray[index] < myArray[index + 1])
            {
                len++;

                if (len > bestLen)
                {
                    bestLen = len;
                    newStart = start;
                }
            }
            else
            {
                len = 1;
                start = index + 1;
            }
        }
        Console.WriteLine("The best sequence will be: ");
        for (int i = newStart; i < newStart + bestLen; i++)
        {
            Console.Write(myArray[i]);
        }
        Console.WriteLine();
    }
}
