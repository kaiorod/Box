using System;

namespace Box
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("+----------+");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("   Caio   ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|");
            Console.WriteLine("+----------+");

            Console.ResetColor();

        }
    }
}
