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
            int i;
            int temp = 0;
            bool success = false;
            while (!success) 
            {
                i = 0;
                bool swap = false;
                while (i < arr.Length - 1)
                {
                    if (arr[i] > arr[i+1])
                    {
                    temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    swap = true;
                    }
                i++;
                }
                if (swap == false) { break; }
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
