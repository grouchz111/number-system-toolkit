using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class ShiftIntOperations
    {
        public static void SIO()
        {
            Console.WriteLine("whats the int?");
            int a = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {a}");
            Console.WriteLine($"You entered: {a}");
            if (a == 0)
            {
                Console.WriteLine("Binary: 0");
            }
            else
            {
                Console.WriteLine("Shift by how many positions?");
                Console.WriteLine("Enter direction (R for Right, L for Left):");
                char c = Console.ReadLine().ToUpper()[0];

                Console.Write("Enter number of positions to shift: ");
                int shift = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {shift}");

                int shifted;
                if (c == 'R')
                {
                    shifted = a >> shift;
                    Console.WriteLine($"{a} >> {shift} = {shifted}");
                    Console.WriteLine("Binary: " + Convert.ToString(shifted, 2));
                }
                else if (c == 'L')
                {
                    shifted = a << shift;
                    Console.WriteLine($"{a} << {shift} = {shifted}");
                    Console.WriteLine("Binary: " + Convert.ToString(shifted, 2));
                }
                else
                {
                    Console.WriteLine("Invalid direction. Use R or L.");
                }


            }
        }
        public static void SIORight()
        {
            Console.WriteLine("enter the number line");
            var median = Console.ReadLine(); ;
            var numbers = median.Select(c => int.Parse(c.ToString())).OrderBy(n => n).ToList();

            int count = numbers.Count;
            if (count % 2 == 1)
            {

                Console.WriteLine($"Median: {numbers[count / 2]}");
            }
            else
            {

                int mid1 = numbers[(count / 2) - 1];
                int mid2 = numbers[count / 2];
                double mid3 = ((mid1 + mid2) / 2);
                Console.WriteLine($"Median:" + mid3);
            }
        }
    }
}