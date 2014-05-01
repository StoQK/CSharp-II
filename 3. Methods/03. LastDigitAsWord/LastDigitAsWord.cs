//Write a method that returns the last digit of given integer as an English word.
//Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".

using System;

class LastDigitAsWord
{
    static int GetLastDigit(int number)
    {
        int lastDigit = number % 10;
        return lastDigit;
    }

    static string GetDigitName(int number)
    {
        int lastDigit = GetLastDigit(number);
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        return digits[lastDigit];
    }

    static void Main()
    {
        Console.Write("Please enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(GetDigitName(n));
    }
}

