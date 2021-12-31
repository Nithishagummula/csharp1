using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace taskparallellibrary
{
    class Iterations
    {
        private static void RunMillionIterations()
        {
            string x = "";
            for (int iIndex = 0; iIndex < 1000000; iIndex++)
            {
                x = x + "s";
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                
                Parallel.For(0, 1000000, x => RunMillionIterations());
                Console.Read();
            }
        }
    }
}
    
        
    

