using Spectre.Console;
using System;

namespace ConsoleApp1
{
    class ArithmethicOperations
    {
        public enum NumberSystem
        {
            Binary = 1,
            Decimal = 2,
            Hex = 3,
            Octal = 4,
            Roman = 5,
            BaseN = 6,
            Unary = 7,
            Duodecimal = 8,
            Vigesimal = 9,
            BalancedTernary = 10,
            Bijective = 11,
            Negabinary = 12,
            Factorial = 13
        }

        public static void ArithmethicForward()
        {
            var systemChoice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Pick a function [Green1](use ↑↓ arrows, enter to confirm)[/][red]\n(Press Control+C to exit the program)[/]")
                    .PageSize(12)
                    .MoreChoicesText("[grey](scroll for more functions)[/]")
                    .HighlightStyle(new Style(foreground: Color.Green1))
                    .AddChoices(
                        "1: binary",
                        "2: decimal",
                        "3: hex",
                        "4: octal",
                        "5: roman",
                        "6: base-N",
                        "7: unary",
                        "8: duodecimal",
                        "9: vigesimal",
                        "10: balanced ternary",
                        "11: bijective",
                        "12: negabinary",
                        "13: factorial",
                        "[red]exit [/]"
                    )
            );

            if (systemChoice != null && systemChoice.Trim().StartsWith("[red]exit"))
            {
                AnsiConsole.MarkupLine("[yellow]Exiting menu.[/]");
                return;
            }

            // Extract numeric id from "number: name"
            string[] parts = (systemChoice ?? "").Split(new[] { ':' }, 2);
            if (parts.Length == 0 || string.IsNullOrWhiteSpace(parts[0]))
            {
                AnsiConsole.MarkupLine("[yellow]Invalid Selection.[/]");
                AnsiConsole.Prompt(new ConfirmationPrompt("Hit (or enter) to continue..."));
                return;
            }
            string systemId = parts[0].Trim();

            // Read inputs
            string num1 = InputHelper.ReadString("First number: ");
            string num2 = InputHelper.ReadString("Second number: ");

            // Prompt for operation explicitly
            string op = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Choose operation")
                    .AddChoices("+", "-", "*", "/")
                    .HighlightStyle(new Style(foreground: Color.Green1))
            );

            int a = 0;
            int b = 0;

            try
            {
                switch (systemId)
                {
                    case "1": // Binary
                        a = BinaryOperations.ConvertBinaryBackwardMath(num1);
                        b = BinaryOperations.ConvertBinaryBackwardMath(num2);
                        break;

                    case "2": // Decimal
                        a = Convert.ToInt32(num1);
                        b = Convert.ToInt32(num2);
                        break;

                    case "3": // Hex
                        a = HexOperations.HexBackwardMath(num1);
                        b = HexOperations.HexBackwardMath(num2);
                        break;

                    case "4": // Octal
                        a = OctalOperations.OctalBackwardMath(num1);
                        b = OctalOperations.OctalBackwardMath(num2);
                        break;

                    case "5": // Roman
                        a = RomanOperations.RomanBackwardMath(num1.ToUpper());
                        b = RomanOperations.RomanBackwardMath(num2.ToUpper());
                        break;

                    case "6": // Base-N
                        a = BaseNOperations.NBackwardMath(num1);
                        b = BaseNOperations.NBackwardMath(num2);
                        break;

                    case "7": // Unary
                        a = UnaryOperations.UnaryBackwardMath(num1);
                        b = UnaryOperations.UnaryBackwardMath(num2);
                        break;

                    case "8": // Duodecimal
                        a = DuodecimalOperations.DuodecimalBackwardMath(num1);
                        b = DuodecimalOperations.DuodecimalBackwardMath(num2);
                        break;

                    case "9": // Vigesimal
                        a = VigesimalOperations.VigesimalBackwardMath(num1);
                        b = VigesimalOperations.VigesimalBackwardMath(num2);
                        break;

                    case "10": // Balanced ternary
                        a = BalancedTernaryOperations.BalancedTernaryBackwardMath(num1);
                        b = BalancedTernaryOperations.BalancedTernaryBackwardMath(num2);
                        break;

                    case "11": // Bijective base-26
                        a = BijectiveOperations.BijectiveBackwardMath(num1);
                        b = BijectiveOperations.BijectiveBackwardMath(num2);
                        break;

                    case "12": // Negabinary
                        a = NBinaryOperations.BackwardMath(num1);
                        b = NBinaryOperations.BackwardMath(num2);
                        break;

                    case "13": // Factorial
                        a = FactorialOperations.FactorialBinBackwardMath(num1);
                        b = FactorialOperations.FactorialBinBackwardMath(num2);
                        break;

                    default:
                        AnsiConsole.MarkupLine("[yellow]Invalid number system.[/]");
                        return;
                }
            }
            catch (FormatException fe)
            {
                AnsiConsole.MarkupLine($"[red]Input format error: {fe.Message}[/]");
                return;
            }
            catch (Exception ex)
            {
                AnsiConsole.MarkupLine($"[red]Conversion error: {ex.Message}[/]");
                return;
            }

            // Use ClassMath to perform the operation and handle divide-by-zero
            bool ok = ClassMath.PerformOperation(a, b, op, out int result);
            if (!ok)
            {
                AnsiConsole.MarkupLine("[red]Operation failed (possible divide by zero).[/]");
                return;
            }

            // Output results in several systems
            Console.WriteLine($"Decimal: {result}");
            Console.WriteLine($"Binary: {Convert.ToString(result, 2)}");
            Console.WriteLine($"Octal: {Convert.ToString(result, 8)}");
            Console.WriteLine($"Hex: {Convert.ToString(result, 16).ToUpper()}");
        }
    }

    // Helper class to centralize arithmetic and error handling
    static class ClassMath
    {
        public static bool PerformOperation(int a, int b, string op, out int result)
        {
            result = 0;
            switch (op)
            {
                case "+":
                    result = a + b;
                    return true;
                case "-":
                    result = a - b;
                    return true;
                case "*":
                    result = a * b;
                    return true;
                case "/":
                    if (b == 0) return false;
                    result = a / b;
                    return true;
                default:
                    return false;
            }
        }
    }
}
