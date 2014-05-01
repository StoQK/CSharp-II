using System;

class BinaryToDecimalConversion
{
    static void Main()
    {
        string input = Console.ReadLine();
        int decimalNumber = 0;
        for (int i = 0; i < input.Length; i++)
        {
            decimalNumber = decimalNumber << 1;
            if (input[i] == '1')
            {
                decimalNumber +=1;
            }
        }
        Console.WriteLine(decimalNumber);
    }
}

