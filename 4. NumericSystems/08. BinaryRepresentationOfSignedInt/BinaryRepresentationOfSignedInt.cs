//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class BinaryRepresentationOfSignedInt
{
    static void Main()
    {
        Console.Write("n = ");
        short number = short.Parse(Console.ReadLine());
        short temp = number;

        if (temp <= 0)
        { 
            number = (short)(number + 1);
        }

        Console.Write("Binary = ");

        for (int i = 15; i >= 0; i--)
        {
            short exponent = (short)Math.Pow(2, i);
            short digit = (short)(number / exponent);
            number = (short)(number % exponent);

            if (temp < 0)
            {
                Console.Write(1 + digit);
            }
            else
            {
                Console.Write(digit);
            }
        }
        Console.WriteLine();
    }
}
