using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tplexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(() => Dowork(1, 2000));
            t1.Start();
            Task t2 = new Task(() => Dowork(2, 1000));
            t2.Start();
            Task t3 = new Task(() => Dowork(3, 3500));
            t3.Start();

            Console.WriteLine("press any key to exit.\n");
            Console.ReadKey();
        }

        static void Dowork(int id, int sleep)
        {
            Console.WriteLine("Task {0} is beginning...", id);
            Thread.Sleep(sleep);
            Console.WriteLine("Task {0} is completed...", id);
        }
    }
}
        
    

