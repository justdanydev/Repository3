using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public class Example
    {
        public static void Main(string[] args)
        {
            DayOfWeek today = DayOfWeek.Wednesday;

            Console.WriteLine($"Сегодня: {today}");
            Console.WriteLine($"Номер дня недели (начиная с 0): {(int)today}");


            if (today == DayOfWeek.Friday)
            {
                Console.WriteLine("Ура, пятница!");
            }

            Console.WriteLine("Все дни недели:");
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine(day);
            }

        }
    }
}
