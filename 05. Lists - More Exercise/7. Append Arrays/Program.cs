using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split('|' )
                .ToList();
            List<int> result = new List<int>();

            for (int i =numbers.Count-1 ; i>= 0; i--)
            {
                List<int> temp = numbers[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                result.AddRange(temp);
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
