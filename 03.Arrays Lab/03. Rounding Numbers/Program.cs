using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                double numbers = arr[i];
                double roundNumbers = Math.Round(numbers, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{(decimal)numbers} => {(decimal)roundNumbers}");
            }
;

        }
    }
}
