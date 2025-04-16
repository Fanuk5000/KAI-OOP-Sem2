namespace LineApp
{
    public class BigLetters : Line
    {
        private readonly string _line;

        public BigLetters()
        {
            _line = string.Empty;
        }
        public BigLetters(string input)
        {
            _line = input.ToUpper();
        }

        public BigLetters(BigLetters other) : base()
        {
            _line = other.GetSymbols();
        }
        public override int GetLen(string line)
        {
            return base.GetLen(_line);
        }

        public override int GetSymbolAmount(string line, char symbol = 'B')
        {
            return base.GetSymbolAmount(_line, symbol);
        }

        public string GetSymbols()
        {
            return _line;
        }

        public override string ToString()
        {
            return $"BigLetters: {_line}, Length: {GetLen(_line)}, Symbol 'B' Amount: {GetSymbolAmount(_line)}";
        }
    }
}