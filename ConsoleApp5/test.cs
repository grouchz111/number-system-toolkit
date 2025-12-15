using System;
using System.IO;
using System.Globalization;

namespace ConsoleApp1
{
    class TestRunner
    {
        public static void Main()
        {
            Console.WriteLine("===== RUNNING UNIT TESTS WITHOUT FRAMEWORK =====\n");

            // Helper to run a test with pre-filled input
            void RunTest(string name, string inputData, Action action)
            {
                Console.WriteLine($"--- TEST: {name} ---");
                var oldIn = Console.In;
                try
                {
                    // Set the input
                    Console.SetIn(new StringReader(inputData));
                    action();
                    Console.WriteLine("PASS\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}\n");
                }
                finally
                {
                    Console.SetIn(oldIn); // Restore original input
                }
            }

            // ===== All 20 tests with example inputs =====

            RunTest("Binary Forward", "42\n", Binary_Operations.ConvertToBinaryForward);
            RunTest("Binary Backward", "101010\n", Binary_Operations.ConvertBinaryBackward);
            RunTest("Hex Forward", "255\n", Hex_Operations.HexForward);
            RunTest("Hex Backward", "FF\n", Hex_Operations.HexBackward);
            RunTest("Octal Forward", "83\n", Octal_Operations.OctalForward);
            RunTest("Octal Backward", "123\n", Octal_Operations.OctalBackward);
            RunTest("Roman Forward", "1999\n", Roman_Operations.RomanForward);
            RunTest("Roman Backward", "MCMXCIX\n", Roman_Operations.RomanBackward);
            RunTest("Base-N Forward", "255\n16\n", Base_N_Operations.NForward);
            RunTest("Base-N Backward", "FF\n16\n", Base_N_Operations.NBackward);

            // Unary: use tally marks
            RunTest("Unary Forward", "|||||\n", Unary_Operations.UnaryForward);

            RunTest("Duodecimal Forward", "19\n", Duodecimal_Operations.DuodecimalForward);
            RunTest("Vigesimal Forward", "39\n", Vigesimal_Operations.VigesimalForward);
            RunTest("Balanced Ternary Forward", "10\n", Balanced_Ternary_Operations.BalancedTernaryForward);
            RunTest("Bijective Forward", "703\n", BijectiveOperations.BijectiveForward); // should be AAA
            RunTest("Negabinary Forward", "6\n", Negabinary_operations.NegaBinForward);
            RunTest("Factorial Forward", "463\n", Factorial_operations.FactorialBinForward);

            // Arithmetic: decimal addition
            RunTest("Arithmetic", "2\n5\n10\n+\n", Aritmethic_operations.AritmethicForward);

            // Double→Binary: use invariant culture
            RunTest("Double→Binary", "10.625\n", doublestobinary_operations.doublestobinaryBinForward);

            // Int Shift: example 16 << 2
            RunTest("Int Shift", "16\nL\n2\n", IntShiftOperations.IntShiftMenu);

            Console.WriteLine("===== ALL TESTS EXECUTED =====");
        }
    }
}
