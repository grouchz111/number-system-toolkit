using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp1
{
    class ViewsResult
    {
        public static void WaitUntilKeypress()
        {
            Console.WriteLine("Press a key to continue to the Main Menu...");
            Console.ReadKey(true);
        }
    }
}