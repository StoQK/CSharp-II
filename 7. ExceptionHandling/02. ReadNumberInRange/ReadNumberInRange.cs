//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception. 
//Using this method write a program that enters 10 numbers:
//a1, a2, … a10, such that 1 < a1 < … < a10 < 100
using System;

namespace _02.ReadNumberInRange
{
    class ReadNumberInRange
    {
        static int ReadNumber(int start, int end)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < start || n > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            return n;
        }

        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {

                try
                {
                    ReadNumber(1, 100);
                }
                catch (FormatException)
                {
                    Console.Error.WriteLine("Invalid number!");
                }
                catch(ArgumentOutOfRangeException)
                {
                    Console.Error.WriteLine("The number should be in the range [1..100]");
                }
            }
        }
    }
}
