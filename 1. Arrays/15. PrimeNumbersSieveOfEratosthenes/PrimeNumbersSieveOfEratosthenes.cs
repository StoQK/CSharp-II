// Write a program that finds all prime numbers in the range [1...10 000 000].
// Use the sieve of Eratosthenes algorithm (find it in Wikipedia).


using System;

class PrimeNumbersSieveOfEratosthenes
{
    static void Main()
    {
        bool[] numbers = new bool[10000000];
        for (int i = 2; i < Math.Sqrt(numbers.Length); i++)
        {
            if (numbers[i] == false)
            {
                for (int j = i * i; j < numbers.Length; j = j + i)
                {
                    numbers[j] = true;
                }
            }
        }
        Console.WriteLine("Prime numbers: ");
        for (int i = 2; i < numbers.Length; i++)
        {
            if (numbers[i] == false)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}
