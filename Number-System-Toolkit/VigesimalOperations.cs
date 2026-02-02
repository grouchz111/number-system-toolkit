using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace NumberSystemToolkit
{
    class VigesimalOperations
    {
        public static void VigesimalForward()
        {
            Console.Write("Enter decimal number: ");
            int num20 = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {num20}");
            Console.WriteLine($"You entered: {num20}");
            if (num20 == 0) Console.WriteLine("Vigesimal: 0");
                    else
                    {
                        int temp = num20;
                        string res = "";
                        while (temp > 0)
                        {
                            int r = temp % 20;
                            string d = r < 10 ? r.ToString() : ((char)('A' + r - 10)).ToString();
                            Console.WriteLine($"{temp} ÷ 20 = {temp / 20} remainder {d}");
                            res = d + res;
                            temp /= 20;
                        }
                        Console.WriteLine("Vigesimal: " + res);
                    }
        }
        public static int VigesimalBackward()
        {
            Console.Write("Enter vigesimal (base 20) number: ");
            string s = InputHelper.ReadString("Enter vigesimal number: ").Trim().ToUpper();

            Console.WriteLine($"You entered: {s}");

            // Validate characters: 0–9 and A–J only
            if (!s.All(c =>
                char.IsDigit(c) ||
                (c >= 'A' && c <= 'J')))
            {
                Console.WriteLine("Invalid input. Base-20 digits must be 0-9 or A-J.");
                
            }

            Console.WriteLine($"Steps to convert {s} to decimal:");

            long result = 0;

            foreach (char c in s)
            {
                int value;

                if (char.IsDigit(c))
                    value = c - '0';
                else
                    value = 10 + (c - 'A'); // A=10, B=11, ..., J=19

                long before = result;
                result = result * 20 + value;

                Console.WriteLine($"{before} * 20 + {value} = {result}");
            }

            Console.WriteLine($"Decimal value: {result}");
            return (int)result;
            
        }

        public static int VigesimalBackwardMath(string s)
        {
            Console.Write("Enter vigesimal (base 20) number: ");
            s = InputHelper.ReadString("Enter vigesimal number: ").Trim().ToUpper();

            Console.WriteLine($"You entered: {s}");

            // Validate characters: 0–9 and A–J only
            if (!s.All(c =>
                char.IsDigit(c) ||
                (c >= 'A' && c <= 'J')))
            {
                Console.WriteLine("Invalid input. Base-20 digits must be 0-9 or A-J.");
                  
            }


            Console.WriteLine($"Steps to convert {s} to decimal:");

            long result = 0;

            foreach (char c in s)
            {
                int value;

                if (char.IsDigit(c))
                    value = c - '0';
                else
                    value = 10 + (c - 'A'); // A=10, B=11, ..., J=19

                long before = result;
                result = result * 20 + value;

                Console.WriteLine($"{before} * 20 + {value} = {result}");
            }

            Console.WriteLine($"Decimal value: {result}");
            
            return (int)result;
        }

    }
}