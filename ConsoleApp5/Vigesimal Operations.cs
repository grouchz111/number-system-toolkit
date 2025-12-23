using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class VigesimalOperations
    {
        public static void VigesimalForward()
        {
            Console.Write("Enter decimal number: ");
            int num20 = InputHelper.ReadInt("Enter decimal number: "); Console.WriteLine($"You entered: {num20}");
            Console.WriteLine($"You entered: {num20}");
            if (num20 == 0) Console.WriteLine("Vigesimal: 0");
                    else
                    {
                        int temp = num20;
                        string res = "";
                        while (temp > 0)
                        {
                            int r = temp % 20;
                            string d = r < 10 ? r.ToString() : ((char)('A' + r - 10)).ToString();
                            Console.WriteLine($"{temp} ÷ 20 = {temp / 20} remainder {d}");
                            res = d + res;
                            temp /= 20;
                        }
                        Console.WriteLine("Vigesimal: " + res);
                    }
        }
    }
}