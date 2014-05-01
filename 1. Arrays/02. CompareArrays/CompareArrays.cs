//Write a program that reads two arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter the size of the the arrays: ");
        int n = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        int[] secondArray = new int[n];

        for (int index = 0; index < firstArray.Length; index++)
        {
            Console.Write("Enter the element of the first array: ");
            firstArray[index] = int.Parse(Console.ReadLine());
        }

        for (int index = 0; index < secondArray.Length; index++)
        {
            Console.Write("Enter the element of the second array: ");
            secondArray[index] = int.Parse(Console.ReadLine());
        }

        for (int index = 0; index < firstArray.Length; index++)
        {
            if (firstArray[index] > secondArray[index])
            {
                Console.WriteLine(firstArray[index] + " > " + secondArray[index]);
            }
            else if (firstArray[index] < secondArray[index])
            {
                Console.WriteLine(firstArray[index] + " < " + secondArray[index]);
            }
            else
            {
                Console.WriteLine("{0} = {1}", firstArray[index], secondArray[index]);
            }
        }
    }
}
