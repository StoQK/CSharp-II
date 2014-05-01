//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class GetMaxIntegers
{
    static long GetMax(long firstInteger, long secondInteger)
    {
        long max = firstInteger;
        if (secondInteger > firstInteger)
        {
            max = secondInteger;
        }
        return max;
    }
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("The biggest integer is: ");
        Console.WriteLine(GetMax(GetMax(a, b), GetMax(a, c)));
    }
}
