using System.Collections.Generic;
namespace FiguresApp
{
    public class Square : Figure
    {
        private int _sideLength;

        // Constructor using another Square instance
        public Square(Square other) : base(other)
        {
            _sideLength = other.GetSideLength();
        }

        // Constructor using a point and side length
        public Square((int, int) vertex, int sideLength = 0) : base(vertex, (vertex.Item1 + sideLength, vertex.Item2),
                                                                  (vertex.Item1 + sideLength, vertex.Item2 - sideLength),
                                                                  (vertex.Item1, vertex.Item2 - sideLength))
        {
            _sideLength = sideLength;
        }

        public int GetSideLength()
        {
            return _sideLength;
        }

        public int Area()
        {
            return _sideLength * _sideLength;
        }

        public int Perimeter()
        {
            return _sideLength * 4;
        }
    }
}