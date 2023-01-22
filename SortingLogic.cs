using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteroo
{
    internal class SortingLogic
    {
        static public int[] Sorter(int[] arr)
        {
            int i = 0;
            int x = 0;
            int y = 0;
            while (i < arr.Length - 1)
            {
                if (arr[i] > arr[i++])
                {
                    x = arr[i];
                    y = arr[i + 1];
                    arr[i] = y;
                    arr[i + 1] = x;
                }
                i++;
            }
            return arr;
        }
        public static bool DoesContain(int[] arr, int number) 
        {
            bool answer = false;
            foreach (int item in arr)
            {
                if (item == number) { answer = true; }
            }
            return answer;
        }
    }
}
