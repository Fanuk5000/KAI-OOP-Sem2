using System;

namespace LineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text:");
            string text = Console.ReadLine() ?? string.Empty;

            Line line = new Line(text);
            Line line2 = new Line(line);

            Console.WriteLine($"Copy of line: {line2.getText()}\n");


            Console.WriteLine($"Text: {line.getText()}");
            Console.WriteLine($"Length of text: {line.getLen()}");
            Console.WriteLine($"Sorted text: {line.sort()}");

            // line = null;
            // line2 = null;

            // // Force garbage collection
            // GC.Collect();
            // GC.WaitForPendingFinalizers();

            // Console.WriteLine("End of Main");
            // Console.ReadKey();
        }
    }
}