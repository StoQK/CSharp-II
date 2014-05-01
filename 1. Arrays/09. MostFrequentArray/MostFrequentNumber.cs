// Write a program that finds the most frequent number in an array.
// Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)


using System;

class MostFrequentNumber
{
    static void Main()
    {
        int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3,};
        int count = 1;
        int maxCounter = 1;
        int mostFrequent = 0;
        for (int index = 0; index < arr.Length - 1; index++)
        {
            count = 1;
            for (int j = index + 1; j < arr.Length; j++)
            {
                if (arr[index] == arr[j])
                {
                    count++;
                }
            }
            if (count > maxCounter)
            {
                maxCounter = count;
                mostFrequent = arr[index];
            }

        }
        if (maxCounter > 1)
        {
            Console.WriteLine("The most frequently appearing number is {0}.", mostFrequent);
            Console.WriteLine("It appears {0} times in the array", maxCounter);
        }
        else
        {
            Console.WriteLine("No number is seen more than once");
        }
    }
}
