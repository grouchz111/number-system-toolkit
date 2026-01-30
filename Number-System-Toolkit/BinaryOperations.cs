using System;

namespace ConsoleApp1
{
    class BinaryOperations
    {
        public static void ConvertToBinaryForward()
        {
            Console.Write("Enter a number: ");
            int a = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {a}");

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
            string binary = InputHelper.ReadString("Enter a binary number to convert to decimal: ");
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
        public static int ConvertBinaryBackwardMath(string binary)
        {
            
            int decimalValue = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                int bit = binary[binary.Length - 1 - i] - '0';
                int power = (int)Math.Pow(2, i);
                
                decimalValue += bit * power;
            }

            return decimalValue;

            
        }
    }
}
