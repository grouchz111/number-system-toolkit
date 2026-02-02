using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace NumberSystemToolkit
{
    class BalancedTernaryOperations
    {
        public static void BalancedTernaryForward()
        {
            Console.Write("Enter decimal number to convert to balanced ternary: ");
            int n = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {n}");
            if (n == 0) { Console.WriteLine("Balanced ternary: 0"); }
            else
            {
                Console.WriteLine($"Steps to convert {n} to balanced ternary:");
                var sb = new StringBuilder();
                int temp = n;
                while (temp != 0)
                {
                    int rem = temp % 3;
                    temp /= 3;
                    if (rem == 2)
                    {
                        rem = -1;
                        temp += 1;
                    }
                    string digit = rem == -1 ? "T" : rem.ToString();
                    Console.WriteLine($"remainder {rem} -> digit {digit}, next n = {temp}");
                    sb.Insert(0, digit);
                }
                Console.WriteLine("Balanced ternary (T = -1): " + sb.ToString());
                
            }
        }
        public static void BalancedTernaryBackward()
        {
            Console.Write("Enter balanced ternary number (digits: 1, 0, T): ");
            string s = InputHelper.ReadString("Enter balanced ternary number: ").Trim().ToUpper();

            Console.WriteLine($"You entered: {s}");

            // Validate characters
            if (!s.All(c => c == '1' || c == '0' || c == 'T'))
            {
                Console.WriteLine("Invalid input. Balanced ternary digits must be 1, 0, or T (for -1).");
                
                return;
            }

            Console.WriteLine($"Steps to convert {s} to decimal:");

            long result = 0;

            foreach (char c in s)
            {
                int value = c switch
                {
                    '1' => 1,
                    '0' => 0,
                    'T' => -1,
                    _ => 0
                };

                long before = result;
                result = result * 3 + value;

                Console.WriteLine($"{before} * 3 + {value} = {result}");
            }

            Console.WriteLine($"Decimal value: {result}");
            
        }

        public static int BalancedTernaryBackwardMath(string num2)
        {
            Console.Write("Enter balanced ternary number (digits: 1, 0, T): ");
            string s = InputHelper.ReadString("Enter balanced ternary number: ").Trim().ToUpper();

            Console.WriteLine($"You entered: {s}");

            // Validate characters
            if (!s.All(c => c == '1' || c == '0' || c == 'T'))
            {
                Console.WriteLine("Invalid input. Balanced ternary digits must be 1, 0, or T (for -1).");
                
            }

            Console.WriteLine($"Steps to convert {s} to decimal:");

            long result = 0;

            foreach (char c in s)
            {
                int value = c switch
                {
                    '1' => 1,
                    '0' => 0,
                    'T' => -1,
                    _ => 0
                };

                long before = result;
                result = result * 3 + value;

                Console.WriteLine($"{before} * 3 + {value} = {result}");
            }

            Console.WriteLine($"Decimal value: {result}");
            
            return (int)result;
        }
    }
}