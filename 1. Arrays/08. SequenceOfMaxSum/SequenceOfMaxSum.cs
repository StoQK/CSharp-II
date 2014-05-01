// Write a program that finds the sequence of maximal sum in given array.
// Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}


using System;

class SequenceOfMaxSum
{
    static void Main()
    {
        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8};
        int sum = 0;
        int maxSum = arr[0];
        int startIndex = 0;
        int tempStart = 0;
        int endIndex = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            if (arr[i] > sum)
            {
                sum = arr[i];
                tempStart += 2;
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                startIndex = tempStart;
                endIndex = i;
            }
        }
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write("{0} ", arr[i]);
        }

    }
}
