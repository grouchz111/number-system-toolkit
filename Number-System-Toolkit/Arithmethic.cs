using System;

namespace ConsoleApp1
{
    class ArithmethicOperations
    {
        public static void ArithmethicForward()
        {
            string system = InputHelper.ReadString(
                "Choose system: binary(1), decimal(2), hex(3), octal(4), roman(5), base-N(6), unary(7), duodecimal(8), vigesimal(9), balanced ternary(10), bijective(11), negabinary(12), factorial(13): ");

            string num1 = InputHelper.ReadString("First number: ");
            string num2 = InputHelper.ReadString("Second number: ");
            string op = InputHelper.ReadString("Operation (+ - * /): ");

            int a = 0;
            int b = 0;

            switch (system)
            {
                case "1": // Binary
                    a = BinaryOperations.ConvertBinaryBackwardMath(num1);
                    b = BinaryOperations.ConvertBinaryBackwardMath(num2);
                    break;

                case "2": // Decimal
                    a = Convert.ToInt32(num1);
                    b = Convert.ToInt32(num2);
                    break;

                case "3": // Hex
                    a = HexOperations.HexBackwardMath(num1);
                    b = HexOperations.HexBackwardMath(num2);
                    break;

                case "4": // Octal
                    a = OctalOperations.OctalBackwardMath(num1);
                    b = OctalOperations.OctalBackwardMath(num2);
                    break;

                case "5": // Roman
                    a = RomanOperations.RomanBackwardMath(num1.ToUpper());
                    b = RomanOperations.RomanBackwardMath(num2.ToUpper());
                    break;

                case "6": // Base-N
                    a = BaseNOperations.NBackwardMath(num1);
                    b = BaseNOperations.NBackwardMath(num2);
                    break;

                case "7": // Unary
                    a = UnaryOperations.UnaryBackwardMath(num1);
                    b = UnaryOperations.UnaryBackwardMath(num2);
                    break;

                case "8": // Duodecimal
                    a = DuodecimalOperations.DuodecimalBackwardMath(num1);
                    b = DuodecimalOperations.DuodecimalBackwardMath(num2);
                    break;

                case "9": // Vigesimal
                    a = VigesimalOperations.VigesimalBackwardMath(num1);
                    b = VigesimalOperations.VigesimalBackwardMath(num2);
                    break;

                case "10": // Balanced ternary
                    a = BalancedTernaryOperations.BalancedTernaryBackwardMath(num1);
                    b = BalancedTernaryOperations.BalancedTernaryBackwardMath(num2);
                    break;

                case "11": // Bijective base-26
                    a = BijectiveOperations.BijectiveBackwardMath(num1);
                    b = BijectiveOperations.BijectiveBackwardMath(num2);
                    break;

                case "12": // Negabinary
                    a = NBinaryOperations.BackwardMath(num1);
                    b = NBinaryOperations.BackwardMath(num2);
                    break;

                case "13": // Factorial
                    a = FactorialOperations.FactorialBinBackwardMath(num1);
                    b = FactorialOperations.FactorialBinBackwardMath(num2);
                    break;

                default:
                    Console.WriteLine("Invalid number system.");
                    return;
            }

            int result;

            switch (op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        return;
                    }
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return;
            }

            Console.WriteLine($"Decimal: {result}");
            Console.WriteLine($"Binary: {Convert.ToString(result, 2)}");
            Console.WriteLine($"Octal: {Convert.ToString(result, 8)}");
            Console.WriteLine($"Hex: {Convert.ToString(result, 16).ToUpper()}");

            ViewsResult.WaitUntilKeypress();
        }
    }
}
