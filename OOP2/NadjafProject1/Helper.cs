using System;
namespace NadjafProject1
{
    public static class Helper
    {
        public static void TextAndColor(ConsoleColor color, string message) {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
