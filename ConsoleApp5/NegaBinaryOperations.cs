using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class NBinaryOperations
    {
        public static void Forward()
        {
            Console.Write("Enter decimal number to convert to negabinary (base -2): ");
            int n = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {n}");
            Console.WriteLine($"You entered: {n}");
            if (n == 0) { Console.WriteLine("Negabinary: 0"); }
            else
            {
                Console.WriteLine($"Steps to convert {n} to negabinary:");
                var sb = new StringBuilder();
                int temp = n;
                while (temp != 0)
                {
                    int remainder = temp % -2;
                    int quotient = temp / -2;
                    if (remainder < 0)
                    {
                        remainder += 2;
                        quotient += 1;
                    }
                    Console.WriteLine($"{temp} ÷ -2 = {quotient} remainder {remainder}");
                    sb.Insert(0, remainder);
                    temp = quotient;
                }
                Console.WriteLine("Negabinary: " + sb.ToString());
                ViewsResult.WaitUntilKeypress();
            }
        }
    }
}