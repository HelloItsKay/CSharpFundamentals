using System;

namespace _01.Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal meters = decimal.Parse(Console.ReadLine());
            meters = meters / 1000;
            Console.WriteLine($"{meters:f2}");
        }
    }
}
