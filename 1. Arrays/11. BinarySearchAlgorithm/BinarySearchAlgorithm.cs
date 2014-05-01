//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).


using System;

class BinarySearchAlgorithm
{
    static void Main()
    {
        int[] arr = { 0, 4, 7, 9, 13, 15, 17, 19, 20, 21, 92 };
        int search = int.Parse(Console.ReadLine());
        int startSearch = 0;
        int endSearch = arr.Length - 1;
        int middle;
        while (startSearch <= endSearch)
        {
            middle = (startSearch + endSearch) / 2;
            if (arr[middle] == search)
            {
                Console.WriteLine("We find the number {0} on index {1}", search, middle);
                break;

            }

            if (arr[middle] > search)
            {
                endSearch = middle - 1;
            }

            else if (arr[middle] < search)
            {
                startSearch = middle + 1;
            }
        }
    }
}
