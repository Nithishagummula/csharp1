using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondlargest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8,9,10,11 };
            Array.Sort(array); //sorting array  
            Array.Reverse(array); // Reverse Sorting array value  
            Console.WriteLine("Second Highest Value In Array " + array[1]);

            foreach (var result in array)
            {
                Console.Write(result + " "); // Array values 
            }
            Console.ReadKey();
        }
    }
}
