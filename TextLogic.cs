using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteroo
{
    internal class TextLogic
    {
        public static int inputToInt()
        {
            int result = 0;
            bool success = false;
            while (!success)
            {
                try
                {
                    Console.Write("\nEnter a (non-decimal) number \n>");
                    result = int.Parse(Console.ReadLine());
                    success = true;
                    return result;
                }
                catch
                {
                    Console.WriteLine("Error. Enter a valid number.");
                    continue;
                }
            }
            return result;
        }
    }
}
