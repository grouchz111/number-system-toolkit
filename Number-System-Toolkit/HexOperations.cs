using System;

namespace ConsoleApp1
{
    class HexOperations
    {
        public static void HexForward()
        {
            Console.Write("Enter decimal number: ");
            int decimalNum = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {decimalNum}");
            Console.WriteLine($"You entered: {decimalNum}");
            int original = decimalNum;
            string hex = "";

            Console.WriteLine($"Steps to convert {original} to hexadecimal:");

            if (decimalNum == 0)
            {
                Console.WriteLine("Hexadecimal: 0");
            }
            else
            {
                while (decimalNum > 0)
                {
                    int remainder = decimalNum % 16;
                    string hexDigit = remainder < 10
                        ? remainder.ToString()
                        : ((char)('A' + remainder - 10)).ToString();

                    Console.WriteLine($"{decimalNum} ÷ 16 = {decimalNum / 16} remainder {hexDigit}");

                    hex = hexDigit + hex;
                    decimalNum /= 16;
                }

                Console.WriteLine($"Hexadecimal: {hex}");
                
            }
        }
        public static void HexBackward()
        {
            string hexInput = InputHelper.ReadString("Enter hexadecimal number: ").ToUpper();
            int decimalValue = 0;
            Console.WriteLine($"Steps to convert {hexInput} to decimal:");

            for (int i = 0; i < hexInput.Length; i++)
            {
                char c = hexInput[hexInput.Length - 1 - i];
                int digit = char.IsDigit(c) ? c - '0' : c - 'A' + 10;
                int power = (int)Math.Pow(16, i);
                Console.WriteLine($"{digit} × 16^{i} = {digit * power}");
                decimalValue += digit * power;
            }

            Console.WriteLine($"Decimal: {decimalValue}");
            
        }
        public static int HexBackwardMath(string hexInput)
        {
            
            
            int decimalValue = 0;
            Console.WriteLine($"Steps to convert {hexInput} to decimal:");

            for (int i = 0; i < hexInput.Length; i++)
            {
                char c = hexInput[hexInput.Length - 1 - i];
                int digit = char.IsDigit(c) ? c - '0' : c - 'A' + 10;
                int power = (int)Math.Pow(16, i);
                Console.WriteLine($"{digit} × 16^{i} = {digit * power}");
                decimalValue += digit * power;

            }

            Console.WriteLine($"Decimal: {decimalValue}");
            return decimalValue;
            
        }
    }
}