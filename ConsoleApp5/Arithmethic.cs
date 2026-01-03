using System;

using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class ArithmethicOperations
    {
        public static void ArithmethicForward()
        {
            {
                string system = InputHelper.ReadString("Enter system: Choose number system (binary(1), decimal(2), hex(3), octal(4), roman(5), base-N(6), unary(7), duodecimal(8), vigesimal(9), balanced ternary(10), bijective base-26(11), negabinary(12), factorial(13)): ").ToLower();

                string num1 = InputHelper.ReadString("Type the first number: ").ToLower();

                string num2 = InputHelper.ReadString("Type the second number: ").ToLower();

                string op = InputHelper.ReadString("Select Function: (+, -, *, /) ").ToLower();

                int a = 0, b = 0;

                if (system == "1")
                {
                    string binary = InputHelper.ReadString("Enter a binary number to convert to decimal: ");
                    BinaryOperations.ConvertBinaryBackwardMath(binary);
                }
                else if (system == "2")
                {
                    a = Convert.ToInt32(num1, 10);
                    b = Convert.ToInt32(num2, 10);
                    Console.WriteLine($"Converted {num1} to {a} and {num2} to {b} (decimal)");
                    ViewsResult.WaitUntilKeypress();
                }
                else if (system == "3")
                {
                    string hexInput = InputHelper.ReadString("Enter hexadecimal number: ").ToUpper();
                    HexOperations.HexBackwardMath(hexInput);
                }
                else if (system == "4")
                {
                    string octalInput = InputHelper.ReadString("Enter an octal number to convert to decimal: ");
                    OctalOperations.OctalBackwardMath(octalInput);
                }

                else if (system == "5") // Roman numerals
                {
                    string roman = InputHelper.ReadString("Enter a Roman numeral to convert to decimal: ").ToUpper();
                    RomanOperations.RomanBackwardMath(roman);
                }
                else if (system == "6") // Base-N (2–36)
                {
                    string inputNum = Console.ReadLine().ToUpper();
                    BaseNOperations.NBackwardMath(inputNum);    
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
                        
                    }
                    result = a / b;
                    Console.WriteLine($"Step: {a} / {b} = {result}");
                }
                else
                {
                    Console.WriteLine("Invalid operation.");
                    
                }

                Console.WriteLine($"Result in decimal: {result}");
                Console.WriteLine($"Result in binary: {Convert.ToString(result, 2)}");
                Console.WriteLine($"Result in octal: {Convert.ToString(result, 8)}");
                Console.WriteLine($"Result in hexadecimal: {Convert.ToString(result, 16).ToUpper()}");
            }
        }
    }
}