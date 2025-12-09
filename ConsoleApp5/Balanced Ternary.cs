using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Balanced_Ternary_Operations
    {
        public static void BalancedTernaryForward()
        {
            Console.Write("Enter decimal number to convert to balanced ternary: ");
            int n = int.Parse(Console.ReadLine());
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
    }
}