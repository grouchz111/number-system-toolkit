using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace NumberSystemToolkit
{
    class DuodecimalOperations
    {
        public static void DuodecimalForward()
        {
            Console.Write("Enter decimal number: ");
            int num12 = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {num12}");
            Console.WriteLine($"You entered: {num12}");
            Console.WriteLine($"Steps to convert {num12} to duodecimal (base 12):");
            if (num12 == 0) Console.WriteLine("Duodecimal: 0");
            else
            {
                int temp = num12;
                string res = "";
                while (temp > 0)
                {
                    int r = temp % 12;
                    string d = r < 10 ? r.ToString() : ((char)('A' + r - 10)).ToString();
                    Console.WriteLine($"{temp} ÷ 12 = {temp / 12} remainder {d}");
                    res = d + res;
                    temp /= 12;
                }
                Console.WriteLine("Duodecimal: " + res);
                
            }
        }
        public static void DuodecimalBackward()
        {
            Console.Write("Enter duodecimal (base 12) number: ");
            string s = InputHelper.ReadString("Enter duodecimal number: ").Trim().ToUpper();

            Console.WriteLine($"You entered: {s}");

            // Validate characters
            if (!s.All(c => char.IsDigit(c) || (c >= 'A' && c <= 'B')))
            {
                Console.WriteLine("Invalid input. Base-12 digits must be 0-9 or A-B.");
                
                return;
            }

            Console.WriteLine($"Steps to convert {s} to decimal:");

            long result = 0;

            foreach (char c in s)
            {
                int value;

                if (char.IsDigit(c))
                    value = c - '0';
                else
                    value = 10 + (c - 'A'); // A=10, B=11

                long before = result;
                result = result * 12 + value;

                Console.WriteLine($"{before} * 12 + {value} = {result}");
            }

            Console.WriteLine($"Decimal value: {result}");
            
        }
        public static int DuodecimalBackwardMath(string s)
        {
            Console.Write("Enter duodecimal (base 12) number: ");
            s = InputHelper.ReadString("Enter duodecimal number: ").Trim().ToUpper();

            Console.WriteLine($"You entered: {s}");

            // Validate characters
            if (!s.All(c => char.IsDigit(c) || (c >= 'A' && c <= 'B')))
            {
                Console.WriteLine("Invalid input. Base-12 digits must be 0-9 or A-B.");
                
                
            }

            Console.WriteLine($"Steps to convert {s} to decimal:");

            long result = 0;

            foreach (char c in s)
            {
                int value;

                if (char.IsDigit(c))
                    value = c - '0';
                else
                    value = 10 + (c - 'A'); // A=10, B=11

                long before = result;
                result = result * 12 + value;

                Console.WriteLine($"{before} * 12 + {value} = {result}");
            }

            Console.WriteLine($"Decimal value: {result}");
            
            return (int)result;
        }

    }
}