using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Random rnd = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                int pos = rnd.Next(words.Count);

                string word = words[i];
                words[i] = words[pos];
                words[pos] = word;

            }

            Console.WriteLine(string.Join('\n', words));
        }
    }
}
