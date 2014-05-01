//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//        Create appropriate methods.
//        Provide a simple text-based menu for the user to choose which task to solve.
//        Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;
using System.Linq;

class SolveListOfTasks
{
    static void ReverseDigits(long number)
    {
        if (number > 0)
        {
            while (number > 0)
            {
                Console.Write(number % 10);
                number /= 10;
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive number");
        }
    }

    static int[] PopulateSequence()
    {
        Console.Write("How many integers does your sequence contain?: ");
        int sizeOfSequence = int.Parse(Console.ReadLine());
        int[] sequenceOfIntegers = new int[sizeOfSequence];
        Console.WriteLine("Enter sequence of integers: ");
        for (int i = 0; i < sizeOfSequence; i++)
        {
            Console.Write("{0}: ", i + 1);
            sequenceOfIntegers[i] = int.Parse(Console.ReadLine());
        }
        return sequenceOfIntegers; ;
    }
    
    static void AverageOfSequence(params int[] array)
    {
        decimal average = 0;
        decimal sum = 0;
        if (array.Length != 0)
        {
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            average = sum / array.Length;
            Console.WriteLine("Average = {0:F2}", average);
        }
        else
        {
            Console.WriteLine("The sequence should not be empty!");
        }
    }
    static decimal SolveLinearEquation(decimal a, decimal b)
    {
        decimal result = 0;
        if (a == 0)
        {
            Console.WriteLine("a should not be equal to zero!");
            Console.Write("a = ");
            return SolveLinearEquation(int.Parse(Console.ReadLine()),b);
        }
            
        else if (a != 0)
        {
            return result = -b / a;
        }
        else
        {
            Console.WriteLine("Invalid input");
            return -1;
        }
    }
    static void InputReverseDigits()
    {
        Console.Write("n = ");
        long n = long.Parse(Console.ReadLine());
        ReverseDigits(n);
        Console.WriteLine();
    }
    static void InputLinearEquation()
    {
        Console.Write("a = ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("b = ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.WriteLine("x = {0}", SolveLinearEquation(a, b));
    }
    static void Main()
    {
        bool flag = true;
        while (flag)
        {


            Console.WriteLine("1. Reverse the digits of a number");
            Console.WriteLine("2. Average of sequence of integers");
            Console.WriteLine("3. Solve a linear equation (a*x + b = 0)");
            Console.Write("Your choice: ");
            int choice = int.Parse(Console.ReadLine());
            
            while (choice > 3 || choice <= 0)
            {
                Console.WriteLine("Please choose one of the options above(1-3)");
                Console.Write("Your choice: ");
                choice = int.Parse(Console.ReadLine());
            }

            switch (choice)
            {
                case 1: InputReverseDigits(); break;
                case 2: AverageOfSequence(PopulateSequence()); break;
                case 3: InputLinearEquation(); break;
                default:
                    break;
            }
            Console.WriteLine("Would you like to continue? (y/n): ");
            char userInput = char.Parse(Console.ReadLine());
            if (userInput == 'y' || userInput == 'Y')
            {
                continue;
            }
            else if (userInput == 'n' || userInput == 'N')
            {
                flag = false;
            }
        }
    }
}

