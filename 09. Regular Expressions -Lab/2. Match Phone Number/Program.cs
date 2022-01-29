using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result = new List<string>();
            string pattern = @"(\+359 2 \d{3} \d{4}\b)|(\+359-2-\d{3}-\d{4}\b)";

            string text = Console.ReadLine();

            Regex regex = new Regex(pattern);


            var match = regex.Matches(text);



            foreach (Match item in match)
            {
                result.Add(item.Value);
            }

            Console.WriteLine(String.Join(", ", result));

        }
    }
}