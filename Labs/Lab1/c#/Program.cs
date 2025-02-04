using System;

namespace LineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text:");
            string text = Console.ReadLine();

            Line line = new Line(text);

            Console.WriteLine($"Text: {line.getText()}");
            Console.WriteLine($"Length of text: {line.getLen()}");
            Console.WriteLine($"Sorted text: {line.sort()}");
        }
    }
}