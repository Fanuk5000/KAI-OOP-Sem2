namespace LineApp
{
    public class Line
    {
        public virtual int GetLen(string line)
        {
            return line.Length;
        }

        public virtual int GetSymbolAmount(string line, char symbol)
        {
            return line.Count(c => c == symbol);
        }
        public override string ToString()
        {
            return "Line class: No specific implementation";
        }
    }
}