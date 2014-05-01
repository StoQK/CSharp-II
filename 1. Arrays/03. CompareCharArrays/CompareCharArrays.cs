// Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Please enter char elements of the first array: ");
        string firstChar = Console.ReadLine();
        char[] firstArray = firstChar.ToCharArray();
        int firstArrayLength = firstArray.Length;
        Console.Write("Please enter char elements of the second array: ");
        string secondChar = Console.ReadLine();
        char[] secondArray = secondChar.ToCharArray();
        int secondArrayLength = secondArray.Length;
        bool equal = false;

        int minLen = Math.Min(firstArrayLength, secondArrayLength);

        for (int index = 0; index < minLen; index++)
        {
            equal = false;
            if (firstArray[index] < secondArray[index])
            {
                Console.WriteLine("The first array comes lexicographically before the second");
                break;
            }
            else if (secondArray[index] < firstArray[index])
            {
                Console.WriteLine("The second array comes lexicographically before the first");
                break;
            }
            else if (firstArray[index] == secondArray[index])
            {
                equal = true;
            }
        }

        if (equal && firstArrayLength < secondArrayLength)
        {
            Console.WriteLine("The first array comes lexicographically before the second");

        }
        else if (equal && firstArrayLength > secondArrayLength)
        {
            Console.WriteLine("The second array comes lexicographically before the first");
        }
        else if (equal && firstArrayLength == secondArrayLength)
        {
            Console.WriteLine("The two arrays are equal");
        }

    }
}
