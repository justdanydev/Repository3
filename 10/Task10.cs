using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    public struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Example
    {
        public static void Main(string[] args)
        {
            Point point1 = new Point(10, 20);
            Point point2 = point1;

            Console.WriteLine($"point1: x = {point1.x}, y = {point1.y}");
            Console.WriteLine($"point2: x = {point2.x}, y = {point2.y}");

            point2.x = 30;

            Console.WriteLine($"\npoint1: x = {point1.x}, y = {point1.y}");
            Console.WriteLine($"point2: x = {point2.x}, y = {point2.y}");
        }
    }
}
