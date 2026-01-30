using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class FactorialOperations
    {
        public static void FactorialBinForward()
        {
            {

                Console.Write("Enter decimal number to convert to factorial number system: ");
                int n = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {n}");
                Console.WriteLine($"You entered: {n}");
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
            }
        public static void FactorialBinBackward()
        {
            Console.Write("Enter factorial number system digits (for 1!,2!,3!,...): ");
            string s = InputHelper.ReadString("Enter factorial number: ").Trim();

            Console.WriteLine($"You entered: {s}");

            // Validate: digits must be numeric
            if (!s.All(char.IsDigit))
            {
                Console.WriteLine("Invalid input. Only digits 0–9 are allowed.");
                
                return;
            }

            // Special case
            if (s == "0")
            {
                Console.WriteLine("Decimal value: 0");
                
                return;
            }

            Console.WriteLine($"Steps to convert {s} to decimal:");

            int[] digits = s.Select(c => c - '0').ToArray();
            long result = 0;

            // factorial weight starts at 1! for the rightmost digit
            int factorialIndex = digits.Length; // because leftmost digit corresponds to highest factorial

            for (int i = 0; i < digits.Length; i++)
            {
                int digit = digits[i];

                // compute factorial weight
                long weight = 1;
                for (int f = 2; f <= factorialIndex; f++)
                    weight *= f;

                long contribution = digit * weight;

                Console.WriteLine($"Digit {digit} × {factorialIndex}! ({weight}) = {contribution}");

                result += contribution;
                factorialIndex--;
            }

            Console.WriteLine($"Decimal value: {result}");
            
        }

        public static int FactorialBinBackwardMath(string s)
        {
            Console.Write("Enter factorial number system digits (for 1!,2!,3!,...): ");
            s = InputHelper.ReadString("Enter factorial number: ").Trim();

            Console.WriteLine($"You entered: {s}");

            // Validate: digits must be numeric
            if (!s.All(char.IsDigit))
            {
                Console.WriteLine("Invalid input. Only digits 0–9 are allowed.");
                
                
            }

            // Special case
            if (s == "0")
            {
                Console.WriteLine("Decimal value: 0");
                
                
            }

            Console.WriteLine($"Steps to convert {s} to decimal:");

            int[] digits = s.Select(c => c - '0').ToArray();
            long result = 0;

            // factorial weight starts at 1! for the rightmost digit
            int factorialIndex = digits.Length; // because leftmost digit corresponds to highest factorial

            for (int i = 0; i < digits.Length; i++)
            {
                int digit = digits[i];

                // compute factorial weight
                long weight = 1;
                for (int f = 2; f <= factorialIndex; f++)
                    weight *= f;

                long contribution = digit * weight;

                Console.WriteLine($"Digit {digit} × {factorialIndex}! ({weight}) = {contribution}");

                result += contribution;
                factorialIndex--;
            }

            Console.WriteLine($"Decimal value: {result}");
            
            return (int)result;
        }

    }
}
