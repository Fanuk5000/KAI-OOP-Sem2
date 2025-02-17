using System;

namespace LineApp
{
    public class Line
    {
        private string text;

        public Line()
        {
            this.text = "";
        }
        public Line(string text)
        {
            this.text = text;
        }

        public Line(Line other)//for copy
        {
            this.text = other.text;
        }

        public string getText()
        {
            return text;
        }

        public int getLen()
        {
            return text.Length;
        }

        public string sort()
        {
            string sortedText = new string(text.OrderByDescending(c => c).ToArray());// => convertation

            return sortedText;
        }
    }
}