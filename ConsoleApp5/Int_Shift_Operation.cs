using System;

namespace ConsoleApp1
{
    class IntShiftOperations
    {
        public static void IntShiftMenu()
        {
            Console.WriteLine("What's the int?");
            int a = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {a}");
            Console.WriteLine($"You entered: {a}");

            if (a == 0)
            {
                Console.WriteLine("Binary: 0");
                return;
            }

            Console.WriteLine("Enter direction (R for Right, L for Left):");
            char c = Console.ReadLine().ToUpper()[0];

            Console.Write("Enter number of positions to shift: ");
            int shift = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {shift}");

            if (c == 'L')
            {
                IntShiftLeft(a, shift);
            }
            else if (c == 'R')
            {
                IntShiftRight(a, shift);
            }
            else
            {
                Console.WriteLine("Invalid direction entered.");
            }
        }

        public static void IntShiftLeft(int a, int shift)
        {
            int shifted = a << shift;
            Console.WriteLine($"{a} << {shift} = {shifted}");
            Console.WriteLine("Binary: " + Convert.ToString(shifted, 2));
        }

        public static void IntShiftRight(int a, int shift)
        {
            int shifted = a >> shift;
            Console.WriteLine($"{a} >> {shift} = {shifted}");
            Console.WriteLine("Binary: " + Convert.ToString(shifted, 2));
        }
    }
}
