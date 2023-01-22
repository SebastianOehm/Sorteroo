using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteroo
{
    internal class SortingLogic
    {
        static public int[] Sorter(int[] array)
        {
            while (true) 
            {
                int i = 0;
                bool swap = false;
                while (i < array.Length - 1)
                {
                    if (array[i] > array[i+1])
                    {
                    int tmp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = tmp;
                    swap = true;
                    }
                i++;
                }
                if (swap == false) { break; }
            }
            return array;
        }
        public static bool DoesContain(int[] array, int number) 
        {
            bool answer = false;
            foreach (int item in array)
            {
                if (item == number) { answer = true; }
            }
            return answer;
        }
    }
}
