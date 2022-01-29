using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> words = new Dictionary<string,int>();

            foreach (var word in input)
            {
                string lowerCase = word.ToLower();

                if (words.ContainsKey(lowerCase))
                {
                    words[lowerCase]++;
                }
                else
                {
                    words.Add(lowerCase,1);
                }
            }

            foreach (var word in words)
            {
                if (word.Value%2!=0)
                {
                    Console.Write($"{word.Key} ");
                }
                //else
                //{
                //    Console.WriteLine($"{word.Key} ");
                //}
            }
        }
    }
}
