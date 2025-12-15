using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Entry text
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
                menu.AppendLine("20: Shift integer left");
                menu.AppendLine("21: Shift integer right");
                menu.AppendLine("'exit' to quit:");
                
                Console.WriteLine(menu.ToString());

                //selector
                string input = Console.ReadLine();

                if (input?.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number or 'exit'.");
                    continue;
                }
                //Selection blocks
                if (choice == 1)
                {
                    Binary_Operations.ConvertToBinaryForward();
                }
                else if (choice == 2)
                {
                    Binary_Operations.ConvertBinaryBackward();
                }
                else if (choice == 3)
                {
                    Hex_Operations.HexForward();
                }
                else if (choice == 4)
                {
                    Hex_Operations.HexBackward();
                }
                else if (choice == 5)
                {
                    Octal_Operations.OctalForward();
                }
                else if (choice == 6)
                {
                    Octal_Operations.OctalBackward();
                }
                else if (choice == 7)
                {
                    Roman_Operations.RomanForward();
                }
                else if (choice == 8)
                {
                    Roman_Operations.RomanBackward();
                }
                else if (choice == 9)
                {
                    Base_N_Operations.NForward();
                }
                else if (choice == 10)
                {
                    Base_N_Operations.NBackward();
                }
                else if (choice == 11)
                {
                    Unary_Operations.UnaryForward();
                }
                else if (choice == 12)
                {
                    Duodecimal_Operations.DuodecimalForward();
                }
                else if (choice == 13)
                {
                    Vigesimal_Operations.VigesimalForward();
                }
                else if (choice == 14)
                {
                    Balanced_Ternary_Operations.BalancedTernaryForward();
                }
                else if (choice == 15)
                {
                    BijectiveOperations.BijectiveForward();
                }
                else if (choice == 16)
                {
                    NBinary_Operations.Forward();
                }
                else if (choice == 17)
                {
                    Factorial_Operations.FactorialForward();
                }
                else if (choice == 18)
                {
                    AritmethicAcrossSystemsOperations.AASOForward();
                }
                else if (choice == 19)
                {
                    DecimalDoublesToBinaryOperations.DDTBOForward();
                }
                else if (choice == 20)
                {
                    ShiftIntOperations.SIO();
                }
                else if (choice == 21)
                {
                    MedianOperations.MedianForward();
                    }
                }
            }
        }
    }









