using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{

    public struct Date
    {
        public readonly int Day;
        public readonly int Month;
        public readonly int Year;

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public Date AddDays(int daysToAdd)
        {
            DateTime dt = new DateTime(Year, Month, Day);
            dt = dt.AddDays(daysToAdd);
            return new Date(dt.Day, dt.Month, dt.Year);
        }

        public Date AddMonths(int monthsToAdd)
        {
            DateTime dt = new DateTime(Year, Month, Day);
            dt = dt.AddMonths(monthsToAdd);
            return new Date(dt.Day, dt.Month, dt.Year);
        }

        public Date AddYears(int yearsToAdd)
        {
            DateTime dt = new DateTime(Year, Month, Day);
            dt = dt.AddYears(yearsToAdd);
            return new Date(dt.Day, dt.Month, dt.Year);
        }

        public override string ToString()
        {
            return $"{Day:D2}.{Month:D2}.{Year}";
        }
    }

    public class Example
    {
        public static void Main(string[] args)
        {
            Date today = new Date(15, 10, 2024);
            Console.WriteLine($"Текущая дата: {today}");

            Date tomorrow = today.AddDays(1);
            Console.WriteLine($"Завтра: {tomorrow}");

            Date nextMonth = today.AddMonths(1);
            Console.WriteLine($"Следующий месяц: {nextMonth}");

            Date nextYear = today.AddYears(1);
            Console.WriteLine($"Следующий год: {nextYear}");


            Console.WriteLine($"\nТекущая дата после вызова методов: {today}");
        }
    }
}
