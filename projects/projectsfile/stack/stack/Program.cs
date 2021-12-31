using System;
using System.IO;
using System.Collections;
namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
               Stack stackobj= new Stack();
                int count = 3;
                for (int i = 0; i < count; i++)
                {
                    string name = Console.ReadLine();
                    int Age = int.Parse(Console.ReadLine());
                stackobj.Push(new Person() { Name = name, Age = Age });


                }
                for(int i=0;i<count;i++)
            {
                Person p = (Person)stackobj.Pop();
                Console.WriteLine(p.ToString());
            }
               
            }
        class Person
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
    }
    

