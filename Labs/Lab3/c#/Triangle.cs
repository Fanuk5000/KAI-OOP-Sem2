using System;

namespace TriangleApp
{
    class Triangle
    {
        private double x;
        private double y;

        public Triangle()
        {
            this.x = 0;
            this.y = 0;
        }
        public Triangle(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Triangle(Triangle other)//for copy
        {
            this.x = other.x;
            this.y = other.y;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public static Triangle operator +(Triangle a, Triangle b)
        {
            return new Triangle(a.X + b.X, a.Y + b.Y);
        }

        public static Triangle operator +(Triangle a, int value)
        {
            return new Triangle(a.X + value, a.Y + value);
        }

        public static Triangle operator *(Triangle a, Triangle b)
        {
            return new Triangle(a.X * b.X, a.Y * b.Y);
        }

        public static Triangle operator *(Triangle a, int value)
        {
            return new Triangle(a.X * value, a.Y * value);
        }

        private static (double, double, double) CalculateSides(Triangle a, Triangle b, Triangle c)
        {
            double side_ab = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
            double side_ac = Math.Sqrt(Math.Pow(a.X - c.X, 2) + Math.Pow(a.Y - c.Y, 2));
            double side_bc = Math.Sqrt(Math.Pow(b.X - c.X, 2) + Math.Pow(b.Y - c.Y, 2));

            return (side_ab, side_ac, side_bc);
        }

        public static double calculate_perimetr(Triangle a, Triangle b, Triangle c)
        {
            (double side_ab, double side_ac, double side_bc) = Triangle.CalculateSides(a, b, c);

            return Math.Round(side_ab + side_ac + side_bc, 2);
        }

        public static double calculate_area(Triangle a, Triangle b, Triangle c)
        {
            (double side_ab, double side_ac, double side_bc) = Triangle.CalculateSides(a, b, c);

            double p = Math.Round(side_ab + side_ac + side_bc, 2) / 2;
            double s = Math.Round(Math.Sqrt(p * (p - side_ab) * (p - side_ac) * (p - side_bc)), 2);

            return s;
        }
    }
}