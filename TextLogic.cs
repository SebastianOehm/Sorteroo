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
            while (true)
            {
                try
                {
                    Console.Write("\nEnter a (non-decimal) number \n>");
                    int result = int.Parse(Console.ReadLine());
                    return result;
                }
                catch
                {
                    Console.WriteLine("Error. Enter a valid number.");
                    continue;
                }
            }
        }
    }
}
