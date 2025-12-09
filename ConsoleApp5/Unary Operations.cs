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
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Unary (tally) for {n}: " + (n > 0 ? new string('|', n) : "0"));
        }
    }
}