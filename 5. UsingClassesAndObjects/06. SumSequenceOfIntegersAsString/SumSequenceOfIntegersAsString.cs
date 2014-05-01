//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
//Example: string = "43 68 9 23 318" -> result = 461
		
using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SumSequenceOfIntegersAsString
{
    class SumSequenceOfIntegersAsString
    {
        static int SumSequenceOfIntegers (string inputOfIntegers)
        {
            string[] split = inputOfIntegers.Split(' ');
            int splitLen = split.Length;
            List<int> sequence = new List<int>();

            for (int i = 0; i < splitLen; i++)
            {
                sequence.Add(int.Parse(split[i]));
            }

            int sum = sequence.Take(splitLen).Sum();
            return sum;
        }
        static void Main()
        {
            Console.Write("Input integers separated with a blank space: ");
            string input = Console.ReadLine();
            Console.Write("Their sum is: {0}", SumSequenceOfIntegers(input));
            Console.WriteLine();
        }
    }
}
