using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp8
{
    class Program
    {



        static void Main(string[] args)
        {

            int times = int.Parse(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                string input = Console.ReadLine();
                List<string> inputSplit = input.Split().ToList();
                string forWrds = inputSplit[inputSplit.Count - 1];
                Regex regex = new Regex(@"(\*([A-Z][a-z]+)\*: \[\w\]\|\[\w\]\|\[\w\]\|)|(\@([A-Z][a-z]+)\@: \[\w\]\|\[\w\]\|\[\w\]\|)");
                var matches = regex.Matches(input);
                Regex wrdReg = new Regex(@"\w");    
                Regex tagReg = new Regex(@"(\*([A-Z][a-z]+)\*)|(\@([A-Z][a-z]+)\@)");

                if (wrdReg.Matches(forWrds).Count > 3)
                {
                    Console.WriteLine("Valid message not found!");
                    continue;
                }

                var wrdMatches = wrdReg.Matches(forWrds);
                if (matches.Count > 0)
                {
                    string tag = tagReg.Match(input).Value;
                    tag = tag.Replace("*", "");
                    tag = tag.Replace("@", "");


                    List<int> result = new List<int>();

                    foreach (Match match in wrdMatches)
                    {

                        result.Add((int)char.Parse(match.Value));

                    }
                    Console.WriteLine($"{tag}: {result[0]} {result[1]} {result[2]}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }

        }

    }
}