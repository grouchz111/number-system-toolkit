using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class CombinatoricsOperations
    {
        public static long Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("n must be non-negative.");

            long result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }

        public static void CombinatoricsForward()
        {
            int n = InputHelper.ReadInt("Enter n: ");
            int k = InputHelper.ReadInt("Enter k: ");

            if (n < 0 || k < 0)
            {
                Console.WriteLine("n and r must be non-negative.");
                return;
            }

            long factN = Factorial(n);

            long perm = (k <= n) ? factN / Factorial(n - k) : 0;
            long comb = (k <= n) ? factN / (Factorial(k) * Factorial(n - k)) : 0;

            long combRep = 0;
            if (n >= 1)
                combRep = Factorial(n + k - 1) / (Factorial(k) * Factorial(n - 1));

            Console.WriteLine($"n! = {factN}");
            Console.WriteLine($"P(n, k) = {perm}");
            Console.WriteLine($"C(n, k) = {comb}");
            Console.WriteLine($"C(n+k -1,k) = {combRep}");

            
        }

    }
}
