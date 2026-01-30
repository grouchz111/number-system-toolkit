using name;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                Selector();
            }
        }

        public static void Menu()
        {
            Console.Clear();

            List<string> subjects = new List<string>() {
                "1: Decimal to Binary",
                "2: Binary to Decimal",
                "3: Decimal to Hex",
                "4: Hex to Decimal",
                "5: Decimal to Octal",
                "6: Octal to Decimal",
                "7: Decimal to Roman",
                "8: Roman to Decimal",
                "9: Decimal to Base-N 2–36",
                "10: Base-N to Decimal 2–36",
                "11: Decimal to Unary tally",
                "12: Decimal to Duodecimal base 12",
                "13: Decimal to Vigesimal base 20",
                "14: Decimal to Balanced Ternary",
                "15: Decimal to Bijective Base-26 A–Z",
                "16: Decimal to Negabinary base -2",
                "17: Decimal to Factorial Number System",
                "18: Arithmetic across systems",
                "19: Convert decimal doubles to binary",
                "20: Shift integer",
                "21: Median Operations",
                "22: Combinatoric Operations",
                "'exit' to quit:"
            };

            foreach (var line in subjects)
                Console.WriteLine(line);
        }

        public static void Selector()
        {
            string choice = InputHelper.ReadString("Enter choice: ");

            if (choice == "exit")
                Environment.Exit(0);

            if (!int.TryParse(choice, out var num) || num < 1 || num > 22)
            {
                Console.WriteLine("Invalid choice (1–22 only).");
                return;
            }

            switch (choice)
            {
                case "1": BinaryOperations.ConvertToBinaryForward(); break;
                case "2": BinaryOperations.ConvertBinaryBackward(); break;
                case "3": HexOperations.HexForward(); break;
                case "4": HexOperations.HexBackward(); break;
                case "5": OctalOperations.OctalForward(); break;
                case "6": OctalOperations.OctalBackward(); break;
                case "7": RomanOperations.RomanForward(); break;
                case "8": RomanOperations.RomanBackward(); break;
                case "9": BaseNOperations.NForward(); break;
                case "10": BaseNOperations.NBackward(); break;
                case "11": UnaryOperations.UnaryForward(); break;
                case "12": DuodecimalOperations.DuodecimalForward(); break;
                case "13": VigesimalOperations.VigesimalForward(); break;
                case "14": BalancedTernaryOperations.BalancedTernaryForward(); break;
                case "15": BijectiveOperations.BijectiveForward(); break;
                case "16": NBinaryOperations.Forward(); break;
                case "17": FactorialOperations.FactorialBinForward(); break;
                case "18": ArithmethicOperations.ArithmethicForward(); break;
                case "19": DecimalDoublesToBinaryOperations.DDTBOForward(); break;
                case "20": IntShiftOperations.IntShiftMenu(); break;
                case "21": MedianOperations.MedianForward(); break;
                case "22": CombinatoricsOperations.CombinatoricsForward(); break;
            }
        }
    }
}
