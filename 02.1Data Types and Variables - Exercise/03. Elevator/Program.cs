using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

           double numberOfCourses = (double)numberOfPeople / capacity;
            Console.WriteLine(Math.Ceiling(numberOfCourses));
        }
    }
}
