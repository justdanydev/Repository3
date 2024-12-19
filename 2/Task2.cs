using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public struct Rectangle
    {
        public int width;
        public int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }

    public class Example
    {
        public static void Main(string[] args)
        {
            Rectangle rect = new Rectangle { width = 10, height = 20 };

            Console.WriteLine($"Ширина прямоугольника: {rect.width}");
            Console.WriteLine($"Высота прямоугольника: {rect.height}");
        }
    }
}
