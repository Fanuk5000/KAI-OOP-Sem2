using System;
using System.Collections.Generic;
namespace FiguresApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square((0, 0), 5);
            Square square2 = new Square(square);

            Console.WriteLine($"Square area: {square.Area()}\nSquare perimeter: {square.Perimeter()}");
            Console.WriteLine($"Square area: {square2.Area()}\nSquare perimeter: {square2.Perimeter()}");

            // var cords = square.GetCords();
            // foreach (var cord in cords)
            // {
            //     Console.WriteLine($"{cord.Key}: ({cord.Value.Item1}, {cord.Value.Item2})");
            // }

            // var cords2 = square2.GetCords();
            // foreach (var cord in cords2)
            // {
            //     Console.WriteLine($"{cord.Key}: ({cord.Value.Item1}, {cord.Value.Item2})");
            // }

            // double sideLength = square.GetSide('A', 'B');
            // Console.WriteLine($"Side length between A and B: {sideLength}");
        }
    }
}