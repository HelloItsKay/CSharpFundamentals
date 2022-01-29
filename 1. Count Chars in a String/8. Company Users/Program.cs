using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _8._Company_Users
{
    class Program
    {
        static void Main(string[] args)

        {
            Dictionary<string, List<string>> companyDictionary = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                if (input[0] == "End")
                {
                    break;
                }

                string name = input[0];
                string id = input[1];


                if (!companyDictionary.ContainsKey(name))
                {
                    companyDictionary.Add(name, new List<string>());

                }

                companyDictionary[name].Add(id);




            }

            Dictionary<string, List<string>> sortedName = companyDictionary
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in sortedName)
            {
                Console.WriteLine($"{item.Key}");

                List<string> uniqueNames = item.Value.Distinct().ToList();

                foreach (var item2 in uniqueNames)
                {
                    Console.WriteLine($"-- {item2}");
                }
            }

        }
    }
}
