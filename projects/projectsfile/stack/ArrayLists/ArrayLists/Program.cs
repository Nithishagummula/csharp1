using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayLists
{
  
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList List = new ArrayList();
            int count = 3;
            for(int i=0;i<count;i++)
            {
                string name = Console.ReadLine();
                int Age = int.Parse(Console.ReadLine());
                List.Add(new person() { Name = name, Age = Age });
                
           
                }
            foreach(person p in List)
            {
                Console.WriteLine(p.ToString());
            }
            Console.ReadLine();
            }

        }
        class person
        {
            public string Name
            {
                get;
                set;
            }
            public int Age
            {
                get;
                set;
            }
            public override string ToString()
            {
                return Name + "-" + Age;
            }
        }
}
