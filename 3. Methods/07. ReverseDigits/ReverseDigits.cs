//Write a method that reverses the digits of given decimal number. Example: 256 -> 652

using System;

class ReverseDigits
{
    static string Reverse(decimal n)
    {
        string reversedNumber = n.ToString();
        char[] charArray = reversedNumber.ToCharArray();
        Array.Reverse(charArray);

        return string.Join("", charArray);
        
    }
    static void Main()
    {
        Console.Write("Enter an integer: ");
        decimal n = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Reversed number: {0}", Reverse(n));
    }
}

