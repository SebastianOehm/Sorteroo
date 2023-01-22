namespace Sorteroo
{
    internal class Sorting
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 2, 5, 70, 42, 61, 50, 22 };
            array = SortingLogic.Sorter(array);
            int c = 0;
            foreach(int i in array) 
            {
                c++;
                if(c < array.Length)
                {
                    Console.Write(i+", ");
                } else { Console.Write(i); }
                 
            }
            int check = TextLogic.inputToInt();
            if(SortingLogic.DoesContain(array, check))
            {
                Console.WriteLine($"Array does contain \"{check}\".");  
            } else 
            { 
                Console.WriteLine($"Array does NOT contain \"{check}\"."); 
            }
        }        
    }
}