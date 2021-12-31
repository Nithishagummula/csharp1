using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeTest
{
    class Details
    {
        public int RollNo
        {
            get;
            set;
        }
        public String Name
        {
            get;
            set;
        }
        public String CourseJoined
        {
            get;
            set;
        }
        public int FeePaidSoFar
        {
            get;
            set;
        }
        public int DueAmount
        {
            get
            {
                return FeePaidSoFar;
            }
        }
        public int TotalFee
        {
            get
            {
                if (CourseJoined.ToLower() == "c#")
                    return 2000;
                else if (CourseJoined.ToLower() == "asp.net")
                    return 3000;
                return 0;
            }
        }

        public Details(int rollNo, String name, String Coursejoined)
        {
            RollNo = rollNo;
            Name = name;
            CourseJoined = CourseJoined;

        }

        public void Payment(int amount)
        {
            FeePaidSoFar += amount;
        }
        public void Print()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Student RollNo:{RollNo}");
            Console.WriteLine($"Student CourseJoined:{CourseJoined}");
            Console.WriteLine($"Student TotalFee:{TotalFee}");
            Console.WriteLine($"Student Fee Paid SoFar:{FeePaidSoFar}");
            Console.WriteLine($"Student DueAmount:{DueAmount}");

        }
        class Program
        {
            static void Main(string[] args)
            {
                Details BunnyDetails = new Details(1, "Bunny", "c#");
                Details SunnyDetails = new Details(2, "Sunny", "asp.net");
                BunnyDetails.Payment(500);
                SunnyDetails.Payment(300);
                BunnyDetails.Print();
                Console.WriteLine("\n");
                SunnyDetails.Print();
            }
        }
    }
}
