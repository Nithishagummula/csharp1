using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n, m, i;
            int result;
            Console.WriteLine("enter first number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            m = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=m;i++)
            {
                int result = n * m;
                Console.WriteLine("Result: {0}*{1}={2}", n, m, result);
            }
        }
    }
}
