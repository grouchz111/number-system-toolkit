using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace NumberSystemToolkit
{
    class MedianOperations
    {
        public static void MedianForward()
        {
            Console.WriteLine("enter the number line");
            var median = Console.ReadLine();
            var numbers = median
                .Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => InputHelper.ReadInt(s))
                .OrderBy(n => n)
                .ToList();

            int count = numbers.Count;
            if (count % 2 == 1)
            {
                Console.WriteLine($"Median: {numbers[count / 2]}");
            }
            else
            {
                int mid1 = numbers[(count / 2) - 1];
                int mid2 = numbers[count / 2];
                double mid3 = (mid1 + mid2) / 2.0;
                Console.WriteLine($"Median:" + mid3);
            }
            
        }
    }
}