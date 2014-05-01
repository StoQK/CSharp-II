//Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.


using System;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        int[] myArray = { 1, 1, 2, 3, 1, 1, 2, 3, 4, 5, 5, 5, 6, 9,8, 9, 9, 9, 7, 8 };
        int len = 1;
        int bestLen = 1;
        int bestNum = 0;
        for (int index = 0; index < myArray.Length - 1; index++)
        {
            if (myArray[index] == myArray[index + 1])
            {
                len++;

                if (len > bestLen)
                {
                    bestLen = len;
                    bestNum = myArray[index];
                }
            }
            else
            {
                len = 1;
            }
        }
        Console.WriteLine("The best sequence will be: ");
        for (int i = 0; i < bestLen; i++)
        {
            Console.Write("{0} ", bestNum);
        }
        Console.WriteLine();
    }
}
