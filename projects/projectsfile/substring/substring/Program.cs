using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substring
{
    class Program
    {
        static int countNonEmptySubstr(string str)
        {
            int n = str.Length;
            return n * (n + 1) / 2;
        }

        // Driver Code
        public static void Main()
        {
            string s = "abcde";
            Console.Write(countNonEmptySubstr(s));
        }
    }

}

