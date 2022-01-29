using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<double>> students=new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());

                }
                students[name].Add(grade);
            }

            Dictionary<string, List<double>> grades = students
                .Where(s => s.Value.Average() >= 4.5)
                .OrderByDescending(s => s.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);


            foreach (var item in grades)
            {
                    Console.WriteLine( $"{item.Key} -> {item.Value.Average():F2}");
                
            }
        }
    }
}
