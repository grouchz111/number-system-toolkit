using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp5;

namespace ConsoleApp1
{
    class ViewsResult
    {
        public static void WaitUntilKeypress()
        {
            Console.ReadKey(true);
            Console.WriteLine("Press a key to continue to the Main Menu...");
        }
    }
}