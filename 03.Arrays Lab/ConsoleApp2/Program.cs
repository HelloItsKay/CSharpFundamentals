using System;
using System.ComponentModel;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = number % 10 + number / 10 % 10 + number / 100 % 10 + number / 1000 % 10;
            int n = number.ToString().Length;
            Console.WriteLine(sum);
            Console.WriteLine(n);
        }
    }
}
