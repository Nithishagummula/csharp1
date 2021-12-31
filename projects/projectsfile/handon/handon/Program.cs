using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace handon
{
    class GetDetails
    {

        public void Details()
        {
            string path = @"C:\\New folder\\details.txt";
            FileStream objfstream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(objfstream);
        }
        class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }
}
