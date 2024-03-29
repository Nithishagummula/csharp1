﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Person
    {
        public string firstName;
        public string lastName;
        public int idNumber;


 
        public Person(String firstName, String lastName, int idNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.idNumber = idNumber;
        }


      
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + idNumber);
        }
    }


    class Student : Person
    {
        private int[] testScores;
        public Student(string firstName, string lastName, int id, int[] testScores)
            : base(firstName, lastName, id)
        {
            this.testScores = testScores;
            this.firstName = firstName;
            this.lastName = lastName;
            this.idNumber = id;
        }
        public char calculate()
        {
            float average = 0;
            float sum = 0;
            char grade = ' ';
            for (int i = 0, length = this.testScores.Length; i < length; i++)
            {
                sum += this.testScores[i];
            }
            average = sum / (float)this.testScores.Length;
            if (90 <= average && average <= 100)
            {
                grade = 'O';
            }
            else if (80 <= average && average < 90)
            {
                grade = 'E';
            }
            else if (70 <= average && average < 80)
            {
                grade = 'A';
            }
            else if (55 <= average && average < 70)
            {
                grade = 'P';
            }
            else if (40 <= average && average < 55)
            {
                grade = 'D';
            }
            else
            {
                grade = 'T';
            }
            return grade;
        }
    }
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter the first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter the last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of scores: ");
            int numScores = int.Parse(Console.ReadLine());
            int[] testScores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                Console.Write("Enter test score {0}: ", (i + 1));
                testScores[i] = int.Parse(Console.ReadLine());
            }


            Student s = new Student(firstName, lastName, id, testScores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.calculate());




            Console.ReadLine();
        }
    }
}

