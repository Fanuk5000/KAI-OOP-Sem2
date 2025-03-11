using System;

namespace Matrix2DApp
{
    public class Matrix2D
    {
        private int[,] matrix;
        private int rows;
        private int columns;

        public Matrix2D(int[,] new_matrix)
        {
            matrix = new_matrix;
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(0);
        }

        public int this[int columnIndex]
        {
            get
            {
                if (columnIndex < 0 || columnIndex >= columns)
                {
                    Console.WriteLine("Invalid column index");
                    return 0;
                }

                int multiplication = 1;

                for (int i = 0; i < rows; i++)
                {
                    multiplication *= matrix[i, columnIndex];
                }
                return multiplication;
            }
        }
        public double AverageValue
        {
            get
            {
                int sum = 0;
                int count = rows * columns;

                foreach (int value in matrix)
                {
                    sum += value;
                }

                return (double)sum / count;
            }
        }
    }
}