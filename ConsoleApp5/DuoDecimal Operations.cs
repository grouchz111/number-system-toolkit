using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
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
    }
}