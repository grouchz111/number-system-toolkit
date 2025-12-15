using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Factorial_Operations
    {
        public static void FactorialForward()
        {
            Console.Write("Enter decimal number to convert to factorial number system: ");
            int n = int.Parse(Console.ReadLine());
            if (n == 0) { Console.WriteLine("Factorial system: 0"); }
            else
            {
                Console.WriteLine($"Steps to convert {n} to factorial number system:");
                var digitsFact = new List<int>();
                int divisor = 1;
                int temp = n;
                while (temp > 0)
                {
                    divisor++;
                    int d = temp % divisor;
                    digitsFact.Add(d);
                    Console.WriteLine($"temp % {divisor} = {d}, next temp = {temp / divisor}");
                    temp /= divisor;
                }
                digitsFact.Reverse();
                Console.WriteLine("Factorial representation (digits for 1!,2!,3!,...): " + string.Join("", digitsFact));
            }
        }
    }
}