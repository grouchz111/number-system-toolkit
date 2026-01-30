using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class RomanOperations
    {
        public static void RomanForward()
        {
            Console.Write("Enter a decimal number to convert to Roman: ");
            int number = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {number}");
            Console.WriteLine($"You entered: {number}");
            string roman = "";

            var map = new Dictionary<int, string> {
                        {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"},
                        {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"},
                        {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"}, {1, "I"}
                    };

            foreach (var kvp in map)
            {
                while (number >= kvp.Key)
                {
                    roman += kvp.Value;
                    number -= kvp.Key;
                }
            }

            Console.WriteLine("Roman numeral: " + roman);
            
        }
        public static void RomanBackward()
        {
            string roman = InputHelper.ReadString("Enter a Roman numeral to convert to decimal: ").ToUpper();
            var map = new Dictionary<char, int> {
                        {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
                        {'C', 100}, {'D', 500}, {'M', 1000}
                    };

            int total = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                int value = map[roman[i]];
                if (i + 1 < roman.Length && map[roman[i + 1]] > value)
                    total -= value;
                else
                    total += value;
            }

            Console.WriteLine("Decimal: " + total);
            
        }
        public static int RomanBackwardMath(string roman)
        {
            var map = new Dictionary<char, int> {
        {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
        {'C', 100}, {'D', 500}, {'M', 1000}
    };

            int total = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                int value = map[roman[i]];

                if (i + 1 < roman.Length && map[roman[i + 1]] > value)
                    total -= value;
                else
                    total += value;
            }

            Console.WriteLine("Decimal: " + total);

            
            return total;
        }
    }
}