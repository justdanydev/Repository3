using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task5
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
            Console.WriteLine("Введите номер дня недели (1-7):");

            while (!int.TryParse(Console.ReadLine(), out int dayNumber) || dayNumber < 1 || dayNumber > 7)
            {
                Console.WriteLine("Некорректный ввод. Попробуйте еще раз (1-7):");
            }

            DayOfWeek day;
            try
            {
                day = (DayOfWeek)(dayNumber - 1);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Не удалось преобразовать введенное число.");
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Некорректный ввод.");
                return;
            }

            Console.WriteLine($"День недели: {day}");
        }
    }

}
