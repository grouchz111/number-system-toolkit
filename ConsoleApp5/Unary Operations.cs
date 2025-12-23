using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Unary_Operations
    {
        public static void UnaryForward()
        {
            Console.Write("Enter a decimal number to convert to unary (tally): ");
            int n = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {n}");
            Console.WriteLine($"You entered: {n}");
            Console.WriteLine($"Unary (tally) for {n}: " + (n > 0 ? new string('|', n) : "0"));
        }
    }
}