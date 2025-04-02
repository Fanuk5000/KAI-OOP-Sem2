using System.Collections.Generic;


namespace FiguresApp
{
    public class Figure
    {
        private Dictionary<char, (int, int)> _cords;

        public Figure()
        {
            _cords = new Dictionary<char, (int, int)>();
        }

        public Figure(params (int, int)[] points)
        {
            _cords = points.Select((p, i) => new { Index = i, Point = p })
                           .ToDictionary(item => (char)('A' + item.Index), item => item.Point);
        }
        public Figure(Figure other)
        {
            _cords = new Dictionary<char, (int, int)>(other.GetCords());
        }

        public Dictionary<char, (int, int)> GetCords()
        {
            return new Dictionary<char, (int, int)>(_cords);
        }

        public double GetSide(char point1, char point2)
        {
            if (_cords.ContainsKey(point1) && _cords.ContainsKey(point2))
            {
                var side1 = _cords[point1];
                var side2 = _cords[point2];
                return Math.Sqrt(Math.Pow(side1.Item1 - side2.Item1, 2) + Math.Pow(side1.Item2 - side2.Item2, 2));
            }
            throw new ArgumentException("Invalid points provided");
        }
    }
}