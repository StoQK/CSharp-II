//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class LargestNumberInArrayBinSearch
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Number: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        Console.WriteLine("Sorted array: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();

        int index = Array.BinarySearch(array, k);

        if (index < 0)
        {
            index = ~index - 1;
            if (array[0] > k)
            {
                Console.WriteLine("No such number");
            }
            else
            {
                Console.WriteLine("Largest number <= {0}: {1}", k, array[index]);
            }
        }
        else if (index >= 0)
        {
            Console.WriteLine("Largest number <= {0}: {1}", k, array[index]);
        }
    }
}
