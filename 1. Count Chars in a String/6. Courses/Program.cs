using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesDictionary = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "end")
                {
                    break;
                }

                string course = input[0];
                string name = input[1];

                if (!coursesDictionary.ContainsKey(course))
                {
                    coursesDictionary.Add(course, new List<string>());

                }
                coursesDictionary[course].Add(name);



            }
            Dictionary<string, List<string>> sortedCourses = coursesDictionary

           .OrderByDescending(x => x.Value.Count)
           .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in sortedCourses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                item.Value.Sort();

                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"-- {item2}");
                }

            }
        }
    }
}
