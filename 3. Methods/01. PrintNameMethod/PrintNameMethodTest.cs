//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
//Write a program to test this method.

using System;
using System.Linq;
public class PrintNameMethodTest
{
    static void Main()
    {
        Console.Write("Please, enter your first name: ");
        string name = Console.ReadLine();
        PrintName(name);
    }

    public static void PrintName(string yourName)
    {
        bool isNameCorrect = (yourName.All(char.IsLetter));
        if (isNameCorrect)
        {
            Console.WriteLine("Hello, {0}!", yourName);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
        
    }
}

