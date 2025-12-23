using System;

namespace ConsoleApp1
{
    class OctalOperations
    {
        public static void OctalForward()
        {
            Console.Write("Enter a decimal number to convert to octal: ");
            int decimalNum = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {decimalNum}");
            Console.WriteLine($"You entered: {decimalNum}");
            int original = decimalNum;
            string octal = "";
            Console.WriteLine($"Steps to convert {original} to octal:");

            if (decimalNum == 0) Console.WriteLine("Octal: 0");
            else
            {
                while (decimalNum > 0)
                {
                    int remainder = decimalNum % 8;
                    Console.WriteLine($"{decimalNum} ÷ 8 = {decimalNum / 8} remainder {remainder}");
                    octal = remainder + octal;
                    decimalNum /= 8;
                }

                Console.WriteLine("Octal: " + octal);
                ViewsResult.WaitUntilKeypress();
            }
        }
        public static void OctalBackward()
        {
            Console.Write("Enter an octal number to convert to decimal: ");
            string octalInput = Console.ReadLine();
            int decimalValue = 0;
            Console.WriteLine($"Steps to convert {octalInput} to decimal:");

            for (int i = 0; i < octalInput.Length; i++)
            {
                int digit = octalInput[octalInput.Length - 1 - i] - '0';
                int power = (int)Math.Pow(8, i);
                Console.WriteLine($"{digit} × 8^{i} = {digit * power}");
                decimalValue += digit * power;
            }

            Console.WriteLine($"Decimal: " + decimalValue);
            ViewsResult.WaitUntilKeypress();
        }
    }
}