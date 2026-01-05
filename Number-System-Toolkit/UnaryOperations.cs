using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class UnaryOperations
    {
        public static void UnaryForward()
        {
            Console.Write("Enter a decimal number to convert to unary (tally): ");
            
            string n1 = InputHelper.ReadString("Enter a decimal number to convert to unary (tally): ");
            int n = int.Parse(n1);
            InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {n1}");
            Console.WriteLine($"You entered: {n}");
            Console.WriteLine($"Unary (tally) for {n}: " + (n > 0 ? new string('|', n) : "0"));
            ViewsResult.WaitUntilKeypress();
        }
    }
}