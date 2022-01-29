using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp7
{
    class Program
    {



        static void Main(string[] args)
        {

            int times = int.Parse(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(@"\A((\@([A-Z][a-z]{2,})\@: \[\d+\]\|\[\d+\]\|\[\d+\]\|)|(\*([A-Z][a-z]{2,})\*: \[\d+\]\|\[\d+\]\|\[\d+\]\|))");
                var matches = regex.Matches(input);
                Regex numReg = new Regex(@"\d+");
                Regex tagReg = new Regex(@"([A-Z][a-z]{2,})");

                if (numReg.Matches(input).Count > 3)
                {
                    Console.WriteLine("Valid message not found!");
                    continue;
                }

                var digMatches = numReg.Matches(input);
                if (matches.Count > 0)
                {
                    string tag = tagReg.Match(input).Value;
                    List<char> chars = new List<char>();

                    foreach (Match match in digMatches)
                    {
                        if (int.Parse(match.Value) > 255)
                        {
                            Console.WriteLine("Valid message not found!");
                            break;
                        }

                        chars.Add((char)int.Parse(match.Value));




                    }
                    Console.WriteLine($"{tag}: {chars[0]}{chars[1]}{chars[2]}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }

        }

    }
}