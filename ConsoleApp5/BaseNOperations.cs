using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class BaseNOperations
    {
        public static void NForward()
        {
            Console.Write("Enter a decimal number: ");
            int number = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {number}");
            Console.Write("Enter target base (2–36): ");
            int baseN = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {baseN}");

            const string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            string result = "";
            Console.WriteLine($"Steps to convert {number} to base-{baseN}:");
            int original = number;

            if (number == 0) Console.WriteLine("0");
            else
            {
                while (number > 0)
                {
                    int remainder = number % baseN;
                    Console.WriteLine($"{number} ÷ {baseN} = {number / baseN} remainder {digits[remainder]}");
                    result = digits[remainder] + result;
                    number /= baseN;
                }

                Console.WriteLine($"Base-{baseN}: {(result == "" ? "0" : result)}");
                ViewsResult.WaitUntilKeypress();
            }
        }
        public static void NBackward()
        {
            Console.Write("Enter a number in base-N: ");
            string inputNum = Console.ReadLine().ToUpper();
            Console.Write("Enter the base (2–36): ");
            int baseN = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {baseN}");

            const string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            int result = 0;
            Console.WriteLine($"Steps to convert {inputNum} from base-{baseN} to decimal:");
            for (int i = 0; i < inputNum.Length; i++)
            {
                char c = inputNum[inputNum.Length - 1 - i];
                int digit = digits.IndexOf(c);
                int power = (int)Math.Pow(baseN, i);
                Console.WriteLine($"{digit} × {baseN}^{i} = {digit * power}");
                result += digit * power;
            }

            Console.WriteLine($"Decimal: {result}");
            ViewsResult.WaitUntilKeypress();
        }
    }
}