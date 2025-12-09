using System;

namespace ConsoleApp1
{
    class Binary_Operations
    {
        public static void ConvertToBinaryForward()
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            string binary = "";

            while (a > 0)
            {
                int remainder = a % 2;
                Console.WriteLine($"{a} ÷ 2 = {a / 2} remainder {remainder}");
                binary = remainder + binary;
                a /= 2;
            }

            Console.WriteLine("Binary: " + binary);
        }

        public static void ConvertBinaryBackward()
        {
            Console.Write("Enter a binary number to convert to decimal: ");
            string binary = Console.ReadLine();
            int decimalValue = 0;
            Console.WriteLine($"Steps to convert {binary} to decimal:");

            for (int i = 0; i < binary.Length; i++)
            {
                int bit = binary[binary.Length - 1 - i] - '0';
                int power = (int)Math.Pow(2, i);
                Console.WriteLine($"{bit} × 2^{i} = {bit * power}");
                decimalValue += bit * power;
            }

            Console.WriteLine("Decimal: " + decimalValue);
        }
    }
}
