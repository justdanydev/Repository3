using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public struct Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Example
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(10.5, 20.7);


            Console.WriteLine($"Координаты точки: x = {p1.x}, y = {p1.y}");
        }
    }
}