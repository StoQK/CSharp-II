//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

namespace _02.GenerateRandomNumbers
{
    class GenerateRandomNumbers
    {
        static void Main()
        {
            Random rand = new Random();
            int randomNumber;
            for (int i = 0; i < 10; i++)
            {
                randomNumber = rand.Next(100, 201);
                Console.WriteLine(randomNumber);
            }
        }
    }
}
