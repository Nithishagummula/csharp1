using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_of_char
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Provide a string");
            string inputString = Console.ReadLine();
            while (inputString.Length > 0) 
            {
               int countOfChar = 0;
                Console.Write($"{inputString[0]}=");
                for (int i = 0; i < inputString.Length; i++) ;
                {
                    int i = 0;
                    if (inputString[0]== inputString[i])
                    {
                        countOfChar++;

                    }
                }
                Console.WriteLine($"{countOfChar}");
               inputString =inputString.Replace(inputString[0].ToString(), string.Empty);

            }
        }
    }
}
