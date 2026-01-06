using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class NBinaryOperations
    {
        public static void Forward()
        {
            Console.Write("Enter decimal number to convert to negabinary (base -2): ");
            int n = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {n}");
            Console.WriteLine($"You entered: {n}");
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
                ViewsResult.WaitUntilKeypress();
            }
        }
        public static void Backward()
        {
            Console.Write("Enter negabinary number (base -2) to convert to decimal: ");
            string s = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(s) || !s.All(c => c == '0' || c == '1'))
            {
                Console.WriteLine("Invalid input. Negabinary digits must be 0 or 1.");
                return;
            }

            Console.WriteLine($"You entered: {s}");
            Console.WriteLine($"Steps to convert {s} to decimal:");

            long result = 0;

            foreach (char c in s)
            {
                int digit = c - '0';
                long before = result;
                result = result * -2 + digit;
                Console.WriteLine($"{before} * -2 + {digit} = {result}");
            }

            Console.WriteLine($"Decimal value: {result}");
            ViewsResult.WaitUntilKeypress();
        }
        public static int BackwardMath(string s)
        {
            Console.Write("Enter negabinary number (base -2) to convert to decimal: ");


            if (string.IsNullOrEmpty(s) || !s.All(c => c == '0' || c == '1'))
            {
                Console.WriteLine("Invalid input. Negabinary digits must be 0 or 1.");
            }

            Console.WriteLine($"You entered: {s}");
            Console.WriteLine($"Steps to convert {s} to decimal:");

            long result = 0;

            foreach (char c in s)
            {
                int digit = c - '0';
                long before = result;
                result = result * -2 + digit;
                Console.WriteLine($"{before} * -2 + {digit} = {result}");
            }

            Console.WriteLine($"Decimal value: {result}");
            ViewsResult.WaitUntilKeypress();
            return (int)result;
        }

    }
}