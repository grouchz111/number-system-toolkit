using System;

namespace ConsoleApp1
{
    public static class InputHelper
    {
        public static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    return result; // success
                }

                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }


        public static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, out double result))
                {
                    return result; // success
                }

                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
    }

