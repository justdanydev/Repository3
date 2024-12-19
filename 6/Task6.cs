using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public enum Colors : byte
    {
        Red,
        Green,
        Blue
    }

    public class Example
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Размер перечисления Colors: {sizeof(Colors)} байт");


            Colors myFavoriteColor = Colors.Green;
            Console.WriteLine($"Мой любимый цвет: {myFavoriteColor}");
            Console.WriteLine($"Размер цвета в байтах: {sizeof(myFavoriteColor)}");

        }
    }
}
