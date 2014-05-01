//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

namespace _01.LeapYearCheck
{
    class LeapYearCheck
    {
        static void Main()
        {
            Console.Write("Enter a year: ");
            ushort year = ushort.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("The year is leap");
            }
            else
            {
                Console.WriteLine("The year is not leap");
            }
        }
    }
}