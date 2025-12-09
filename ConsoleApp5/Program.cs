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
                    Console.Write("Enter decimal number to convert to negabinary (base -2): ");
                    int n = int.Parse(Console.ReadLine());
                    if (n == 0) { Console.WriteLine("Negabinary: 0"); }
                    else
                    {
                        Console.WriteLine($"Steps to convert {n} to negabinary:");
                        var sb = new StringBuilder();
                        int temp = n;
                        while (temp != 0)
                        {
                            int remainder = temp % -2;
                            int quotient = temp / -2;
                            if (remainder < 0)
                            {
                                remainder += 2;
                                quotient += 1;
                            }
                            Console.WriteLine($"{temp} ÷ -2 = {quotient} remainder {remainder}");
                            sb.Insert(0, remainder);
                            temp = quotient;
                        }
                        Console.WriteLine("Negabinary: " + sb.ToString());
                    }
                }
                else if (choice == 17)
                {
                    Console.Write("Enter decimal number to convert to factorial number system: ");
                    int n = int.Parse(Console.ReadLine());
                    if (n == 0) { Console.WriteLine("Factorial system: 0"); }
                    else
                    {
                        Console.WriteLine($"Steps to convert {n} to factorial number system:");
                        var digitsFact = new List<int>();
                        int divisor = 1;
                        int temp = n;
                        while (temp > 0)
                        {
                            divisor++;
                            int d = temp % divisor;
                            digitsFact.Add(d);
                            Console.WriteLine($"temp % {divisor} = {d}, next temp = {temp / divisor}");
                            temp /= divisor;
                        }
                        digitsFact.Reverse();
                        Console.WriteLine("Factorial representation (digits for 1!,2!,3!,...): " + string.Join("", digitsFact));
                    }
                }
                else if (choice == 18)
                {
                    Console.Write("Choose number system (binary(1), decimal(2), hex(3), octal(4), roman(5), base-N(6), unary(7), duodecimal(8), vigesimal(9), balanced ternary(10), bijective base-26(11), negabinary(12), factorial(13)): ");

                    string system = Console.ReadLine().ToLower();

                    Console.Write("Enter first number: ");
                    string num1 = Console.ReadLine();

                    Console.Write("Enter second number: ");
                    string num2 = Console.ReadLine();

                    Console.Write("Choose operation (+, -, *, /): ");
                    string op = Console.ReadLine();

                    int a = 0, b = 0;

                    if (system == "1")
                    {
                        a = Convert.ToInt32(num1, 2);
                        b = Convert.ToInt32(num2, 2);
                        Console.WriteLine($"Converted {num1} to {a} and {num2} to {b} (decimal)");
                    }
                    else if (system == "2")
                    {
                        a = Convert.ToInt32(num1, 10);
                        b = Convert.ToInt32(num2, 10);
                        Console.WriteLine($"Converted {num1} to {a} and {num2} to {b} (decimal)");
                    }
                    else if (system == "3")
                    {
                        a = Convert.ToInt32(num1, 16);
                        b = Convert.ToInt32(num2, 16);
                        Console.WriteLine($"Converted {num1} to {a} and {num2} to {b} (decimal)");
                    }
                    else if (system == "4")
                    {
                        a = Convert.ToInt32(num1, 8);
                        b = Convert.ToInt32(num2, 8);
                        Console.WriteLine($"Converted {num1} to {a} and {num2} to {b} (decimal)");
                    }

                    else if (system == "5") // Roman numerals
                    {
                        // parse Roman -> decimal using same step-by-step approach as your Roman handler
                        int ParseRoman(string s)
                        {
                            s = s.ToUpper();
                            var map = new System.Collections.Generic.Dictionary<char, int> {
                {'I',1},{'V',5},{'X',10},{'L',50},{'C',100},{'D',500},{'M',1000}
            };
                            int total = 0;
                            for (int i = 0; i < s.Length; i++)
                            {
                                int value = map.ContainsKey(s[i]) ? map[s[i]] : 0;
                                if (i + 1 < s.Length && map.ContainsKey(s[i + 1]) && map[s[i + 1]] > value)
                                    total -= value;
                                else
                                    total += value;
                            }
                            return total;
                        }

                        a = ParseRoman(num1);
                        b = ParseRoman(num2);
                        Console.WriteLine($"Converted {num1} to {a} and {num2} to {b} (decimal)");
                    }
                    else if (system == "6") // Base-N (2–36)
                    {
                        Console.Write("Enter the base (2–36): ");
                        int baseN = int.Parse(Console.ReadLine());
                        a = Convert.ToInt32(num1.ToUpper(), baseN);
                        b = Convert.ToInt32(num2.ToUpper(), baseN);
                        Console.WriteLine($"Converted {num1} (base-{baseN}) to {a} and {num2} (base-{baseN}) to {b} (decimal)");
                    }
                    else if (system == "7") // Unary (tally)
                    {
                        // accept '||||' or decimal fallback
                        int ParseUnary(string s)
                        {
                            if (string.IsNullOrEmpty(s)) return 0;
                            int count = 0;
                            foreach (char c in s) if (c == '|') count++;
                            if (count > 0) return count;
                            return int.TryParse(s, out int v) ? v : 0;
                        }

                        a = ParseUnary(num1);
                        b = ParseUnary(num2);
                        Console.WriteLine($"Converted {num1} to {a} and {num2} to {b} (decimal)");
                    }
                    else if (system == "8") // Duodecimal (base 12)
                    {
                        a = Convert.ToInt32(num1.ToUpper(), 12);
                        b = Convert.ToInt32(num2.ToUpper(), 12);
                        Console.WriteLine($"Converted {num1} (base-12) to {a} and {num2} (base-12) to {b} (decimal)");
                    }
                    else if (system == "9") // Vigesimal (base 20)
                    {
                        a = Convert.ToInt32(num1.ToUpper(), 20);
                        b = Convert.ToInt32(num2.ToUpper(), 20);
                        Console.WriteLine($"Converted {num1} (base-20) to {a} and {num2} (base-20) to {b} (decimal)");
                    }
                    else if (system == "10") // Balanced ternary (digits: 1,0,T for -1)
                    {
                        int ParseBalancedTernary(string s)
                        {
                            int value = 0;
                            for (int i = 0; i < s.Length; i++)
                            {
                                char c = s[s.Length - 1 - i];
                                int digit = (c == 'T' || c == 't') ? -1 : (c - '0');
                                value += digit * (int)Math.Pow(3, i);
                            }
                            return value;
                        }

                        a = ParseBalancedTernary(num1);
                        b = ParseBalancedTernary(num2);
                        Console.WriteLine($"Converted {num1} to {a} and {num2} to {b} (decimal)");
                    }
                    else if (system == "11") // Bijective base-26 (A=1..Z=26)
                    {
                        int ParseBijectiveBase26(string s)
                        {
                            s = s.ToUpper();
                            int value = 0;
                            foreach (char c in s)
                            {
                                if (c < 'A' || c > 'Z') continue;
                                value = value * 26 + (c - 'A' + 1);
                            }
                            return value;
                        }

                        a = ParseBijectiveBase26(num1);
                        b = ParseBijectiveBase26(num2);
                        Console.WriteLine($"Converted {num1} to {a} and {num2} to {b} (decimal)");
                    }
                    else if (system == "12")
                    {
                        int ParseNegabinary(string s)
                        {
                            int value = 0;
                            for (int i = 0; i < s.Length; i++)
                            {
                                int bit = s[s.Length - 1 - i] - '0';
                                value += bit * (int)Math.Pow(-2, i);
                            }
                            return value;
                        }

                        a = ParseNegabinary(num1);
                        b = ParseNegabinary(num2);
                        Console.WriteLine($"Converted {num1} to {a} and {num2} to {b} (decimal)");
                    }
                    else if (system == "13")
                    {
                        int ParseFactorialSystem(string s)
                        {
                            int result = 0;
                            int len = s.Length;
                            for (int i = 0; i < len; i++)
                            {
                                char c = s[len - 1 - i];
                                if (!char.IsDigit(c)) continue;
                                int digit = c - '0';
                                int fact = 1;
                                for (int f = 1; f <= i + 1; f++) fact *= f;
                                result += digit * fact;
                            }
                            return result;
                        }

                        a = ParseFactorialSystem(num1);
                        b = ParseFactorialSystem(num2);
                        Console.WriteLine($"Converted {num1} to {a} and {num2} to {b} (decimal)");
                    }

                    else
                    {
                        Console.WriteLine("Invalid number system.");
                        continue;
                    }


                    int result = 0;

                    if (op == "+")
                    {
                        result = a + b;
                        Console.WriteLine($"Step: {a} + {b} = {result}");
                    }
                    else if (op == "-")
                    {
                        result = a - b;
                        Console.WriteLine($"Step: {a} - {b} = {result}");
                    }
                    else if (op == "*")
                    {
                        result = a * b;
                        Console.WriteLine($"Step: {a} * {b} = {result}");
                    }
                    else if (op == "/")
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            continue;
                        }
                        result = a / b;
                        Console.WriteLine($"Step: {a} / {b} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation.");
                        continue;
                    }

                    Console.WriteLine($"Result in decimal: {result}");
                    Console.WriteLine($"Result in binary: {Convert.ToString(result, 2)}");
                    Console.WriteLine($"Result in octal: {Convert.ToString(result, 8)}");
                    Console.WriteLine($"Result in hexadecimal: {Convert.ToString(result, 16).ToUpper()}");
                }
                else if (choice == 19)
                {
                    Console.Write("Enter a decimal number (use ','!): ");
                    double decimalNumber = Convert.ToDouble(Console.ReadLine());

                    int integerPart = (int)Math.Floor(decimalNumber);
                    double fractionalPart = decimalNumber - integerPart;

                    Console.WriteLine("\n--- Integer Part Conversion ---");
                    string binaryInteger = "";
                    int a = integerPart;

                    while (a > 0)
                    {
                        int remainder = a % 2;
                        Console.WriteLine($"{a} ÷ 2 = {a / 2} remainder {remainder}");
                        binaryInteger = remainder + binaryInteger;
                        a /= 2;
                    }

                    Console.WriteLine($"Binary (integer): {binaryInteger}");

                    Console.WriteLine("\n--- Fractional Part Conversion ---");
                    string binaryFraction = "";
                    double frac = fractionalPart;
                    int precision = 3;

                    for (int i = 0; i < precision; i++)
                    {
                        frac *= 2;
                        int bit = (int)Math.Floor(frac);
                        binaryFraction += bit;
                        Console.WriteLine($"{frac / 2} × 2 = {frac} → bit: {bit}");
                        frac -= bit;
                    }

                    Console.WriteLine($"\nBinary (fraction): {binaryFraction}");
                    Console.WriteLine($"\nFinal Binary: {binaryInteger}.{binaryFraction}");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();

                }
                else if (choice == 20)
                {


                    Console.WriteLine("whats the int?");
                    int a = int.Parse(Console.ReadLine());

                    if (a == 0)
                    {
                        Console.WriteLine("Binary: 0");
                    }
                    else
                    {
                        Console.WriteLine("Shift by how many positions?");
                        Console.WriteLine("Enter direction (R for Right, L for Left):");
                        char c = Console.ReadLine().ToUpper()[0];

                        Console.Write("Enter number of positions to shift: ");
                        int shift = int.Parse(Console.ReadLine());

                        int shifted;
                        if (c == 'R')
                        {
                            shifted = a >> shift;
                            Console.WriteLine($"{a} >> {shift} = {shifted}");
                            Console.WriteLine("Binary: " + Convert.ToString(shifted, 2));
                        }
                        else if (c == 'L')
                        {
                            shifted = a << shift;
                            Console.WriteLine($"{a} << {shift} = {shifted}");
                            Console.WriteLine("Binary: " + Convert.ToString(shifted, 2));
                        }
                        else
                        {
                            Console.WriteLine("Invalid direction. Use R or L.");
                        }


                    }


                }
                else if (choice == 21)
                {
                    Console.WriteLine("enter the number line");
                    var median = Console.ReadLine(); ;
                    var numbers = median.Select(c => int.Parse(c.ToString())).OrderBy(n => n).ToList();

                    int count = numbers.Count;
                    if (count % 2 == 1)
                    {

                        Console.WriteLine($"Median: {numbers[count / 2]}");
                    }
                    else
                    {

                        int mid1 = numbers[(count / 2) - 1];
                        int mid2 = numbers[count / 2];
                        double mid3 = ((mid1 + mid2) / 2);
                        Console.WriteLine($"Median:" + mid3);
                    }
                }

            }

        }
    }
}








