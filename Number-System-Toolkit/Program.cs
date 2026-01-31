using System;
using Spectre.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                Selector();
            }
        }

        public static void Menu()
        {
            Console.Clear(); Console.WriteLine(

           
            );

            AnsiConsole.WriteLine();
        }

        static void Selector()
        {
            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Pick a function [bold Green1](use ↑↓ arrows, enter to confirm)[/][red]\n(Press Control+C to exit the program)[/]")
                    .PageSize(12)
                    .MoreChoicesText("[grey](scroll for more functions)[/]")
                    .HighlightStyle(new Style(foreground: Color.Green1))
                    .AddChoices(
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
                        "[red]exit [/]"
                    )
            );

            
            if (choice.IndexOf("exit", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                AnsiConsole.MarkupLine("[bold red]Exiting the Toolkit[/]");
                Environment.Exit(0);
            }

            //split the number from the choice
            var parts = choice.Split(new[] { ':' }, 2); 
            if (parts.Length < 1 || !int.TryParse(parts[0].Trim(), out int num) || num < 1 || num > 22)
            {
                AnsiConsole.MarkupLine("[yellow]Invalid Selection.[/]");
                AnsiConsole.Prompt(new ConfirmationPrompt("Hit (or enter) to continue..."));
                return;
            }

            // Switch
            switch (parts[0].Trim())
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

            AnsiConsole.WriteLine();
            AnsiConsole.Prompt(new ConfirmationPrompt("[grey]Press enter to go back...[/]"));
        }
    }
}