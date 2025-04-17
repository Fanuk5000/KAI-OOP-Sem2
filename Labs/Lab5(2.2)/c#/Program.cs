using System;

namespace LineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Symbols sym1 = new Symbols("**Hello*World*");
            DisplayLineInfo(sym1);

            Symbols sym2 = new Symbols("***Polymorphism***");
            DisplayLineInfo(sym2);

            BigLetters big1 = new BigLetters("abcBBxyzB");
            DisplayLineInfo(big1);

            BigLetters big2 = new BigLetters("BbbBbAAA");
            DisplayLineInfo(big2);
        }

        // 🔸 Метод для демонстрації поліморфізму
        static void DisplayLineInfo(Line lineObj)
        {
            Console.WriteLine("=== Line Info ===");
            Console.WriteLine(lineObj.ToString());
            Console.WriteLine("");
        }
    }
}