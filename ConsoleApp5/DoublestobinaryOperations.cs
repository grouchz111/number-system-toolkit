using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class DoublestobinaryOperations
    {
        public static void doublestobinaryBinForward()
        {
            {
                double decimalNumber;
                Console.Write("Enter a decimal number (use ','!): ");
                string Decimalstring = Console.ReadLine();
                
                if (Decimalstring.Contains('.'))
                {
                    Console.WriteLine("ERROR: Use a ',' as the decimal separator!");
                    return;
                }
                else
                {
                    decimalNumber = Convert.ToDouble(Decimalstring);
                }

                int integerPart = (int)Math.Floor(decimalNumber);
                double fractionalPart = decimalNumber - integerPart;

                Console.WriteLine("\n--- Integer Part Conversion ---");
                string binaryInteger = "";
                int a = integerPart;

                while (a > 0)
                {
                    int remainder = a % 2;
                    Console.WriteLine($"{a} ÷ 2 = {a / 2} remainder {remainder}");
                    binaryInteger = remainder + binaryInteger;
                    a /= 2;
                }

                Console.WriteLine($"Binary (integer): {binaryInteger}");

                Console.WriteLine("\n--- Fractional Part Conversion ---");
                string binaryFraction = "";
                double frac = fractionalPart;
                int precision = 3;

                for (int i = 0; i < precision; i++)
                {
                    frac *= 2;
                    int bit = (int)Math.Floor(frac);
                    binaryFraction += bit;
                    Console.WriteLine($"{frac / 2} × 2 = {frac} → bit: {bit}");
                    frac -= bit;
                }

                Console.WriteLine($"\nBinary (fraction): {binaryFraction}");
                Console.WriteLine($"\nFinal Binary: {binaryInteger}.{binaryFraction}");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
