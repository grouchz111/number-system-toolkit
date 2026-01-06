using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class BijectiveOperations
    {
        public static void BijectiveForward()
        {
            Console.Write("Enter decimal number to convert to bijective base-26 (A=1..Z=26): ");
            int n = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {n}");
            if (n <= 0) { Console.WriteLine("Bijective base-26 is defined for positive integers only."); }
            else
            {
                Console.WriteLine($"Steps to convert {n} to bijective base-26:");
                var sb = new StringBuilder();
                int temp = n;
                while (temp > 0)
                {
                    temp -= 1;
                    int rem = temp % 26;
                    char c = (char)('A' + rem);
                    Console.WriteLine($"n-1 = {temp}, remainder {rem} -> {c}, next n = {temp / 26}");
                    sb.Insert(0, c);
                    temp /= 26;
                }
                Console.WriteLine("Bijective base-26: " + sb.ToString());
                ViewsResult.WaitUntilKeypress();
            }
        }
        public static void BijectiveBackward()
        {
            Console.Write("Enter bijective base-26 string (A=1..Z=26): ");
            string s = Console.ReadLine().Trim().ToUpper();

            if (string.IsNullOrEmpty(s) || !s.All(char.IsLetter))
            {
                Console.WriteLine("Invalid input. Only letters A–Z are allowed.");
                return;
            }

            Console.WriteLine($"You entered: {s}");
            Console.WriteLine($"Steps to convert {s} to decimal:");

            long result = 0;

            foreach (char c in s)
            {
                int value = (c - 'A') + 1; // A=1, B=2, ..., Z=26
                Console.WriteLine($"{c} -> {value}, result = result * 26 + {value}");
                result = result * 26 + value;
            }

            Console.WriteLine($"Decimal value: {result}");
            ViewsResult.WaitUntilKeypress();
        }
        public static int BijectiveBackwardMath(string s)
        {
            Console.Write("Enter bijective base-26 string (A=1..Z=26): ");
            

            if (string.IsNullOrEmpty(s) || !s.All(char.IsLetter))
            {
                Console.WriteLine("Invalid input. Only letters A–Z are allowed.");
            }

            Console.WriteLine($"You entered: {s}");
            Console.WriteLine($"Steps to convert {s} to decimal:");

            long result = 0;

            foreach (char c in s)
            {
                int value = (c - 'A') + 1; // A=1, B=2, ..., Z=26
                Console.WriteLine($"{c} -> {value}, result = result * 26 + {value}");
                result = result * 26 + value;
            }

            Console.WriteLine($"Decimal value: {result}");
            ViewsResult.WaitUntilKeypress();
            return (int)result;
        }

    }
}