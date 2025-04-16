using System;

namespace LineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Symbols sym1 = new Symbols("**Hello*World*");
            DisplaySymbolInfo(sym1);

            Symbols sym2 = new Symbols("***Polymorphism***");
            DisplaySymbolInfo(sym2);

            BigLetters big1 = new BigLetters("abcBBxyzB");
            DisplayBigLetterInfo(big1);

            BigLetters big2 = new BigLetters("BbbBbAAA");
            DisplayBigLetterInfo(big2);
        }

        // 🔸 Метод для демонстрації поліморфізму
        static void DisplaySymbolInfo(Symbols symbolObj)
        {
            Console.WriteLine("=== Symbol Info ===");
            Console.WriteLine(symbolObj.ToString());
        }

        static void DisplayBigLetterInfo(BigLetters bigLetterObj)
        {
            Console.WriteLine("=== Big Letters Info ===");
            Console.WriteLine(bigLetterObj.ToString());
        }
    }
}