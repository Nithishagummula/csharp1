using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Laptop
    {
        public void print()
        {
            System.Console.WriteLine("name");
            String name = Console.ReadLine();
            System.Console.WriteLine("Ram:");
            String Ram = Console.ReadLine();
  
        }

    }


    class program : Laptop
    {
        public void method()
        {
            System.Console.WriteLine("processor");
            String processor = Console.ReadLine();
        }
        static void Main(String[] args)
        {
            program p = new program();
            p.print();
            p.method();
        }
    }
}


