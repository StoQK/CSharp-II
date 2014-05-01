//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.


using System;

class MaxSumKElements
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int maxSum = int.MinValue;
        int sum = 0;
        int pos = 0;

        Console.WriteLine("Fill in the array");
        for (int index = 0; index < arr.Length; index++)
        {
            Console.Write("Enter array number: ");
            arr[index] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i <= n-k; i++)
        {
            for (int j = i; j < i + k; j++)
            {
                sum += arr[j];
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                pos = i;
            }
            sum = 0;
        }
        Console.WriteLine("The maximum sequence of {0} elements in the array contains the numbers: ", k);
        for (int i = pos; i < pos + k; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
