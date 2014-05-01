//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
//Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc

using System;

class SelectionSort
{
    static void Main()
    {
        int[] arr = { 6, 4, 767, 234, 54, 2, 1, 7 };
        int temp = 0;
        Console.Write("Origininal array: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        for (int index = 0; index < arr.Length; index++)
        {
            for (int j = index + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[index])
                {
                    temp = arr[j];
                    arr[j] = arr[index];
                    arr[index] = temp;
                }
            }
           
        }
        Console.WriteLine();
        Console.Write("Sorted array: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
