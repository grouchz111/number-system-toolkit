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
    }
}