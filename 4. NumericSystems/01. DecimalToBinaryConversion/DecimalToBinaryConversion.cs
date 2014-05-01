//Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;

class DecimalToBinaryConversion
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        List<int> binary = new List<int>();
        
        while (n > 0)
        {
            binary.Add(n % 2);
            n /= 2;
        }
        Console.Write("Binary representation: ");
        for (int i = binary.Count - 1; i >= 0; i--)
        {
            Console.Write("{0}", binary[i]);
        }
        Console.WriteLine();
    }
}
