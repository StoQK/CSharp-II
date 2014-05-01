// Write a program that finds in given array of integers a sequence of given sum S (if present).
// Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}

using System;

class FindSequenceOfGivenSum
{
    static void Main()
    {
        int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
        int s = int.Parse(Console.ReadLine());
        int sum = 0;
        int start = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            sum += arr[i];
            start = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                sum += arr[j];
                if (sum == s)
                {
                    for (int k = start; k <= j; k++)
                    {
                        Console.Write(arr[k] + " ");
                    }
                    return;
                }

            }
            sum = 0;
        }
        Console.WriteLine("No such sum in the current array");
    }
}
