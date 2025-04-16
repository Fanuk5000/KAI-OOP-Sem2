namespace LineApp
{
    public class Symbols : Line
    {
        private readonly string _line;

        public Symbols()
        {
            _line = string.Empty;
        }

        public Symbols(string line)
        {
            _line = line;
        }

        public Symbols(Symbols other) : base()
        {
            _line = other.GetSymbols();
        }

        public override int GetLen(string line)
        {
            return base.GetLen(_line);
        }

        public override int GetSymbolAmount(string line, char symbol = '*')
        {
            return base.GetSymbolAmount(_line, symbol);
        }

        public string GetSymbols()
        {
            return _line.ToUpper();
        }

        public override string ToString()
        {
            return $"Symbols: {_line}, Length: {GetLen(_line)}, Amount of '*': {GetSymbolAmount(_line)}";
        }
    }
}