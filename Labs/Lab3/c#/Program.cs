using System;

namespace TriangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(0, 5);
            Triangle t2 = new Triangle(-3, -2);
            Triangle t3 = new Triangle(8, 3);

            t3 = t3 * 2;
            t1 = t2 + t3;

            Console.WriteLine($"t1: {t1.X}, {t1.Y}");
            Console.WriteLine($"t2: {t2.X}, {t2.Y}");
            Console.WriteLine($"t3: {t3.X}, {t3.Y}");

            Console.WriteLine($"Perimeter: {Triangle.calculate_perimetr(t1, t2, t3)}");
            Console.WriteLine($"Area: {Triangle.calculate_area(t1, t2, t3)}");
        }
    }
}