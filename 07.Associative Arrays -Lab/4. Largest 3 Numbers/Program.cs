using System;
using System.Linq;

namespace _4._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] sorted = numbers.OrderByDescending(x => x)
                .ToArray();

            int count = sorted.Length;

            if (count>3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{sorted[i]} ");
                }
            }
            else if (count<3)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"{sorted[i]} ");
                }
            }
        }
    }
}
