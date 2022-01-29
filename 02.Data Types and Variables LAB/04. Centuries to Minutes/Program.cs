using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int houts = days * 24;
            int min = houts * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {houts} hours = {min} minutes");


        }
    }
}
