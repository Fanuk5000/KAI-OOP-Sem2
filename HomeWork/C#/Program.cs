using System;

namespace Matrix2DApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            Matrix2D matrix = new Matrix2D(matrix1);

            Console.WriteLine("Product of column 1: " + matrix[1]);
            Console.WriteLine("Average value: " + matrix.AverageValue);
        }
    }
}