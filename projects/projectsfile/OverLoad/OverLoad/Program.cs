using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoad
{
    class parent
    {
        public void Test()
        {
            System.Console.WriteLine("parent metod is called");
        }
        public void show()
        {
            System.Console.WriteLine("parent method is showed");
        }
    }
    class child : parent 
    {
        public void Gift()
        {
            System.Console.WriteLine("child method is called");
        }
        public void show(int i)
        {
            System.Console.WriteLine("i=" + i);
        }

        static void Main(string[] args)
        {
            child c = new child();
            c.Test();
            c.Gift();
            c.show();
            c.show(4+5);
        }
    }
}
