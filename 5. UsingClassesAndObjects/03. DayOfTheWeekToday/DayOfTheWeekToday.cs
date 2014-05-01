//Write a program that prints to the console which day of the week is today. Use System.DateTime.

using System;

namespace _03.DayOfTheWeekToday
{
    class DayOfTheWeekToday
    {
        static void Main()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today.DayOfWeek);
        }
    }
}
