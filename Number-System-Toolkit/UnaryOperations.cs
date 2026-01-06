using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class UnaryOperations
    {
        public static void UnaryForward()
        {
            Console.Write("Enter a decimal number to convert to unary (tally): ");
            
            string n1 = InputHelper.ReadString("Enter a decimal number to convert to unary (tally): ");
            int n = int.Parse(n1);
            InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {n1}");
            Console.WriteLine($"You entered: {n}");
            Console.WriteLine($"Unary (tally) for {n}: " + (n > 0 ? new string('|', n) : "0"));
            ViewsResult.WaitUntilKeypress();
        }
        public static void UnaryBackward()
        {
            Console.Write("Enter a unary (tally) number to convert to decimal: ");
            string s = InputHelper.ReadString("Enter unary (tally) number: ").Trim();

            Console.WriteLine($"You entered: {s}");

            // Validate
            if (s == "0")
            {
                Console.WriteLine("Decimal value: 0");
                ViewsResult.WaitUntilKeypress();
                return;
            }

            if (!s.All(c => c == '|'))
            {
                Console.WriteLine("Invalid unary input. Only '|' or '0' are allowed.");
                ViewsResult.WaitUntilKeypress();
                return;
            }

            Console.WriteLine($"Steps to convert unary '{s}' to decimal:");
            int count = 0;

            foreach (char c in s)
            {
                count++;
                Console.WriteLine($"Found '|', count = {count}");
            }

            Console.WriteLine($"Decimal value: {count}");
            ViewsResult.WaitUntilKeypress();
        }

        public static int UnaryBackwardMath(string s)
        {
            
            s = InputHelper.ReadString("Enter unary (tally) number: ").Trim();

            Console.WriteLine($"You entered: {s}");

            // Validate
            if (s == "0")
            {
                Console.WriteLine("Decimal value: 0");
                ViewsResult.WaitUntilKeypress();
                
            }

            if (!s.All(c => c == '|'))
            {
                Console.WriteLine("Invalid unary input. Only '|' or '0' are allowed.");
                ViewsResult.WaitUntilKeypress();
                
            }

            Console.WriteLine($"Steps to convert unary '{s}' to decimal:");
            int count = 0;

            foreach (char c in s)
            {
                count++;
                Console.WriteLine($"Found '|', count = {count}");
            }

            Console.WriteLine($"Decimal value: {count}");
            ViewsResult.WaitUntilKeypress();
            return (int)count;
        }

    }
}