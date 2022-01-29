using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Triangle(i);
            }

            for (int i = number - 1; i > 0; i--)
            {
                Triangle(i);
            }
        }

        static void Triangle(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
