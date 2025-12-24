using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu();

            ViewsResult.WaitUntilKeypress();
        }

        public static void Menu()
        {
            while (true)
            {
                // Entry text
                StringBuilder menu = new StringBuilder();
                menu.AppendLine("\n Enter your choice:");
                menu.AppendLine("1: Decimal to Binary");
                menu.AppendLine("2: Binary to Decimal");
                menu.AppendLine("3: Decimal to Hex");
                menu.AppendLine("4: Hex to Decimal");
                menu.AppendLine("5: Decimal to Octal");
                menu.AppendLine("6: Octal to Decimal");
                menu.AppendLine("7: Decimal to Roman");
                menu.AppendLine("8: Roman to Decimal");
                menu.AppendLine("9: Decimal to Base-N (2–36)");
                menu.AppendLine("10: Base-N to Decimal (2–36)");
                menu.AppendLine("11: Decimal to Unary (tally)");
                menu.AppendLine("12: Decimal to Duodecimal (base 12)");
                menu.AppendLine("13: Decimal to Vigesimal (base 20)");
                menu.AppendLine("14: Decimal to Balanced Ternary");
                menu.AppendLine("15: Decimal to Bijective Base-26 (A–Z)");
                menu.AppendLine("16: Decimal to Negabinary (base -2)");
                menu.AppendLine("17: Decimal to Factorial Number System");
                menu.AppendLine("18: Arithmetic across systems");
                menu.AppendLine("19: Convert decimal doubles to binary");
                menu.AppendLine("20: Shift integer");
                menu.AppendLine("21: Median Operations");
                menu.AppendLine("'exit' to quit:");
                Console.WriteLine(menu.ToString());

                // selector
                string input = Console.ReadLine();

                if (input is null)
                {
                    continue;
                }

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Environment.Exit(0);
                }

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number or 'exit'.");
                    continue;
                }

                // Selection blocks - unified PascalCase class names
                switch (choice)
                {
                        case 1:
                        BinaryOperations.ConvertToBinaryForward();
                        break;

                        case 2:
                        BinaryOperations.ConvertBinaryBackward();
                        break;
                        
                        case 3:
                        HexOperations.HexForward();
                        break;

                        case 4:
                        HexOperations.HexBackward();    
                        break;

                        case 5:
                        OctalOperations.OctalForward();
                        break;

                        case 6:
                        OctalOperations.OctalBackward();
                        break;

                        case 7:
                        RomanOperations.RomanForward();
                        break;

                        case 8 :
                        RomanOperations.RomanBackward();
                        break;

                        case 9:
                        BaseNOperations.NForward();
                        break;

                        case 10:
                        BaseNOperations.NBackward();
                        break;

                        case 11:
                        UnaryOperations.UnaryForward();
                        break;

                        case 12:
                        DuodecimalOperations.DuodecimalForward();
                        break;

                        case 13:
                        VigesimalOperations.VigesimalForward();
                        break;

                        case 14:
                        BalancedTernaryOperations.BalancedTernaryForward();
                        break;

                        case 15:
                        BijectiveOperations.BijectiveForward();
                        break;

                        case 16:
                        NBinaryOperations.Forward();
                        break;

                        case 17: 
                        FactorialOperations.FactorialBinForward();
                        break;

                        case 18: 
                        AritmethicAcrossSystemsOperations.AASOForward();  
                        break;

                        case 19: 
                        DecimalDoublesToBinaryOperations.DDTBOForward();
                        break;

                        case 20: 
                        IntShiftOperations.IntShiftMenu();
                        break;

                        case 21:
                        MedianOperations.MedianForward();
                        break;
                }
            }

        }
    }
}
