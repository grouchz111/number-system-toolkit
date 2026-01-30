using ConsoleApp1;
using System;

namespace name
{
    class MenuClause
    {
        public static bool flagMenu = false;

        static MenuClause()
        {
            //Add handler for Ctrl+C
            Console.CancelKeyPress += (sender, e) =>
            {
                Environment.Exit(0);
            };
        }

        public static void Exit(string input)
        {
            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase) ||
                input.Equals("q", StringComparison.OrdinalIgnoreCase) ||
                input.Equals("x", StringComparison.OrdinalIgnoreCase))
            {
                Environment.Exit(0);
            }
        }

        public static void Menu(string input)
        {
            if (input.Equals("menu", StringComparison.OrdinalIgnoreCase) ||
                input.Equals("m", StringComparison.OrdinalIgnoreCase))
            {
                Program.Menu(); ;
            }
        }
    }
}
