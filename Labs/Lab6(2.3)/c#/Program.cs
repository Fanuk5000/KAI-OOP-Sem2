using System;

namespace StringsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TextContainer text = new TextContainer();

            text.AddLine(new MyString("Hello World"));
            text.AddLine(new MyString("Hello C#"));
            text.AddLine(new MyString("Example Text"));

            Console.WriteLine("Original Text:");
            text.PrintText();

            Console.WriteLine("\nTotal characters: " + text.TotalCharacters());

            Console.WriteLine("\nLines containing 'Hello': " + text.FindLines("Hello"));

            text.ReplaceCharInText('e', 'E');

            Console.WriteLine("\nText after replacement:");
            text.PrintText();

            text.Clear();
            Console.WriteLine("\nText after clearing:");
            text.PrintText();
        }
    }
}