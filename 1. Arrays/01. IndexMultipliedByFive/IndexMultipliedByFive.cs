// Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
// Print the obtained array on the console.


using System;

class IndexMultipliedByFive
{
    static void Main()
    {
        int[] myArray = new int[20];

        for (int index = 0; index < myArray.Length; index++)
        {
            myArray[index] = 5 * index;
            Console.WriteLine(myArray[index]);
        }

    }
}
