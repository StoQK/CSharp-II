//Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;

namespace _05.NumberOfWorkDays
{
    class NumberOfWorkDays
    {
        static int GetWorkDays(string date)
        {
            string[] futureDateStr = date.Split('.');
            int day = int.Parse(futureDateStr[0]);
            int month = int.Parse(futureDateStr[1]);
            int year = int.Parse(futureDateStr[2]);

            DateTime today = DateTime.Today;
            DateTime future = new DateTime(year, month, day);
            int timeLen = Math.Abs((future - today).Days);

            if (today > future)
            {
                today = future;
                future = DateTime.Today;
            }

            DateTime[] holidays = { new DateTime(2014, 1,1),
                                    new DateTime(2014, 3, 3),
                                    new DateTime(2014, 9, 6),
                                    new DateTime(2014, 11, 1),
                                    new DateTime(2014, 12, 24),
                                    new DateTime(2014, 12, 25)};

            int workDayCounter = 0;
            bool isHoliday = false;
            for (int i = 0; i < timeLen; i++)
            {
                today = today.AddDays(1);
                if (today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday)
                {
                    for (int j = 0; j < holidays.Length; j++)
                    {
                        if (today == holidays[j])
                        {
                            isHoliday = true;
                            break;
                        }
                    }

                    if (!isHoliday)
                    {
                        workDayCounter++;
                    }

                    isHoliday = false;
                }
            }
            return workDayCounter;

        }
        static void Main()
        {
            Console.Write("Please enter a date in the format DD.MM.YYYY: ");
            string userDateInput = Console.ReadLine();
            Console.WriteLine("Working days left from today until {0}: {1}", userDateInput, GetWorkDays(userDateInput));
        }
    }
}
