using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string secondName, double grade)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Grade = grade;

        }
        public double newGrade()
        {
            return this.Grade;
        }

        public override string ToString()
        {
            return string.Format(this.FirstName, this.SecondName, this.Grade);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();



            for (int i = 0; i < countOfStudents; i++)
            {
                string[] info = Console.ReadLine()
                    .Split(" ");

                string firstName = info[0];
                string secondName = info[1];
                double grade = double.Parse(info[2]);

                Student student = new Student(firstName, secondName, grade);
                students.Add(student);
               

            }

            students.OrderByDescending(x => x.Grade).ThenBy(x => x.FirstName).ToList();
            List<Student> sortedStudents = students.OrderByDescending(t => t.Grade).ThenBy(t => t.FirstName).ThenBy(t => t.SecondName).ToList();

            foreach (Student x in sortedStudents)
            {
                Console.WriteLine($"{x.FirstName} {x.SecondName}: {x.Grade:f2}");
            }
        }
    }
}
