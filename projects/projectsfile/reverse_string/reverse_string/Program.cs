using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            
           Console.WriteLine("provide a string");
            string input = Console.ReadLine();
            string reverse = string.Empty;
            int length = input.Length - 1;
            while(length>=0)
            {
                reverse = reverse + input[length];
                length--;
            }
            Console.WriteLine($"reverse string is:{reverse}");

        }
   
    }
}
