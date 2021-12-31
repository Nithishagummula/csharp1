using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tplexample2
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i=0; i<10; i++)
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine("i= " + i);
                Thread.Sleep(1000);
            });
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }

    }
}
