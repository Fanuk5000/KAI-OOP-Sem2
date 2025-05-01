using System.Collections.Generic;
using System.Linq;

namespace StringsApp
{
    class TextContainer
    {
        private List<IString> lines = new List<IString>();

        public void AddLine(IString line)
        {
            lines.Add(line);
        }

        public void RemoveLine(IString line)
        {
            lines.Remove(line);
        }

        public void Clear()
        {
            lines.Clear();
        }

        public int TotalCharacters()
        {
            return lines.Sum(line => line.Length);
        }

        public int FindLines(string substring)
        {
            return lines.Count(line => line.Contains(substring));
        }

        public void ReplaceCharInText(char oldChar, char newChar)
        {
            foreach (var line in lines)
            {
                line.Replace(oldChar, newChar);
            }
        }

        public void PrintText()
        {
            foreach (var line in lines)
            {
                Console.WriteLine(line.GetContent());
            }
        }
    }
}