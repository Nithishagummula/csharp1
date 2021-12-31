using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Details BunnyDetails = new Details(1, "Bunny", "c#");
            Details SunnyDetails = new Details(2, "Sunny", "ASP.NET");
            BunnyDetails.Payment(300);
            SunnyDetails.Payment(400);
            BunnyDetails.Print();
            Console.WriteLine("\n");
            SunnyDetails.Print();
        }
    }
    class Details
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string CourseJoined { get; set; }
        public int FeePaidSoFar { get; set; }
        public int DueAmount
        {
            get
            {
                return TotalFee - FeePaidSoFar;
            }
        }

        /// <summary>
        /// Property to determine total fee based on enrolled course
        /// </summary>
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

        public Details(int rollNo, string name, string courseJoined)
        {
            RollNo = rollNo;
            Name = name;
            CourseJoined = courseJoined;
        }

        public void Payment(int amount)
        {
            FeePaidSoFar += amount;
        }
        public void Print()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Course Joined: {CourseJoined}");
            Console.WriteLine($"Total Fee: {TotalFee}");
            Console.WriteLine($"Fee Paid So Far: {FeePaidSoFar}");
            Console.WriteLine($"Due Amount: {DueAmount}");
        }
    }
}

